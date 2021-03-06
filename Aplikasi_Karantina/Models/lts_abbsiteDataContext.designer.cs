﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikasi_Karantina.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_karantina")]
	public partial class lts_abbsiteDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_m_data_karantina(tbl_m_data_karantina instance);
    partial void Updatetbl_m_data_karantina(tbl_m_data_karantina instance);
    partial void Deletetbl_m_data_karantina(tbl_m_data_karantina instance);
    partial void Inserttbl_m_mess(tbl_m_mess instance);
    partial void Updatetbl_m_mess(tbl_m_mess instance);
    partial void Deletetbl_m_mess(tbl_m_mess instance);
    partial void Inserttbl_m_kamar(tbl_m_kamar instance);
    partial void Updatetbl_m_kamar(tbl_m_kamar instance);
    partial void Deletetbl_m_kamar(tbl_m_kamar instance);
    #endregion
		
		public lts_abbsiteDataContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["db_karantinaConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public lts_abbsiteDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lts_abbsiteDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lts_abbsiteDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lts_abbsiteDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_m_data_karantina> tbl_m_data_karantinas
		{
			get
			{
				return this.GetTable<tbl_m_data_karantina>();
			}
		}
		
		public System.Data.Linq.Table<tbl_m_mess> tbl_m_messes
		{
			get
			{
				return this.GetTable<tbl_m_mess>();
			}
		}
		
		public System.Data.Linq.Table<vw_mess_kamar> vw_mess_kamars
		{
			get
			{
				return this.GetTable<vw_mess_kamar>();
			}
		}
		
		public System.Data.Linq.Table<tbl_m_kamar> tbl_m_kamars
		{
			get
			{
				return this.GetTable<tbl_m_kamar>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EditDataKarantina")]
		public int EditDataKarantina([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_data_karantina, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nama, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> tanggal_mulai, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> tanggal_akhir, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nama_mess, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string no_kamar)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_data_karantina, nama, tanggal_mulai, tanggal_akhir, nama_mess, no_kamar);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EditMasterMess")]
		public int EditMasterMess([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_master_mess, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nama_mess)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_master_mess, nama_mess);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InputMasterMess")]
		public int InputMasterMess([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_master_mess, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nama_mess)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_master_mess, nama_mess);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.HapusMasterMess")]
		public int HapusMasterMess([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_master_mess)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_master_mess);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InputMasterKamar")]
		public int InputMasterKamar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_master_kamar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_master_mess, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string no_kamar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> tgl_terakhir_dipakai, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string status)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_master_kamar, id_master_mess, no_kamar, tgl_terakhir_dipakai, status);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.HapusMasterKamar")]
		public int HapusMasterKamar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_master_kamar)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_master_kamar);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateStatusKamar")]
		public int UpdateStatusKamar()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.HapusDataKarantina")]
		public ISingleResult<HapusDataKarantinaResult> HapusDataKarantina([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_data_karantina, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> tanggal_akhir, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nama_mess, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string no_kamar)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_data_karantina, tanggal_akhir, nama_mess, no_kamar);
			return ((ISingleResult<HapusDataKarantinaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InputDataKarantina")]
		public ISingleResult<InputDataKarantinaResult> InputDataKarantina([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_data_karantina, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nama, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> tanggal_mulai, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> tanggal_akhir, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nama_mess, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string no_kamar)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_data_karantina, nama, tanggal_mulai, tanggal_akhir, nama_mess, no_kamar);
			return ((ISingleResult<InputDataKarantinaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EditMasterKamar")]
		public int EditMasterKamar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_master_kamar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string id_master_mess, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string no_kamar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> tgl_terakhir_dipakai, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string status)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_master_kamar, id_master_mess, no_kamar, tgl_terakhir_dipakai, status);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_m_data_karantina")]
	public partial class tbl_m_data_karantina : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_data_karantina;
		
		private string _nama;
		
		private System.Nullable<System.DateTime> _tanggal_mulai;
		
		private System.Nullable<System.DateTime> _tanggal_akhir;
		
		private string _nama_mess;
		
		private string _no_kamar;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_data_karantinaChanging(string value);
    partial void Onid_data_karantinaChanged();
    partial void OnnamaChanging(string value);
    partial void OnnamaChanged();
    partial void Ontanggal_mulaiChanging(System.Nullable<System.DateTime> value);
    partial void Ontanggal_mulaiChanged();
    partial void Ontanggal_akhirChanging(System.Nullable<System.DateTime> value);
    partial void Ontanggal_akhirChanged();
    partial void Onnama_messChanging(string value);
    partial void Onnama_messChanged();
    partial void Onno_kamarChanging(string value);
    partial void Onno_kamarChanged();
    #endregion
		
		public tbl_m_data_karantina()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_data_karantina", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_data_karantina
		{
			get
			{
				return this._id_data_karantina;
			}
			set
			{
				if ((this._id_data_karantina != value))
				{
					this.Onid_data_karantinaChanging(value);
					this.SendPropertyChanging();
					this._id_data_karantina = value;
					this.SendPropertyChanged("id_data_karantina");
					this.Onid_data_karantinaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama", DbType="NVarChar(50)")]
		public string nama
		{
			get
			{
				return this._nama;
			}
			set
			{
				if ((this._nama != value))
				{
					this.OnnamaChanging(value);
					this.SendPropertyChanging();
					this._nama = value;
					this.SendPropertyChanged("nama");
					this.OnnamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tanggal_mulai", DbType="DateTime")]
		public System.Nullable<System.DateTime> tanggal_mulai
		{
			get
			{
				return this._tanggal_mulai;
			}
			set
			{
				if ((this._tanggal_mulai != value))
				{
					this.Ontanggal_mulaiChanging(value);
					this.SendPropertyChanging();
					this._tanggal_mulai = value;
					this.SendPropertyChanged("tanggal_mulai");
					this.Ontanggal_mulaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tanggal_akhir", DbType="DateTime")]
		public System.Nullable<System.DateTime> tanggal_akhir
		{
			get
			{
				return this._tanggal_akhir;
			}
			set
			{
				if ((this._tanggal_akhir != value))
				{
					this.Ontanggal_akhirChanging(value);
					this.SendPropertyChanging();
					this._tanggal_akhir = value;
					this.SendPropertyChanged("tanggal_akhir");
					this.Ontanggal_akhirChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_mess", DbType="NVarChar(50)")]
		public string nama_mess
		{
			get
			{
				return this._nama_mess;
			}
			set
			{
				if ((this._nama_mess != value))
				{
					this.Onnama_messChanging(value);
					this.SendPropertyChanging();
					this._nama_mess = value;
					this.SendPropertyChanged("nama_mess");
					this.Onnama_messChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no_kamar", DbType="NVarChar(50)")]
		public string no_kamar
		{
			get
			{
				return this._no_kamar;
			}
			set
			{
				if ((this._no_kamar != value))
				{
					this.Onno_kamarChanging(value);
					this.SendPropertyChanging();
					this._no_kamar = value;
					this.SendPropertyChanged("no_kamar");
					this.Onno_kamarChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_m_mess")]
	public partial class tbl_m_mess : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_master_mess;
		
		private string _nama_mess;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_master_messChanging(string value);
    partial void Onid_master_messChanged();
    partial void Onnama_messChanging(string value);
    partial void Onnama_messChanged();
    #endregion
		
		public tbl_m_mess()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_master_mess", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_master_mess
		{
			get
			{
				return this._id_master_mess;
			}
			set
			{
				if ((this._id_master_mess != value))
				{
					this.Onid_master_messChanging(value);
					this.SendPropertyChanging();
					this._id_master_mess = value;
					this.SendPropertyChanged("id_master_mess");
					this.Onid_master_messChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_mess", DbType="NVarChar(50)")]
		public string nama_mess
		{
			get
			{
				return this._nama_mess;
			}
			set
			{
				if ((this._nama_mess != value))
				{
					this.Onnama_messChanging(value);
					this.SendPropertyChanging();
					this._nama_mess = value;
					this.SendPropertyChanged("nama_mess");
					this.Onnama_messChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vw_mess_kamar")]
	public partial class vw_mess_kamar
	{
		
		private string _id_master_kamar;
		
		private string _id_master_mess;
		
		private string _nama_mess;
		
		private string _no_kamar;
		
		private System.Nullable<System.DateTime> _tgl_terakhir_dipakai;
		
		private string _status;
		
		public vw_mess_kamar()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_master_kamar", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string id_master_kamar
		{
			get
			{
				return this._id_master_kamar;
			}
			set
			{
				if ((this._id_master_kamar != value))
				{
					this._id_master_kamar = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_master_mess", DbType="NVarChar(50)")]
		public string id_master_mess
		{
			get
			{
				return this._id_master_mess;
			}
			set
			{
				if ((this._id_master_mess != value))
				{
					this._id_master_mess = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_mess", DbType="NVarChar(50)")]
		public string nama_mess
		{
			get
			{
				return this._nama_mess;
			}
			set
			{
				if ((this._nama_mess != value))
				{
					this._nama_mess = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no_kamar", DbType="NVarChar(50)")]
		public string no_kamar
		{
			get
			{
				return this._no_kamar;
			}
			set
			{
				if ((this._no_kamar != value))
				{
					this._no_kamar = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tgl_terakhir_dipakai", DbType="DateTime")]
		public System.Nullable<System.DateTime> tgl_terakhir_dipakai
		{
			get
			{
				return this._tgl_terakhir_dipakai;
			}
			set
			{
				if ((this._tgl_terakhir_dipakai != value))
				{
					this._tgl_terakhir_dipakai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this._status = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_m_kamar")]
	public partial class tbl_m_kamar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_master_kamar;
		
		private string _id_master_mess;
		
		private string _no_kamar;
		
		private System.Nullable<System.DateTime> _tgl_terakhir_dipakai;
		
		private string _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_master_kamarChanging(string value);
    partial void Onid_master_kamarChanged();
    partial void Onid_master_messChanging(string value);
    partial void Onid_master_messChanged();
    partial void Onno_kamarChanging(string value);
    partial void Onno_kamarChanged();
    partial void Ontgl_terakhir_dipakaiChanging(System.Nullable<System.DateTime> value);
    partial void Ontgl_terakhir_dipakaiChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public tbl_m_kamar()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_master_kamar", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_master_kamar
		{
			get
			{
				return this._id_master_kamar;
			}
			set
			{
				if ((this._id_master_kamar != value))
				{
					this.Onid_master_kamarChanging(value);
					this.SendPropertyChanging();
					this._id_master_kamar = value;
					this.SendPropertyChanged("id_master_kamar");
					this.Onid_master_kamarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_master_mess", DbType="NVarChar(50)")]
		public string id_master_mess
		{
			get
			{
				return this._id_master_mess;
			}
			set
			{
				if ((this._id_master_mess != value))
				{
					this.Onid_master_messChanging(value);
					this.SendPropertyChanging();
					this._id_master_mess = value;
					this.SendPropertyChanged("id_master_mess");
					this.Onid_master_messChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no_kamar", DbType="NVarChar(50)")]
		public string no_kamar
		{
			get
			{
				return this._no_kamar;
			}
			set
			{
				if ((this._no_kamar != value))
				{
					this.Onno_kamarChanging(value);
					this.SendPropertyChanging();
					this._no_kamar = value;
					this.SendPropertyChanged("no_kamar");
					this.Onno_kamarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tgl_terakhir_dipakai", DbType="DateTime")]
		public System.Nullable<System.DateTime> tgl_terakhir_dipakai
		{
			get
			{
				return this._tgl_terakhir_dipakai;
			}
			set
			{
				if ((this._tgl_terakhir_dipakai != value))
				{
					this.Ontgl_terakhir_dipakaiChanging(value);
					this.SendPropertyChanging();
					this._tgl_terakhir_dipakai = value;
					this.SendPropertyChanged("tgl_terakhir_dipakai");
					this.Ontgl_terakhir_dipakaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
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
	
	public partial class HapusDataKarantinaResult
	{
		
		private System.Nullable<int> _Column1;
		
		public HapusDataKarantinaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="", Storage="_Column1", DbType="Int")]
		public System.Nullable<int> Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
	
	public partial class InputDataKarantinaResult
	{
		
		private System.Nullable<int> _Column1;
		
		public InputDataKarantinaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="", Storage="_Column1", DbType="Int")]
		public System.Nullable<int> Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
