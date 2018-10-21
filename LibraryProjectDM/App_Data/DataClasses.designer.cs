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

namespace LibraryProjectDM.App_Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibraryDataBase")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertRent(Rent instance);
    partial void UpdateRent(Rent instance);
    partial void DeleteRent(Rent instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::LibraryProjectDM.Properties.Settings.Default.LibraryDataBaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<Rent> Rents
		{
			get
			{
				return this.GetTable<Rent>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Book;
		
		private string _Title;
		
		private string _Author;
		
		private string _ISBN;
		
		private System.Nullable<int> _Publishmant_Year;
		
		private System.Nullable<int> _Catalog_Number;
		
		private string _Publishing_House;
		
		private System.Nullable<bool> _Is_Available;
		
		private EntitySet<Rent> _Rents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_BookChanging(int value);
    partial void OnId_BookChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnISBNChanging(string value);
    partial void OnISBNChanged();
    partial void OnPublishmant_YearChanging(System.Nullable<int> value);
    partial void OnPublishmant_YearChanged();
    partial void OnCatalog_NumberChanging(System.Nullable<int> value);
    partial void OnCatalog_NumberChanged();
    partial void OnPublishing_HouseChanging(string value);
    partial void OnPublishing_HouseChanged();
    partial void OnIs_AvailableChanging(System.Nullable<bool> value);
    partial void OnIs_AvailableChanged();
    #endregion
		
		public Book()
		{
			this._Rents = new EntitySet<Rent>(new Action<Rent>(this.attach_Rents), new Action<Rent>(this.detach_Rents));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Book", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id_Book
		{
			get
			{
				return this._Id_Book;
			}
			set
			{
				if ((this._Id_Book != value))
				{
					this.OnId_BookChanging(value);
					this.SendPropertyChanging();
					this._Id_Book = value;
					this.SendPropertyChanged("Id_Book");
					this.OnId_BookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(100)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="VarChar(100)")]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISBN", DbType="VarChar(13)")]
		public string ISBN
		{
			get
			{
				return this._ISBN;
			}
			set
			{
				if ((this._ISBN != value))
				{
					this.OnISBNChanging(value);
					this.SendPropertyChanging();
					this._ISBN = value;
					this.SendPropertyChanged("ISBN");
					this.OnISBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publishmant_Year", DbType="Int")]
		public System.Nullable<int> Publishmant_Year
		{
			get
			{
				return this._Publishmant_Year;
			}
			set
			{
				if ((this._Publishmant_Year != value))
				{
					this.OnPublishmant_YearChanging(value);
					this.SendPropertyChanging();
					this._Publishmant_Year = value;
					this.SendPropertyChanged("Publishmant_Year");
					this.OnPublishmant_YearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Catalog_Number", DbType="Int")]
		public System.Nullable<int> Catalog_Number
		{
			get
			{
				return this._Catalog_Number;
			}
			set
			{
				if ((this._Catalog_Number != value))
				{
					this.OnCatalog_NumberChanging(value);
					this.SendPropertyChanging();
					this._Catalog_Number = value;
					this.SendPropertyChanged("Catalog_Number");
					this.OnCatalog_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publishing_House", DbType="VarChar(100)")]
		public string Publishing_House
		{
			get
			{
				return this._Publishing_House;
			}
			set
			{
				if ((this._Publishing_House != value))
				{
					this.OnPublishing_HouseChanging(value);
					this.SendPropertyChanging();
					this._Publishing_House = value;
					this.SendPropertyChanged("Publishing_House");
					this.OnPublishing_HouseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Is_Available", DbType="Bit")]
		public System.Nullable<bool> Is_Available
		{
			get
			{
				return this._Is_Available;
			}
			set
			{
				if ((this._Is_Available != value))
				{
					this.OnIs_AvailableChanging(value);
					this.SendPropertyChanging();
					this._Is_Available = value;
					this.SendPropertyChanged("Is_Available");
					this.OnIs_AvailableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Rent", Storage="_Rents", ThisKey="Id_Book", OtherKey="ID_Book")]
		public EntitySet<Rent> Rents
		{
			get
			{
				return this._Rents;
			}
			set
			{
				this._Rents.Assign(value);
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
		
		private void attach_Rents(Rent entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_Rents(Rent entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rents")]
	public partial class Rent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Rent;
		
		private System.Nullable<int> _ID_User;
		
		private System.Nullable<int> _ID_Book;
		
		private System.Nullable<System.DateTime> _Rent_Date;
		
		private EntityRef<Book> _Book;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_RentChanging(int value);
    partial void OnID_RentChanged();
    partial void OnID_UserChanging(System.Nullable<int> value);
    partial void OnID_UserChanged();
    partial void OnID_BookChanging(System.Nullable<int> value);
    partial void OnID_BookChanged();
    partial void OnRent_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnRent_DateChanged();
    #endregion
		
		public Rent()
		{
			this._Book = default(EntityRef<Book>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}

	    public Rent(int id_book,int id_rent, int user_id )
	    {
	        ID_Book = id_book;
	        ID_User = user_id;
	        Rent_Date = DateTime.Now;
	        ID_Rent = id_rent;


            this._Book = default(EntityRef<Book>);
	        this._User = default(EntityRef<User>);
	        OnCreated();
	    }



        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Rent", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_Rent
		{
			get
			{
				return this._ID_Rent;
			}
			set
			{
				if ((this._ID_Rent != value))
				{
					this.OnID_RentChanging(value);
					this.SendPropertyChanging();
					this._ID_Rent = value;
					this.SendPropertyChanged("ID_Rent");
					this.OnID_RentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_User", DbType="Int")]
		public System.Nullable<int> ID_User
		{
			get
			{
				return this._ID_User;
			}
			set
			{
				if ((this._ID_User != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_UserChanging(value);
					this.SendPropertyChanging();
					this._ID_User = value;
					this.SendPropertyChanged("ID_User");
					this.OnID_UserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Book", DbType="Int")]
		public System.Nullable<int> ID_Book
		{
			get
			{
				return this._ID_Book;
			}
			set
			{
				if ((this._ID_Book != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_BookChanging(value);
					this.SendPropertyChanging();
					this._ID_Book = value;
					this.SendPropertyChanged("ID_Book");
					this.OnID_BookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rent_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Rent_Date
		{
			get
			{
				return this._Rent_Date;
			}
			set
			{
				if ((this._Rent_Date != value))
				{
					this.OnRent_DateChanging(value);
					this.SendPropertyChanging();
					this._Rent_Date = value;
					this.SendPropertyChanged("Rent_Date");
					this.OnRent_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Rent", Storage="_Book", ThisKey="ID_Book", OtherKey="Id_Book", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.Rents.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.Rents.Add(this);
						this._ID_Book = value.Id_Book;
					}
					else
					{
						this._ID_Book = default(Nullable<int>);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Rent", Storage="_User", ThisKey="ID_User", OtherKey="ID_User", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Rents.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Rents.Add(this);
						this._ID_User = value.ID_User;
					}
					else
					{
						this._ID_User = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_User;
		
		private string _Name;
		
		private string _E_mail;
		
		private string _Phone_Number;
		
		private EntitySet<Rent> _Rents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_UserChanging(int value);
    partial void OnID_UserChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnE_mailChanging(string value);
    partial void OnE_mailChanged();
    partial void OnPhone_NumberChanging(string value);
    partial void OnPhone_NumberChanged();
    #endregion
		
		public User()
		{
			this._Rents = new EntitySet<Rent>(new Action<Rent>(this.attach_Rents), new Action<Rent>(this.detach_Rents));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_User", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_User
		{
			get
			{
				return this._ID_User;
			}
			set
			{
				if ((this._ID_User != value))
				{
					this.OnID_UserChanging(value);
					this.SendPropertyChanging();
					this._ID_User = value;
					this.SendPropertyChanged("ID_User");
					this.OnID_UserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[E-mail]", Storage="_E_mail", DbType="VarChar(100)")]
		public string E_mail
		{
			get
			{
				return this._E_mail;
			}
			set
			{
				if ((this._E_mail != value))
				{
					this.OnE_mailChanging(value);
					this.SendPropertyChanging();
					this._E_mail = value;
					this.SendPropertyChanged("E_mail");
					this.OnE_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_Number", DbType="VarChar(20)")]
		public string Phone_Number
		{
			get
			{
				return this._Phone_Number;
			}
			set
			{
				if ((this._Phone_Number != value))
				{
					this.OnPhone_NumberChanging(value);
					this.SendPropertyChanging();
					this._Phone_Number = value;
					this.SendPropertyChanged("Phone_Number");
					this.OnPhone_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Rent", Storage="_Rents", ThisKey="ID_User", OtherKey="ID_User")]
		public EntitySet<Rent> Rents
		{
			get
			{
				return this._Rents;
			}
			set
			{
				this._Rents.Assign(value);
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
		
		private void attach_Rents(Rent entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Rents(Rent entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
