#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelWebApplication.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HotelDB")]
	public partial class RoomDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    #endregion
		
		public RoomDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HotelDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RoomDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RoomDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RoomDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RoomDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Room")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _roomNun;
		
		private string _kindOfRoom;
		
		private bool _isAvelible;
		
		private int _price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnroomNunChanging(int value);
    partial void OnroomNunChanged();
    partial void OnkindOfRoomChanging(string value);
    partial void OnkindOfRoomChanged();
    partial void OnisAvelibleChanging(bool value);
    partial void OnisAvelibleChanged();
    partial void OnpriceChanging(int value);
    partial void OnpriceChanged();
    #endregion
		
		public Room()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roomNun", DbType="Int NOT NULL")]
		public int roomNun
		{
			get
			{
				return this._roomNun;
			}
			set
			{
				if ((this._roomNun != value))
				{
					this.OnroomNunChanging(value);
					this.SendPropertyChanging();
					this._roomNun = value;
					this.SendPropertyChanged("roomNun");
					this.OnroomNunChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kindOfRoom", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string kindOfRoom
		{
			get
			{
				return this._kindOfRoom;
			}
			set
			{
				if ((this._kindOfRoom != value))
				{
					this.OnkindOfRoomChanging(value);
					this.SendPropertyChanging();
					this._kindOfRoom = value;
					this.SendPropertyChanged("kindOfRoom");
					this.OnkindOfRoomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAvelible", DbType="Bit NOT NULL")]
		public bool isAvelible
		{
			get
			{
				return this._isAvelible;
			}
			set
			{
				if ((this._isAvelible != value))
				{
					this.OnisAvelibleChanging(value);
					this.SendPropertyChanging();
					this._isAvelible = value;
					this.SendPropertyChanged("isAvelible");
					this.OnisAvelibleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int NOT NULL")]
		public int price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
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
}
#pragma warning restore 1591
