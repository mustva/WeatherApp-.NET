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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("WeatherApp.Models", "FK_Forecast_Location", "Location", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WeatherApp.Models.Location), "Forecast", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WeatherApp.Models.Forecast), true)]

#endregion

namespace WeatherApp.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WeatherApp_Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WeatherApp_Entities object using the connection string found in the 'WeatherApp_Entities' section of the application configuration file.
        /// </summary>
        public WeatherApp_Entities() : base("name=WeatherApp_Entities", "WeatherApp_Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WeatherApp_Entities object.
        /// </summary>
        public WeatherApp_Entities(string connectionString) : base(connectionString, "WeatherApp_Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WeatherApp_Entities object.
        /// </summary>
        public WeatherApp_Entities(EntityConnection connection) : base(connection, "WeatherApp_Entities")
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
        public ObjectSet<Forecast> Forecasts
        {
            get
            {
                if ((_Forecasts == null))
                {
                    _Forecasts = base.CreateObjectSet<Forecast>("Forecasts");
                }
                return _Forecasts;
            }
        }
        private ObjectSet<Forecast> _Forecasts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Location> Locations
        {
            get
            {
                if ((_Locations == null))
                {
                    _Locations = base.CreateObjectSet<Location>("Locations");
                }
                return _Locations;
            }
        }
        private ObjectSet<Location> _Locations;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Forecasts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToForecasts(Forecast forecast)
        {
            base.AddObject("Forecasts", forecast);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Locations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLocations(Location location)
        {
            base.AddObject("Locations", location);
        }

        #endregion

        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="forecastId">No Metadata Documentation available.</param>
        public int usp_DeleteForecast(Nullable<global::System.Int32> forecastId)
        {
            ObjectParameter forecastIdParameter;
            if (forecastId.HasValue)
            {
                forecastIdParameter = new ObjectParameter("ForecastId", forecastId);
            }
            else
            {
                forecastIdParameter = new ObjectParameter("ForecastId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction("usp_DeleteForecast", forecastIdParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="locationId">No Metadata Documentation available.</param>
        public int usp_DeleteLocation(Nullable<global::System.Int32> locationId)
        {
            ObjectParameter locationIdParameter;
            if (locationId.HasValue)
            {
                locationIdParameter = new ObjectParameter("LocationId", locationId);
            }
            else
            {
                locationIdParameter = new ObjectParameter("LocationId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction("usp_DeleteLocation", locationIdParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="timePeriod">No Metadata Documentation available.</param>
        /// <param name="symbolVar">No Metadata Documentation available.</param>
        /// <param name="temperature">No Metadata Documentation available.</param>
        /// <param name="nextUpdate">No Metadata Documentation available.</param>
        /// <param name="locationId">No Metadata Documentation available.</param>
        public int usp_InsertForecast(global::System.String timePeriod, global::System.String symbolVar, global::System.String temperature, Nullable<global::System.DateTime> nextUpdate, Nullable<global::System.Int32> locationId)
        {
            ObjectParameter timePeriodParameter;
            if (timePeriod != null)
            {
                timePeriodParameter = new ObjectParameter("TimePeriod", timePeriod);
            }
            else
            {
                timePeriodParameter = new ObjectParameter("TimePeriod", typeof(global::System.String));
            }
    
            ObjectParameter symbolVarParameter;
            if (symbolVar != null)
            {
                symbolVarParameter = new ObjectParameter("SymbolVar", symbolVar);
            }
            else
            {
                symbolVarParameter = new ObjectParameter("SymbolVar", typeof(global::System.String));
            }
    
            ObjectParameter temperatureParameter;
            if (temperature != null)
            {
                temperatureParameter = new ObjectParameter("Temperature", temperature);
            }
            else
            {
                temperatureParameter = new ObjectParameter("Temperature", typeof(global::System.String));
            }
    
            ObjectParameter nextUpdateParameter;
            if (nextUpdate.HasValue)
            {
                nextUpdateParameter = new ObjectParameter("NextUpdate", nextUpdate);
            }
            else
            {
                nextUpdateParameter = new ObjectParameter("NextUpdate", typeof(global::System.DateTime));
            }
    
            ObjectParameter locationIdParameter;
            if (locationId.HasValue)
            {
                locationIdParameter = new ObjectParameter("LocationId", locationId);
            }
            else
            {
                locationIdParameter = new ObjectParameter("LocationId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction("usp_InsertForecast", timePeriodParameter, symbolVarParameter, temperatureParameter, nextUpdateParameter, locationIdParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="geonameId">No Metadata Documentation available.</param>
        /// <param name="country">No Metadata Documentation available.</param>
        /// <param name="county">No Metadata Documentation available.</param>
        /// <param name="city">No Metadata Documentation available.</param>
        /// <param name="citySearch">No Metadata Documentation available.</param>
        /// <param name="nextUpdate">No Metadata Documentation available.</param>
        public int usp_InsertLocation(global::System.String geonameId, global::System.String country, global::System.String county, global::System.String city, global::System.String citySearch, Nullable<global::System.DateTime> nextUpdate)
        {
            ObjectParameter geonameIdParameter;
            if (geonameId != null)
            {
                geonameIdParameter = new ObjectParameter("GeonameId", geonameId);
            }
            else
            {
                geonameIdParameter = new ObjectParameter("GeonameId", typeof(global::System.String));
            }
    
            ObjectParameter countryParameter;
            if (country != null)
            {
                countryParameter = new ObjectParameter("Country", country);
            }
            else
            {
                countryParameter = new ObjectParameter("Country", typeof(global::System.String));
            }
    
            ObjectParameter countyParameter;
            if (county != null)
            {
                countyParameter = new ObjectParameter("County", county);
            }
            else
            {
                countyParameter = new ObjectParameter("County", typeof(global::System.String));
            }
    
            ObjectParameter cityParameter;
            if (city != null)
            {
                cityParameter = new ObjectParameter("City", city);
            }
            else
            {
                cityParameter = new ObjectParameter("City", typeof(global::System.String));
            }
    
            ObjectParameter citySearchParameter;
            if (citySearch != null)
            {
                citySearchParameter = new ObjectParameter("CitySearch", citySearch);
            }
            else
            {
                citySearchParameter = new ObjectParameter("CitySearch", typeof(global::System.String));
            }
    
            ObjectParameter nextUpdateParameter;
            if (nextUpdate.HasValue)
            {
                nextUpdateParameter = new ObjectParameter("NextUpdate", nextUpdate);
            }
            else
            {
                nextUpdateParameter = new ObjectParameter("NextUpdate", typeof(global::System.DateTime));
            }
    
            return base.ExecuteFunction("usp_InsertLocation", geonameIdParameter, countryParameter, countyParameter, cityParameter, citySearchParameter, nextUpdateParameter);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WeatherApp.Models", Name="Forecast")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Forecast : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Forecast object.
        /// </summary>
        /// <param name="forecastId">Initial value of the ForecastId property.</param>
        /// <param name="timePeriod">Initial value of the TimePeriod property.</param>
        /// <param name="symbolVar">Initial value of the SymbolVar property.</param>
        /// <param name="temperature">Initial value of the Temperature property.</param>
        /// <param name="locationId">Initial value of the LocationId property.</param>
        /// <param name="nextUpdate">Initial value of the NextUpdate property.</param>
        public static Forecast CreateForecast(global::System.Int32 forecastId, global::System.String timePeriod, global::System.String symbolVar, global::System.String temperature, global::System.Int32 locationId, global::System.DateTime nextUpdate)
        {
            Forecast forecast = new Forecast();
            forecast.ForecastId = forecastId;
            forecast.TimePeriod = timePeriod;
            forecast.SymbolVar = symbolVar;
            forecast.Temperature = temperature;
            forecast.LocationId = locationId;
            forecast.NextUpdate = nextUpdate;
            return forecast;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ForecastId
        {
            get
            {
                return _ForecastId;
            }
            set
            {
                if (_ForecastId != value)
                {
                    OnForecastIdChanging(value);
                    ReportPropertyChanging("ForecastId");
                    _ForecastId = StructuralObject.SetValidValue(value, "ForecastId");
                    ReportPropertyChanged("ForecastId");
                    OnForecastIdChanged();
                }
            }
        }
        private global::System.Int32 _ForecastId;
        partial void OnForecastIdChanging(global::System.Int32 value);
        partial void OnForecastIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String TimePeriod
        {
            get
            {
                return _TimePeriod;
            }
            set
            {
                OnTimePeriodChanging(value);
                ReportPropertyChanging("TimePeriod");
                _TimePeriod = StructuralObject.SetValidValue(value, false, "TimePeriod");
                ReportPropertyChanged("TimePeriod");
                OnTimePeriodChanged();
            }
        }
        private global::System.String _TimePeriod;
        partial void OnTimePeriodChanging(global::System.String value);
        partial void OnTimePeriodChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SymbolVar
        {
            get
            {
                return _SymbolVar;
            }
            set
            {
                OnSymbolVarChanging(value);
                ReportPropertyChanging("SymbolVar");
                _SymbolVar = StructuralObject.SetValidValue(value, false, "SymbolVar");
                ReportPropertyChanged("SymbolVar");
                OnSymbolVarChanged();
            }
        }
        private global::System.String _SymbolVar;
        partial void OnSymbolVarChanging(global::System.String value);
        partial void OnSymbolVarChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Temperature
        {
            get
            {
                return _Temperature;
            }
            set
            {
                OnTemperatureChanging(value);
                ReportPropertyChanging("Temperature");
                _Temperature = StructuralObject.SetValidValue(value, false, "Temperature");
                ReportPropertyChanged("Temperature");
                OnTemperatureChanged();
            }
        }
        private global::System.String _Temperature;
        partial void OnTemperatureChanging(global::System.String value);
        partial void OnTemperatureChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 LocationId
        {
            get
            {
                return _LocationId;
            }
            set
            {
                OnLocationIdChanging(value);
                ReportPropertyChanging("LocationId");
                _LocationId = StructuralObject.SetValidValue(value, "LocationId");
                ReportPropertyChanged("LocationId");
                OnLocationIdChanged();
            }
        }
        private global::System.Int32 _LocationId;
        partial void OnLocationIdChanging(global::System.Int32 value);
        partial void OnLocationIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime NextUpdate
        {
            get
            {
                return _NextUpdate;
            }
            set
            {
                OnNextUpdateChanging(value);
                ReportPropertyChanging("NextUpdate");
                _NextUpdate = StructuralObject.SetValidValue(value, "NextUpdate");
                ReportPropertyChanged("NextUpdate");
                OnNextUpdateChanged();
            }
        }
        private global::System.DateTime _NextUpdate;
        partial void OnNextUpdateChanging(global::System.DateTime value);
        partial void OnNextUpdateChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WeatherApp.Models", "FK_Forecast_Location", "Location")]
        public Location Location
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Location>("WeatherApp.Models.FK_Forecast_Location", "Location").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Location>("WeatherApp.Models.FK_Forecast_Location", "Location").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Location> LocationReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Location>("WeatherApp.Models.FK_Forecast_Location", "Location");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Location>("WeatherApp.Models.FK_Forecast_Location", "Location", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WeatherApp.Models", Name="Location")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Location : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Location object.
        /// </summary>
        /// <param name="locationId">Initial value of the LocationId property.</param>
        /// <param name="country">Initial value of the Country property.</param>
        /// <param name="county">Initial value of the County property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="citySearch">Initial value of the CitySearch property.</param>
        /// <param name="nextUpdate">Initial value of the NextUpdate property.</param>
        public static Location CreateLocation(global::System.Int32 locationId, global::System.String country, global::System.String county, global::System.String city, global::System.String citySearch, global::System.DateTime nextUpdate)
        {
            Location location = new Location();
            location.LocationId = locationId;
            location.Country = country;
            location.County = county;
            location.City = city;
            location.CitySearch = citySearch;
            location.NextUpdate = nextUpdate;
            return location;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 LocationId
        {
            get
            {
                return _LocationId;
            }
            set
            {
                if (_LocationId != value)
                {
                    OnLocationIdChanging(value);
                    ReportPropertyChanging("LocationId");
                    _LocationId = StructuralObject.SetValidValue(value, "LocationId");
                    ReportPropertyChanged("LocationId");
                    OnLocationIdChanged();
                }
            }
        }
        private global::System.Int32 _LocationId;
        partial void OnLocationIdChanging(global::System.Int32 value);
        partial void OnLocationIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String GeonameId
        {
            get
            {
                return _GeonameId;
            }
            set
            {
                OnGeonameIdChanging(value);
                ReportPropertyChanging("GeonameId");
                _GeonameId = StructuralObject.SetValidValue(value, true, "GeonameId");
                ReportPropertyChanged("GeonameId");
                OnGeonameIdChanged();
            }
        }
        private global::System.String _GeonameId;
        partial void OnGeonameIdChanging(global::System.String value);
        partial void OnGeonameIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, false, "Country");
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String County
        {
            get
            {
                return _County;
            }
            set
            {
                OnCountyChanging(value);
                ReportPropertyChanging("County");
                _County = StructuralObject.SetValidValue(value, false, "County");
                ReportPropertyChanged("County");
                OnCountyChanged();
            }
        }
        private global::System.String _County;
        partial void OnCountyChanging(global::System.String value);
        partial void OnCountyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, false, "City");
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CitySearch
        {
            get
            {
                return _CitySearch;
            }
            set
            {
                OnCitySearchChanging(value);
                ReportPropertyChanging("CitySearch");
                _CitySearch = StructuralObject.SetValidValue(value, false, "CitySearch");
                ReportPropertyChanged("CitySearch");
                OnCitySearchChanged();
            }
        }
        private global::System.String _CitySearch;
        partial void OnCitySearchChanging(global::System.String value);
        partial void OnCitySearchChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime NextUpdate
        {
            get
            {
                return _NextUpdate;
            }
            set
            {
                OnNextUpdateChanging(value);
                ReportPropertyChanging("NextUpdate");
                _NextUpdate = StructuralObject.SetValidValue(value, "NextUpdate");
                ReportPropertyChanged("NextUpdate");
                OnNextUpdateChanged();
            }
        }
        private global::System.DateTime _NextUpdate;
        partial void OnNextUpdateChanging(global::System.DateTime value);
        partial void OnNextUpdateChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WeatherApp.Models", "FK_Forecast_Location", "Forecast")]
        public EntityCollection<Forecast> Forecasts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Forecast>("WeatherApp.Models.FK_Forecast_Location", "Forecast");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Forecast>("WeatherApp.Models.FK_Forecast_Location", "Forecast", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
