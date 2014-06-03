﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Hugo_Rule_Exercise_Service
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class RuleTestEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new RuleTestEntities object using the connection string found in the 'RuleTestEntities' section of the application configuration file.
        /// </summary>
        public RuleTestEntities() : base("name=RuleTestEntities", "RuleTestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RuleTestEntities object.
        /// </summary>
        public RuleTestEntities(string connectionString) : base(connectionString, "RuleTestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RuleTestEntities object.
        /// </summary>
        public RuleTestEntities(EntityConnection connection) : base(connection, "RuleTestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<massinsert> massinserts
        {
            get
            {
                if ((_massinserts == null))
                {
                    _massinserts = base.CreateObjectSet<massinsert>("massinserts");
                }
                return _massinserts;
            }
        }
        private ObjectSet<massinsert> _massinserts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<shape> shapes
        {
            get
            {
                if ((_shapes == null))
                {
                    _shapes = base.CreateObjectSet<shape>("shapes");
                }
                return _shapes;
            }
        }
        private ObjectSet<shape> _shapes;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the massinserts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTomassinserts(massinsert massinsert)
        {
            base.AddObject("massinserts", massinsert);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the shapes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToshapes(shape shape)
        {
            base.AddObject("shapes", shape);
        }

        #endregion

        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public int MassUpdate()
        {
            return base.ExecuteFunction("MassUpdate");
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="RuleTestModel", Name="massinsert")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class massinsert : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new massinsert object.
        /// </summary>
        /// <param name="id_mass">Initial value of the id_mass property.</param>
        public static massinsert Createmassinsert(global::System.Int32 id_mass)
        {
            massinsert massinsert = new massinsert();
            massinsert.id_mass = id_mass;
            return massinsert;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_mass
        {
            get
            {
                return _id_mass;
            }
            set
            {
                if (_id_mass != value)
                {
                    Onid_massChanging(value);
                    ReportPropertyChanging("id_mass");
                    _id_mass = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_mass");
                    Onid_massChanged();
                }
            }
        }
        private global::System.Int32 _id_mass;
        partial void Onid_massChanging(global::System.Int32 value);
        partial void Onid_massChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String shape
        {
            get
            {
                return _shape;
            }
            set
            {
                OnshapeChanging(value);
                ReportPropertyChanging("shape");
                _shape = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("shape");
                OnshapeChanged();
            }
        }
        private global::System.String _shape;
        partial void OnshapeChanging(global::System.String value);
        partial void OnshapeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Byte> is_valid
        {
            get
            {
                return _is_valid;
            }
            set
            {
                Onis_validChanging(value);
                ReportPropertyChanging("is_valid");
                _is_valid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("is_valid");
                Onis_validChanged();
            }
        }
        private Nullable<global::System.Byte> _is_valid;
        partial void Onis_validChanging(Nullable<global::System.Byte> value);
        partial void Onis_validChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="RuleTestModel", Name="shape")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class shape : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new shape object.
        /// </summary>
        /// <param name="id_shape">Initial value of the id_shape property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="coordinates">Initial value of the coordinates property.</param>
        /// <param name="area">Initial value of the area property.</param>
        /// <param name="date_created">Initial value of the date_created property.</param>
        /// <param name="is_valid">Initial value of the is_valid property.</param>
        public static shape Createshape(global::System.Int32 id_shape, global::System.String name, global::System.String coordinates, global::System.Double area, global::System.DateTime date_created, global::System.Byte is_valid)
        {
            shape shape = new shape();
            shape.id_shape = id_shape;
            shape.name = name;
            shape.coordinates = coordinates;
            shape.area = area;
            shape.date_created = date_created;
            shape.is_valid = is_valid;
            return shape;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_shape
        {
            get
            {
                return _id_shape;
            }
            set
            {
                if (_id_shape != value)
                {
                    Onid_shapeChanging(value);
                    ReportPropertyChanging("id_shape");
                    _id_shape = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_shape");
                    Onid_shapeChanged();
                }
            }
        }
        private global::System.Int32 _id_shape;
        partial void Onid_shapeChanging(global::System.Int32 value);
        partial void Onid_shapeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String coordinates
        {
            get
            {
                return _coordinates;
            }
            set
            {
                OncoordinatesChanging(value);
                ReportPropertyChanging("coordinates");
                _coordinates = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("coordinates");
                OncoordinatesChanged();
            }
        }
        private global::System.String _coordinates;
        partial void OncoordinatesChanging(global::System.String value);
        partial void OncoordinatesChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double area
        {
            get
            {
                return _area;
            }
            set
            {
                OnareaChanging(value);
                ReportPropertyChanging("area");
                _area = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("area");
                OnareaChanged();
            }
        }
        private global::System.Double _area;
        partial void OnareaChanging(global::System.Double value);
        partial void OnareaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime date_created
        {
            get
            {
                return _date_created;
            }
            set
            {
                Ondate_createdChanging(value);
                ReportPropertyChanging("date_created");
                _date_created = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("date_created");
                Ondate_createdChanged();
            }
        }
        private global::System.DateTime _date_created;
        partial void Ondate_createdChanging(global::System.DateTime value);
        partial void Ondate_createdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte is_valid
        {
            get
            {
                return _is_valid;
            }
            set
            {
                Onis_validChanging(value);
                ReportPropertyChanging("is_valid");
                _is_valid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("is_valid");
                Onis_validChanged();
            }
        }
        private global::System.Byte _is_valid;
        partial void Onis_validChanging(global::System.Byte value);
        partial void Onis_validChanged();

        #endregion

    
    }

    #endregion

    
}