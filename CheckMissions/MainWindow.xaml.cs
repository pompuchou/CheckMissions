using System;
using System.Data;
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
            MSch.ItemsSource = dc.tbl_schedule;
        }

        private void MSch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DataGrid grid = sender as DataGrid;
                if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
                {
                    DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;
                    CheckMissions.tbl_schedule dr = (CheckMissions.tbl_schedule)dgr.Item;
                    MessageBox.Show("You Clicked: " + dr.sname + dr.SDATE.ToString() + dr.VIST);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}