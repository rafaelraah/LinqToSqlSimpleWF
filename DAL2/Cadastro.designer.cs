﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LinqToSql")]
	public partial class CadastroDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTB_Jogo(TB_Jogo instance);
    partial void UpdateTB_Jogo(TB_Jogo instance);
    partial void DeleteTB_Jogo(TB_Jogo instance);
    #endregion
		
		public CadastroDataContext() : 
				base(global::DAL2.Properties.Settings.Default.LinqToSqlConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CadastroDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CadastroDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CadastroDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CadastroDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TB_Jogo> TB_Jogo
		{
			get
			{
				return this.GetTable<TB_Jogo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_Jogo")]
	public partial class TB_Jogo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_jogo;
		
		private string _ds_nome;
		
		private string _ds_categoria;
		
		private System.Nullable<System.DateTime> _dt_dataCriacao;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_jogoChanging(int value);
    partial void Onid_jogoChanged();
    partial void Onds_nomeChanging(string value);
    partial void Onds_nomeChanged();
    partial void Onds_categoriaChanging(string value);
    partial void Onds_categoriaChanged();
    partial void Ondt_dataCriacaoChanging(System.Nullable<System.DateTime> value);
    partial void Ondt_dataCriacaoChanged();
    #endregion
		
		public TB_Jogo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_jogo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_jogo
		{
			get
			{
				return this._id_jogo;
			}
			set
			{
				if ((this._id_jogo != value))
				{
					this.Onid_jogoChanging(value);
					this.SendPropertyChanging();
					this._id_jogo = value;
					this.SendPropertyChanged("id_jogo");
					this.Onid_jogoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_nome", DbType="VarChar(100)")]
		public string ds_nome
		{
			get
			{
				return this._ds_nome;
			}
			set
			{
				if ((this._ds_nome != value))
				{
					this.Onds_nomeChanging(value);
					this.SendPropertyChanging();
					this._ds_nome = value;
					this.SendPropertyChanged("ds_nome");
					this.Onds_nomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_categoria", DbType="VarChar(100)")]
		public string ds_categoria
		{
			get
			{
				return this._ds_categoria;
			}
			set
			{
				if ((this._ds_categoria != value))
				{
					this.Onds_categoriaChanging(value);
					this.SendPropertyChanging();
					this._ds_categoria = value;
					this.SendPropertyChanged("ds_categoria");
					this.Onds_categoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dt_dataCriacao", DbType="DateTime")]
		public System.Nullable<System.DateTime> dt_dataCriacao
		{
			get
			{
				return this._dt_dataCriacao;
			}
			set
			{
				if ((this._dt_dataCriacao != value))
				{
					this.Ondt_dataCriacaoChanging(value);
					this.SendPropertyChanging();
					this._dt_dataCriacao = value;
					this.SendPropertyChanged("dt_dataCriacao");
					this.Ondt_dataCriacaoChanged();
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
