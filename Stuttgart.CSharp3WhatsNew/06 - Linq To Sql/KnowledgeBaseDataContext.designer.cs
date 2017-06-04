﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampusLaunch.Linq.LinqToSql
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="KnowledgeCenter")]
	public partial class KnowledgeBaseDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertArticleCategoryMapping(ArticleCategoryMapping instance);
    partial void UpdateArticleCategoryMapping(ArticleCategoryMapping instance);
    partial void DeleteArticleCategoryMapping(ArticleCategoryMapping instance);
    partial void InsertArticle(Article instance);
    partial void UpdateArticle(Article instance);
    partial void DeleteArticle(Article instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    #endregion
		
		public KnowledgeBaseDataContextDataContext() : 
				base(global::_05___Linq_To_Sql.Properties.Settings.Default.KnowledgeCenterConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KnowledgeBaseDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KnowledgeBaseDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KnowledgeBaseDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KnowledgeBaseDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ArticleCategoryMapping> ArticleCategoryMappings
		{
			get
			{
				return this.GetTable<ArticleCategoryMapping>();
			}
		}
		
		public System.Data.Linq.Table<Article> Articles
		{
			get
			{
				return this.GetTable<Article>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
	}
	
	[Table(Name="dbo.ArticleCategoryMappings")]
	public partial class ArticleCategoryMapping : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ArticleId;
		
		private int _CategoryId;
		
		private EntityRef<Article> _Article;
		
		private EntityRef<Category> _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnArticleIdChanging(int value);
    partial void OnArticleIdChanged();
    partial void OnCategoryIdChanging(int value);
    partial void OnCategoryIdChanged();
    #endregion
		
		public ArticleCategoryMapping()
		{
			this._Article = default(EntityRef<Article>);
			this._Category = default(EntityRef<Category>);
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[Column(Storage="_ArticleId", DbType="Int NOT NULL")]
		public int ArticleId
		{
			get
			{
				return this._ArticleId;
			}
			set
			{
				if ((this._ArticleId != value))
				{
					if (this._Article.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnArticleIdChanging(value);
					this.SendPropertyChanging();
					this._ArticleId = value;
					this.SendPropertyChanged("ArticleId");
					this.OnArticleIdChanged();
				}
			}
		}
		
		[Column(Storage="_CategoryId", DbType="Int NOT NULL")]
		public int CategoryId
		{
			get
			{
				return this._CategoryId;
			}
			set
			{
				if ((this._CategoryId != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._CategoryId = value;
					this.SendPropertyChanged("CategoryId");
					this.OnCategoryIdChanged();
				}
			}
		}
		
		[Association(Name="Article_ArticleCategoryMapping", Storage="_Article", ThisKey="ArticleId", IsForeignKey=true)]
		public Article Article
		{
			get
			{
				return this._Article.Entity;
			}
			set
			{
				Article previousValue = this._Article.Entity;
				if (((previousValue != value) 
							|| (this._Article.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Article.Entity = null;
						previousValue.ArticleCategoryMappings.Remove(this);
					}
					this._Article.Entity = value;
					if ((value != null))
					{
						value.ArticleCategoryMappings.Add(this);
						this._ArticleId = value.Id;
					}
					else
					{
						this._ArticleId = default(int);
					}
					this.SendPropertyChanged("Article");
				}
			}
		}
		
		[Association(Name="Category_ArticleCategoryMapping", Storage="_Category", ThisKey="CategoryId", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.ArticleCategoryMappings.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.ArticleCategoryMappings.Add(this);
						this._CategoryId = value.Id;
					}
					else
					{
						this._CategoryId = default(int);
					}
					this.SendPropertyChanged("Category");
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
	
	[Table(Name="dbo.Articles")]
	public partial class Article : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Teaser;
		
		private string _Text;
		
		private int _Views;
		
		private System.Nullable<double> _Rating;
		
		private string _AuthorName;
		
		private bool _IsPublished;
		
		private System.DateTime _DateCreated;
		
		private System.Nullable<System.DateTime> _DateEdit;
		
		private int _Level;
		
		private string _FriendlyUrl;
		
		private string _OldId;
		
		private EntitySet<ArticleCategoryMapping> _ArticleCategoryMappings;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnTeaserChanging(string value);
    partial void OnTeaserChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnViewsChanging(int value);
    partial void OnViewsChanged();
    partial void OnRatingChanging(System.Nullable<double> value);
    partial void OnRatingChanged();
    partial void OnAuthorNameChanging(string value);
    partial void OnAuthorNameChanged();
    partial void OnIsPublishedChanging(bool value);
    partial void OnIsPublishedChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    partial void OnDateEditChanging(System.Nullable<System.DateTime> value);
    partial void OnDateEditChanged();
    partial void OnLevelChanging(int value);
    partial void OnLevelChanged();
    partial void OnFriendlyUrlChanging(string value);
    partial void OnFriendlyUrlChanged();
    partial void OnOldIdChanging(string value);
    partial void OnOldIdChanged();
    #endregion
		
		public Article()
		{
			this._ArticleCategoryMappings = new EntitySet<ArticleCategoryMapping>(new Action<ArticleCategoryMapping>(this.attach_ArticleCategoryMappings), new Action<ArticleCategoryMapping>(this.detach_ArticleCategoryMappings));
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[Column(Storage="_Title", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_Teaser", DbType="NVarChar(2000)")]
		public string Teaser
		{
			get
			{
				return this._Teaser;
			}
			set
			{
				if ((this._Teaser != value))
				{
					this.OnTeaserChanging(value);
					this.SendPropertyChanging();
					this._Teaser = value;
					this.SendPropertyChanged("Teaser");
					this.OnTeaserChanged();
				}
			}
		}
		
		[Column(Storage="_Text", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[Column(Storage="_Views", DbType="Int NOT NULL")]
		public int Views
		{
			get
			{
				return this._Views;
			}
			set
			{
				if ((this._Views != value))
				{
					this.OnViewsChanging(value);
					this.SendPropertyChanging();
					this._Views = value;
					this.SendPropertyChanged("Views");
					this.OnViewsChanged();
				}
			}
		}
		
		[Column(Storage="_Rating", DbType="Float")]
		public System.Nullable<double> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this.OnRatingChanging(value);
					this.SendPropertyChanging();
					this._Rating = value;
					this.SendPropertyChanged("Rating");
					this.OnRatingChanged();
				}
			}
		}
		
		[Column(Storage="_AuthorName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string AuthorName
		{
			get
			{
				return this._AuthorName;
			}
			set
			{
				if ((this._AuthorName != value))
				{
					this.OnAuthorNameChanging(value);
					this.SendPropertyChanging();
					this._AuthorName = value;
					this.SendPropertyChanged("AuthorName");
					this.OnAuthorNameChanged();
				}
			}
		}
		
		[Column(Storage="_IsPublished", DbType="Bit NOT NULL")]
		public bool IsPublished
		{
			get
			{
				return this._IsPublished;
			}
			set
			{
				if ((this._IsPublished != value))
				{
					this.OnIsPublishedChanging(value);
					this.SendPropertyChanging();
					this._IsPublished = value;
					this.SendPropertyChanged("IsPublished");
					this.OnIsPublishedChanged();
				}
			}
		}
		
		[Column(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_DateEdit", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateEdit
		{
			get
			{
				return this._DateEdit;
			}
			set
			{
				if ((this._DateEdit != value))
				{
					this.OnDateEditChanging(value);
					this.SendPropertyChanging();
					this._DateEdit = value;
					this.SendPropertyChanged("DateEdit");
					this.OnDateEditChanged();
				}
			}
		}
		
		[Column(Name="[Level]", Storage="_Level", DbType="Int NOT NULL")]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				if ((this._Level != value))
				{
					this.OnLevelChanging(value);
					this.SendPropertyChanging();
					this._Level = value;
					this.SendPropertyChanged("Level");
					this.OnLevelChanged();
				}
			}
		}
		
		[Column(Storage="_FriendlyUrl", DbType="NVarChar(1000)")]
		public string FriendlyUrl
		{
			get
			{
				return this._FriendlyUrl;
			}
			set
			{
				if ((this._FriendlyUrl != value))
				{
					this.OnFriendlyUrlChanging(value);
					this.SendPropertyChanging();
					this._FriendlyUrl = value;
					this.SendPropertyChanged("FriendlyUrl");
					this.OnFriendlyUrlChanged();
				}
			}
		}
		
		[Column(Storage="_OldId", DbType="NVarChar(256)")]
		public string OldId
		{
			get
			{
				return this._OldId;
			}
			set
			{
				if ((this._OldId != value))
				{
					this.OnOldIdChanging(value);
					this.SendPropertyChanging();
					this._OldId = value;
					this.SendPropertyChanged("OldId");
					this.OnOldIdChanged();
				}
			}
		}
		
		[Association(Name="Article_ArticleCategoryMapping", Storage="_ArticleCategoryMappings", OtherKey="ArticleId")]
		public EntitySet<ArticleCategoryMapping> ArticleCategoryMappings
		{
			get
			{
				return this._ArticleCategoryMappings;
			}
			set
			{
				this._ArticleCategoryMappings.Assign(value);
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
		
		private void attach_ArticleCategoryMappings(ArticleCategoryMapping entity)
		{
			this.SendPropertyChanging();
			entity.Article = this;
		}
		
		private void detach_ArticleCategoryMappings(ArticleCategoryMapping entity)
		{
			this.SendPropertyChanging();
			entity.Article = null;
		}
	}
	
	[Table(Name="dbo.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _ParentId;
		
		private string _Title;
		
		private string _FriendlyUrl;
		
		private string _OldId;
		
		private string _LongTitle;
		
		private int _OrderIndex;
		
		private EntitySet<ArticleCategoryMapping> _ArticleCategoryMappings;
		
		private EntitySet<Category> _Categories;
		
		private EntityRef<Category> _Category1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnParentIdChanging(System.Nullable<int> value);
    partial void OnParentIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnFriendlyUrlChanging(string value);
    partial void OnFriendlyUrlChanged();
    partial void OnOldIdChanging(string value);
    partial void OnOldIdChanged();
    partial void OnLongTitleChanging(string value);
    partial void OnLongTitleChanged();
    partial void OnOrderIndexChanging(int value);
    partial void OnOrderIndexChanged();
    #endregion
		
		public Category()
		{
			this._ArticleCategoryMappings = new EntitySet<ArticleCategoryMapping>(new Action<ArticleCategoryMapping>(this.attach_ArticleCategoryMappings), new Action<ArticleCategoryMapping>(this.detach_ArticleCategoryMappings));
			this._Categories = new EntitySet<Category>(new Action<Category>(this.attach_Categories), new Action<Category>(this.detach_Categories));
			this._Category1 = default(EntityRef<Category>);
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[Column(Storage="_ParentId", DbType="Int")]
		public System.Nullable<int> ParentId
		{
			get
			{
				return this._ParentId;
			}
			set
			{
				if ((this._ParentId != value))
				{
					if (this._Category1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnParentIdChanging(value);
					this.SendPropertyChanging();
					this._ParentId = value;
					this.SendPropertyChanged("ParentId");
					this.OnParentIdChanged();
				}
			}
		}
		
		[Column(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_FriendlyUrl", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string FriendlyUrl
		{
			get
			{
				return this._FriendlyUrl;
			}
			set
			{
				if ((this._FriendlyUrl != value))
				{
					this.OnFriendlyUrlChanging(value);
					this.SendPropertyChanging();
					this._FriendlyUrl = value;
					this.SendPropertyChanged("FriendlyUrl");
					this.OnFriendlyUrlChanged();
				}
			}
		}
		
		[Column(Storage="_OldId", DbType="NVarChar(256)")]
		public string OldId
		{
			get
			{
				return this._OldId;
			}
			set
			{
				if ((this._OldId != value))
				{
					this.OnOldIdChanging(value);
					this.SendPropertyChanging();
					this._OldId = value;
					this.SendPropertyChanged("OldId");
					this.OnOldIdChanged();
				}
			}
		}
		
		[Column(Storage="_LongTitle", DbType="NVarChar(255)")]
		public string LongTitle
		{
			get
			{
				return this._LongTitle;
			}
			set
			{
				if ((this._LongTitle != value))
				{
					this.OnLongTitleChanging(value);
					this.SendPropertyChanging();
					this._LongTitle = value;
					this.SendPropertyChanged("LongTitle");
					this.OnLongTitleChanged();
				}
			}
		}
		
		[Column(Storage="_OrderIndex", DbType="Int NOT NULL")]
		public int OrderIndex
		{
			get
			{
				return this._OrderIndex;
			}
			set
			{
				if ((this._OrderIndex != value))
				{
					this.OnOrderIndexChanging(value);
					this.SendPropertyChanging();
					this._OrderIndex = value;
					this.SendPropertyChanged("OrderIndex");
					this.OnOrderIndexChanged();
				}
			}
		}
		
		[Association(Name="Category_ArticleCategoryMapping", Storage="_ArticleCategoryMappings", OtherKey="CategoryId")]
		public EntitySet<ArticleCategoryMapping> ArticleCategoryMappings
		{
			get
			{
				return this._ArticleCategoryMappings;
			}
			set
			{
				this._ArticleCategoryMappings.Assign(value);
			}
		}
		
		[Association(Name="Category_Category", Storage="_Categories", OtherKey="ParentId")]
		public EntitySet<Category> Categories
		{
			get
			{
				return this._Categories;
			}
			set
			{
				this._Categories.Assign(value);
			}
		}
		
		[Association(Name="Category_Category", Storage="_Category1", ThisKey="ParentId", IsForeignKey=true)]
		public Category Category1
		{
			get
			{
				return this._Category1.Entity;
			}
			set
			{
				Category previousValue = this._Category1.Entity;
				if (((previousValue != value) 
							|| (this._Category1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category1.Entity = null;
						previousValue.Categories.Remove(this);
					}
					this._Category1.Entity = value;
					if ((value != null))
					{
						value.Categories.Add(this);
						this._ParentId = value.Id;
					}
					else
					{
						this._ParentId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Category1");
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
		
		private void attach_ArticleCategoryMappings(ArticleCategoryMapping entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_ArticleCategoryMappings(ArticleCategoryMapping entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
		
		private void attach_Categories(Category entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = this;
		}
		
		private void detach_Categories(Category entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = null;
		}
	}
}
#pragma warning restore 1591
