﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckMissions
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="al")]
	public partial class MissionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 擴充性方法定義
    partial void OnCreated();
    partial void Inserttbl_schedule(tbl_schedule instance);
    partial void Updatetbl_schedule(tbl_schedule instance);
    partial void Deletetbl_schedule(tbl_schedule instance);
    partial void Insertp_institute(p_institute instance);
    partial void Updatep_institute(p_institute instance);
    partial void Deletep_institute(p_institute instance);
    #endregion
		
		public MissionDataContext() : 
				base(global::CheckMissions.Properties.Settings.Default.alConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MissionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MissionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MissionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MissionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_schedule> tbl_schedule
		{
			get
			{
				return this.GetTable<tbl_schedule>();
			}
		}
		
		public System.Data.Linq.Table<p_institute> p_institute
		{
			get
			{
				return this.GetTable<p_institute>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_check_mission_chronic_by_SDATE_VIST")]
		public ISingleResult<sp_check_mission_chronic_by_SDATE_VISTResult> sp_check_mission_chronic_by_SDATE_VIST([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> d, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VIST", DbType="NVarChar(10)")] string vIST)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), d, vIST);
			return ((ISingleResult<sp_check_mission_chronic_by_SDATE_VISTResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_check_mission_person_by_sname_SDATE_VIST")]
		public ISingleResult<sp_check_mission_person_by_sname_SDATE_VISTResult> sp_check_mission_person_by_sname_SDATE_VIST([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(10)")] string i, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> d, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VIST", DbType="NVarChar(10)")] string vIST)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), i, d, vIST);
			return ((ISingleResult<sp_check_mission_person_by_sname_SDATE_VISTResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_check_mission_medication_by_sname_SDATE_VIST")]
		public ISingleResult<sp_check_mission_medication_by_sname_SDATE_VISTResult> sp_check_mission_medication_by_sname_SDATE_VIST([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(10)")] string i, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> d, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VIST", DbType="NVarChar(10)")] string vIST)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), i, d, vIST);
			return ((ISingleResult<sp_check_mission_medication_by_sname_SDATE_VISTResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_schedule")]
	public partial class tbl_schedule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _mid;
		
		private System.Nullable<int> _smid;
		
		private string _iid;
		
		private string _sname;
		
		private System.DateTime _SDATE;
		
		private string _VIST;
		
		private string _N;
		
		private string _remark;
		
    #region 擴充性方法定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmidChanging(System.Nullable<int> value);
    partial void OnmidChanged();
    partial void OnsmidChanging(System.Nullable<int> value);
    partial void OnsmidChanged();
    partial void OniidChanging(string value);
    partial void OniidChanged();
    partial void OnsnameChanging(string value);
    partial void OnsnameChanged();
    partial void OnSDATEChanging(System.DateTime value);
    partial void OnSDATEChanged();
    partial void OnVISTChanging(string value);
    partial void OnVISTChanged();
    partial void OnNChanging(string value);
    partial void OnNChanged();
    partial void OnremarkChanging(string value);
    partial void OnremarkChanged();
    #endregion
		
		public tbl_schedule()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mid", DbType="Int")]
		public System.Nullable<int> mid
		{
			get
			{
				return this._mid;
			}
			set
			{
				if ((this._mid != value))
				{
					this.OnmidChanging(value);
					this.SendPropertyChanging();
					this._mid = value;
					this.SendPropertyChanged("mid");
					this.OnmidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_smid", DbType="Int")]
		public System.Nullable<int> smid
		{
			get
			{
				return this._smid;
			}
			set
			{
				if ((this._smid != value))
				{
					this.OnsmidChanging(value);
					this.SendPropertyChanging();
					this._smid = value;
					this.SendPropertyChanged("smid");
					this.OnsmidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iid", DbType="VarChar(50)")]
		public string iid
		{
			get
			{
				return this._iid;
			}
			set
			{
				if ((this._iid != value))
				{
					this.OniidChanging(value);
					this.SendPropertyChanging();
					this._iid = value;
					this.SendPropertyChanged("iid");
					this.OniidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sname", DbType="VarChar(50)")]
		public string sname
		{
			get
			{
				return this._sname;
			}
			set
			{
				if ((this._sname != value))
				{
					this.OnsnameChanging(value);
					this.SendPropertyChanging();
					this._sname = value;
					this.SendPropertyChanged("sname");
					this.OnsnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDATE", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime SDATE
		{
			get
			{
				return this._SDATE;
			}
			set
			{
				if ((this._SDATE != value))
				{
					this.OnSDATEChanging(value);
					this.SendPropertyChanging();
					this._SDATE = value;
					this.SendPropertyChanged("SDATE");
					this.OnSDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VIST", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string VIST
		{
			get
			{
				return this._VIST;
			}
			set
			{
				if ((this._VIST != value))
				{
					this.OnVISTChanging(value);
					this.SendPropertyChanging();
					this._VIST = value;
					this.SendPropertyChanged("VIST");
					this.OnVISTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N", DbType="VarChar(50)")]
		public string N
		{
			get
			{
				return this._N;
			}
			set
			{
				if ((this._N != value))
				{
					this.OnNChanging(value);
					this.SendPropertyChanging();
					this._N = value;
					this.SendPropertyChanged("N");
					this.OnNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_remark", DbType="VarChar(50)")]
		public string remark
		{
			get
			{
				return this._remark;
			}
			set
			{
				if ((this._remark != value))
				{
					this.OnremarkChanging(value);
					this.SendPropertyChanging();
					this._remark = value;
					this.SendPropertyChanged("remark");
					this.OnremarkChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.p_institute")]
	public partial class p_institute : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _iid;
		
		private string _sname;
		
		private string _fname;
		
		private System.Nullable<System.DateTime> _onDate;
		
		private System.Nullable<System.DateTime> _offDate;
		
		private string _remark;
		
    #region 擴充性方法定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OniidChanging(string value);
    partial void OniidChanged();
    partial void OnsnameChanging(string value);
    partial void OnsnameChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnonDateChanging(System.Nullable<System.DateTime> value);
    partial void OnonDateChanged();
    partial void OnoffDateChanging(System.Nullable<System.DateTime> value);
    partial void OnoffDateChanged();
    partial void OnremarkChanging(string value);
    partial void OnremarkChanged();
    #endregion
		
		public p_institute()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iid", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string iid
		{
			get
			{
				return this._iid;
			}
			set
			{
				if ((this._iid != value))
				{
					this.OniidChanging(value);
					this.SendPropertyChanging();
					this._iid = value;
					this.SendPropertyChanged("iid");
					this.OniidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sname", DbType="VarChar(50)")]
		public string sname
		{
			get
			{
				return this._sname;
			}
			set
			{
				if ((this._sname != value))
				{
					this.OnsnameChanging(value);
					this.SendPropertyChanging();
					this._sname = value;
					this.SendPropertyChanged("sname");
					this.OnsnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_onDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> onDate
		{
			get
			{
				return this._onDate;
			}
			set
			{
				if ((this._onDate != value))
				{
					this.OnonDateChanging(value);
					this.SendPropertyChanging();
					this._onDate = value;
					this.SendPropertyChanged("onDate");
					this.OnonDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_offDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> offDate
		{
			get
			{
				return this._offDate;
			}
			set
			{
				if ((this._offDate != value))
				{
					this.OnoffDateChanging(value);
					this.SendPropertyChanging();
					this._offDate = value;
					this.SendPropertyChanged("offDate");
					this.OnoffDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_remark", DbType="VarChar(50)")]
		public string remark
		{
			get
			{
				return this._remark;
			}
			set
			{
				if ((this._remark != value))
				{
					this.OnremarkChanging(value);
					this.SendPropertyChanging();
					this._remark = value;
					this.SendPropertyChanged("remark");
					this.OnremarkChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class sp_check_mission_chronic_by_SDATE_VISTResult
	{
		
		private System.Nullable<int> _total;
		
		private System.Nullable<int> _chronic;
		
		public sp_check_mission_chronic_by_SDATE_VISTResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total", DbType="Int")]
		public System.Nullable<int> total
		{
			get
			{
				return this._total;
			}
			set
			{
				if ((this._total != value))
				{
					this._total = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chronic", DbType="Int")]
		public System.Nullable<int> chronic
		{
			get
			{
				return this._chronic;
			}
			set
			{
				if ((this._chronic != value))
				{
					this._chronic = value;
				}
			}
		}
	}
	
	public partial class sp_check_mission_person_by_sname_SDATE_VISTResult
	{
		
		private System.Nullable<long> _r_id;
		
		private string _uid;
		
		private string _cname;
		
		private string _COMMENT;
		
		public sp_check_mission_person_by_sname_SDATE_VISTResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_r_id", DbType="BigInt")]
		public System.Nullable<long> r_id
		{
			get
			{
				return this._r_id;
			}
			set
			{
				if ((this._r_id != value))
				{
					this._r_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", DbType="VarChar(10)")]
		public string uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this._uid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cname", DbType="NVarChar(50)")]
		public string cname
		{
			get
			{
				return this._cname;
			}
			set
			{
				if ((this._cname != value))
				{
					this._cname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMMENT", DbType="NVarChar(50)")]
		public string COMMENT
		{
			get
			{
				return this._COMMENT;
			}
			set
			{
				if ((this._COMMENT != value))
				{
					this._COMMENT = value;
				}
			}
		}
	}
	
	public partial class sp_check_mission_medication_by_sname_SDATE_VISTResult
	{
		
		private System.Nullable<long> _r_id;
		
		private string _uid;
		
		private string _cname;
		
		private string _r06;
		
		private System.Nullable<double> _TIME_QTY1;
		
		private string _TIMES_DAY;
		
		private string _METHOD;
		
		private string _COMMENT;
		
		public sp_check_mission_medication_by_sname_SDATE_VISTResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_r_id", DbType="BigInt")]
		public System.Nullable<long> r_id
		{
			get
			{
				return this._r_id;
			}
			set
			{
				if ((this._r_id != value))
				{
					this._r_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", DbType="VarChar(10)")]
		public string uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this._uid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cname", DbType="NVarChar(50)")]
		public string cname
		{
			get
			{
				return this._cname;
			}
			set
			{
				if ((this._cname != value))
				{
					this._cname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_r06", DbType="NVarChar(255)")]
		public string r06
		{
			get
			{
				return this._r06;
			}
			set
			{
				if ((this._r06 != value))
				{
					this._r06 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIME_QTY1", DbType="Float")]
		public System.Nullable<double> TIME_QTY1
		{
			get
			{
				return this._TIME_QTY1;
			}
			set
			{
				if ((this._TIME_QTY1 != value))
				{
					this._TIME_QTY1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIMES_DAY", DbType="VarChar(10)")]
		public string TIMES_DAY
		{
			get
			{
				return this._TIMES_DAY;
			}
			set
			{
				if ((this._TIMES_DAY != value))
				{
					this._TIMES_DAY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_METHOD", DbType="VarChar(10)")]
		public string METHOD
		{
			get
			{
				return this._METHOD;
			}
			set
			{
				if ((this._METHOD != value))
				{
					this._METHOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMMENT", DbType="NVarChar(50)")]
		public string COMMENT
		{
			get
			{
				return this._COMMENT;
			}
			set
			{
				if ((this._COMMENT != value))
				{
					this._COMMENT = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
