using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CheckMissions
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MissionDataContext dc = new MissionDataContext();
            ChAll.IsChecked = false;
            CBIns.ItemsSource = from p in dc.p_institute select p.sname;
            CBIns.SelectedIndex = -1;
            Refresh_MschDG();
        }

        private void MSch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DataGrid grid = sender as DataGrid;
                if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
                {
                    MissionDataContext dc = new MissionDataContext();
                    DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;
                    CheckMissions.tbl_schedule dr = (CheckMissions.tbl_schedule)dgr.Item;
                    //MessageBox.Show("You Clicked: " + dr.sname + dr.SDATE.ToString() + dr.VIST);
                    /// 填入資料,來自sname, SDATE, VIST
                    sp_check_mission_chronic_by_SDATE_VISTResult CH = dc.sp_check_mission_chronic_by_SDATE_VIST(dr.SDATE, dr.VIST).First();
                    LbInstitut.Text = dr.SDATE.ToString("yyyy/MM/dd");
                    LbInstitut.Text += (from p in dc.p_institute where p.sname == dr.sname select p.fname).First();
                    LbInstitut.Text += "第" + dr.smid + "次巡診:共" + CH.total + "張處方,其中" + CH.chronic + "張慢箋.";
                    DGPerson.ItemsSource = dc.sp_check_mission_person_by_sname_SDATE_VIST(dr.sname, dr.SDATE, dr.VIST);
                    DGDrug.ItemsSource = dc.sp_check_mission_medication_by_sname_SDATE_VIST(dr.sname, dr.SDATE, dr.VIST);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CBIns_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh_MschDG();
        }

        private void CBIns_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            cb.SelectedIndex = -1;
            Refresh_MschDG();
        }

        private void Refresh_MschDG()
        {
            MissionDataContext dc = new MissionDataContext();
            if (CBIns.SelectedIndex != -1)
            {
                // Specific institute
                string sItem = CBIns.SelectedItem.ToString();
                if (ChAll.IsChecked == true)
                {
                    // all the schedule
                    MSch.ItemsSource = from p in dc.tbl_schedule where p.sname == sItem select p;
                }
                else
                {
                    // in recent days
                    MSch.ItemsSource = from p in dc.tbl_schedule where p.sname == sItem && p.SDATE < DateTime.Now.AddDays(100) && p.SDATE > DateTime.Now.AddDays(-100) select p;
                }
            }
            else
            {
                // All institute
                if (ChAll.IsChecked == true)
                {
                    // all the schedule
                    MSch.ItemsSource = dc.tbl_schedule;
                }
                else
                {
                    // in recent days
                    MSch.ItemsSource = from p in dc.tbl_schedule where p.SDATE < DateTime.Now.AddDays(100) && p.SDATE > DateTime.Now.AddDays(-100) select p;
                }
            }
            //DGPerson.ItemsSource = null;
            //DGDrug.ItemsSource = null;
        }

        private void ChAll_Checked(object sender, RoutedEventArgs e)
        {
            Refresh_MschDG();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            MissionDataContext dc = new MissionDataContext();
            dc.sp_check_mission_schedule_N();
            Refresh_MschDG();
        }
    }
}