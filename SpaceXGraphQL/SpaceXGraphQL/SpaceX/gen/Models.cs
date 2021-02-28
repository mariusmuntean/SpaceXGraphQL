using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using GraphQL;

namespace SpaceXGraphQL.SpaceX.gen {
  public class Types {
    
    #region Query
    public class Query {
      #region members
      /// <summary>
      /// fetch data from the table: "users"
      /// </summary>
      [JsonProperty("users")]
      public List<users> users { get; set; }
    
      /// <summary>
      /// fetch aggregated fields from the table: "users"
      /// </summary>
      [JsonProperty("users_aggregate")]
      public users_aggregate users_aggregate { get; set; }
    
      /// <summary>
      /// fetch data from the table: "users" using primary key columns
      /// </summary>
      [JsonProperty("users_by_pk")]
      public users users_by_pk { get; set; }
    
      [JsonProperty("capsules")]
      public List<Capsule> capsules { get; set; }
    
      [JsonProperty("capsulesPast")]
      public List<Capsule> capsulesPast { get; set; }
    
      [JsonProperty("capsulesUpcoming")]
      public List<Capsule> capsulesUpcoming { get; set; }
    
      [JsonProperty("capsule")]
      public Capsule capsule { get; set; }
    
      [JsonProperty("company")]
      public Info company { get; set; }
    
      [JsonProperty("cores")]
      public List<Core> cores { get; set; }
    
      [JsonProperty("coresPast")]
      public List<Core> coresPast { get; set; }
    
      [JsonProperty("coresUpcoming")]
      public List<Core> coresUpcoming { get; set; }
    
      [JsonProperty("core")]
      public Core core { get; set; }
    
      [JsonProperty("dragons")]
      public List<Dragon> dragons { get; set; }
    
      [JsonProperty("dragon")]
      public Dragon dragon { get; set; }
    
      [JsonProperty("histories")]
      public List<History> histories { get; set; }
    
      [JsonProperty("historiesResult")]
      public HistoriesResult historiesResult { get; set; }
    
      [JsonProperty("history")]
      public History history { get; set; }
    
      [JsonProperty("landpads")]
      public List<Landpad> landpads { get; set; }
    
      [JsonProperty("landpad")]
      public Landpad landpad { get; set; }
    
      [JsonProperty("launches")]
      public List<Launch> launches { get; set; }
    
      [JsonProperty("launchesPast")]
      public List<Launch> launchesPast { get; set; }
    
      [JsonProperty("launchesPastResult")]
      public LaunchesPastResult launchesPastResult { get; set; }
    
      [JsonProperty("launchesUpcoming")]
      public List<Launch> launchesUpcoming { get; set; }
    
      [JsonProperty("launch")]
      public Launch launch { get; set; }
    
      [JsonProperty("launchLatest")]
      public Launch launchLatest { get; set; }
    
      [JsonProperty("launchNext")]
      public Launch launchNext { get; set; }
    
      [JsonProperty("launchpads")]
      public List<Launchpad> launchpads { get; set; }
    
      [JsonProperty("launchpad")]
      public Launchpad launchpad { get; set; }
    
      [JsonProperty("missions")]
      public List<Mission> missions { get; set; }
    
      [JsonProperty("missionsResult")]
      public MissionResult missionsResult { get; set; }
    
      [JsonProperty("mission")]
      public Mission mission { get; set; }
    
      [JsonProperty("payloads")]
      public List<Payload> payloads { get; set; }
    
      [JsonProperty("payload")]
      public Payload payload { get; set; }
    
      [JsonProperty("roadster")]
      public Roadster roadster { get; set; }
    
      [JsonProperty("rockets")]
      public List<Rocket> rockets { get; set; }
    
      [JsonProperty("rocketsResult")]
      public RocketsResult rocketsResult { get; set; }
    
      [JsonProperty("rocket")]
      public Rocket rocket { get; set; }
    
      [JsonProperty("ships")]
      public List<Ship> ships { get; set; }
    
      [JsonProperty("shipsResult")]
      public ShipsResult shipsResult { get; set; }
    
      [JsonProperty("ship")]
      public Ship ship { get; set; }
      #endregion
    }
    #endregion
      /// <summary>
      /// select columns of table "users"
      /// </summary>
    public enum Users_Select_Column {
      /// <summary>
      /// column name
      /// </summary>
      id,
      /// <summary>
      /// column name
      /// </summary>
      name,
      /// <summary>
      /// column name
      /// </summary>
      rocket,
      /// <summary>
      /// column name
      /// </summary>
      timestamp,
      /// <summary>
      /// column name
      /// </summary>
      twitter
    }
    
    
    #region Users_Order_By
    /// <summary>
    /// ordering options when selecting data from "users"
    /// </summary>
    public class Users_Order_By {
      #region members
      public Order_By? id { get; set; }
    
      public Order_By? name { get; set; }
    
      public Order_By? rocket { get; set; }
    
      public Order_By? timestamp { get; set; }
    
      public Order_By? twitter { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
      /// <summary>
      /// column ordering options
      /// </summary>
    public enum Order_By {
      /// <summary>
      /// in the ascending order, nulls last
      /// </summary>
      asc,
      /// <summary>
      /// in the ascending order, nulls first
      /// </summary>
      asc_nulls_first,
      /// <summary>
      /// in the ascending order, nulls last
      /// </summary>
      asc_nulls_last,
      /// <summary>
      /// in the descending order, nulls first
      /// </summary>
      desc,
      /// <summary>
      /// in the descending order, nulls first
      /// </summary>
      desc_nulls_first,
      /// <summary>
      /// in the descending order, nulls last
      /// </summary>
      desc_nulls_last
    }
    
    
    #region Users_Bool_Exp
    /// <summary>
    /// Boolean expression to filter rows from the table "users". All fields are combined with a logical 'AND'.
    /// </summary>
    public class Users_Bool_Exp {
      #region members
      public List<Users_Bool_Exp> _and { get; set; }
    
      public Users_Bool_Exp _not { get; set; }
    
      public List<Users_Bool_Exp> _or { get; set; }
    
      public Uuid_Comparison_Exp id { get; set; }
    
      public String_Comparison_Exp name { get; set; }
    
      public String_Comparison_Exp rocket { get; set; }
    
      public Timestamptz_Comparison_Exp timestamp { get; set; }
    
      public String_Comparison_Exp twitter { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Uuid_Comparison_Exp
    /// <summary>
    /// expression to compare columns of type uuid. All fields are combined with logical 'AND'.
    /// </summary>
    public class Uuid_Comparison_Exp {
      #region members
      public Guid _eq { get; set; }
    
      public Guid _gt { get; set; }
    
      public Guid _gte { get; set; }
    
      public List<Guid> _in { get; set; }
    
      public bool? _is_null { get; set; }
    
      public Guid _lt { get; set; }
    
      public Guid _lte { get; set; }
    
      public Guid _neq { get; set; }
    
      public List<Guid> _nin { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region String_Comparison_Exp
    /// <summary>
    /// expression to compare columns of type String. All fields are combined with logical 'AND'.
    /// </summary>
    public class String_Comparison_Exp {
      #region members
      public string _eq { get; set; }
    
      public string _gt { get; set; }
    
      public string _gte { get; set; }
    
      public string _ilike { get; set; }
    
      public List<string> _in { get; set; }
    
      public bool? _is_null { get; set; }
    
      public string _like { get; set; }
    
      public string _lt { get; set; }
    
      public string _lte { get; set; }
    
      public string _neq { get; set; }
    
      public string _nilike { get; set; }
    
      public List<string> _nin { get; set; }
    
      public string _nlike { get; set; }
    
      public string _nsimilar { get; set; }
    
      public string _similar { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Timestamptz_Comparison_Exp
    /// <summary>
    /// expression to compare columns of type timestamptz. All fields are combined with logical 'AND'.
    /// </summary>
    public class Timestamptz_Comparison_Exp {
      #region members
      public DateTime _eq { get; set; }
    
      public DateTime _gt { get; set; }
    
      public DateTime _gte { get; set; }
    
      public List<DateTime> _in { get; set; }
    
      public bool? _is_null { get; set; }
    
      public DateTime _lt { get; set; }
    
      public DateTime _lte { get; set; }
    
      public DateTime _neq { get; set; }
    
      public List<DateTime> _nin { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region users
    /// <summary>
    /// columns and relationships of "users"
    /// </summary>
    public class users {
      #region members
      [JsonProperty("id")]
      public Guid id { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("rocket")]
      public string rocket { get; set; }
    
      [JsonProperty("timestamp")]
      public DateTime timestamp { get; set; }
    
      [JsonProperty("twitter")]
      public string twitter { get; set; }
      #endregion
    }
    #endregion
    
    #region users_aggregate
    /// <summary>
    /// aggregated selection of "users"
    /// </summary>
    public class users_aggregate {
      #region members
      [JsonProperty("aggregate")]
      public users_aggregate_fields aggregate { get; set; }
    
      [JsonProperty("nodes")]
      public List<users> nodes { get; set; }
      #endregion
    }
    #endregion
    
    #region users_aggregate_fields
    /// <summary>
    /// aggregate fields of "users"
    /// </summary>
    public class users_aggregate_fields {
      #region members
      [JsonProperty("count")]
      public int? count { get; set; }
    
      [JsonProperty("max")]
      public users_max_fields max { get; set; }
    
      [JsonProperty("min")]
      public users_min_fields min { get; set; }
      #endregion
    }
    #endregion
    
    #region users_max_fields
    /// <summary>
    /// aggregate max on columns
    /// </summary>
    public class users_max_fields {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("rocket")]
      public string rocket { get; set; }
    
      [JsonProperty("timestamp")]
      public DateTime timestamp { get; set; }
    
      [JsonProperty("twitter")]
      public string twitter { get; set; }
      #endregion
    }
    #endregion
    
    #region users_min_fields
    /// <summary>
    /// aggregate min on columns
    /// </summary>
    public class users_min_fields {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("rocket")]
      public string rocket { get; set; }
    
      [JsonProperty("timestamp")]
      public DateTime timestamp { get; set; }
    
      [JsonProperty("twitter")]
      public string twitter { get; set; }
      #endregion
    }
    #endregion
    
    #region CapsulesFind
    public class CapsulesFind {
      #region members
      public string id { get; set; }
    
      public int? landings { get; set; }
    
      public string mission { get; set; }
    
      public DateTime original_launch { get; set; }
    
      public int? reuse_count { get; set; }
    
      public string status { get; set; }
    
      public string type { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Capsule
    public class Capsule {
      #region members
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("landings")]
      public int? landings { get; set; }
    
      [JsonProperty("missions")]
      public List<CapsuleMission> missions { get; set; }
    
      [JsonProperty("original_launch")]
      public DateTime original_launch { get; set; }
    
      [JsonProperty("reuse_count")]
      public int? reuse_count { get; set; }
    
      [JsonProperty("status")]
      public string status { get; set; }
    
      [JsonProperty("type")]
      public string type { get; set; }
    
      [JsonProperty("dragon")]
      public Dragon dragon { get; set; }
      #endregion
    }
    #endregion
    
    #region CapsuleMission
    public class CapsuleMission {
      #region members
      [JsonProperty("flight")]
      public int? flight { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
      #endregion
    }
    #endregion
    
    #region Dragon
    public class Dragon {
      #region members
      [JsonProperty("active")]
      public bool? active { get; set; }
    
      [JsonProperty("crew_capacity")]
      public int? crew_capacity { get; set; }
    
      [JsonProperty("description")]
      public string description { get; set; }
    
      [JsonProperty("diameter")]
      public Distance diameter { get; set; }
    
      [JsonProperty("dry_mass_kg")]
      public int? dry_mass_kg { get; set; }
    
      [JsonProperty("dry_mass_lb")]
      public int? dry_mass_lb { get; set; }
    
      [JsonProperty("first_flight")]
      public string first_flight { get; set; }
    
      [JsonProperty("heat_shield")]
      public DragonHeatShield heat_shield { get; set; }
    
      [JsonProperty("height_w_trunk")]
      public Distance height_w_trunk { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("launch_payload_mass")]
      public Mass launch_payload_mass { get; set; }
    
      [JsonProperty("launch_payload_vol")]
      public Volume launch_payload_vol { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("orbit_duration_yr")]
      public int? orbit_duration_yr { get; set; }
    
      [JsonProperty("pressurized_capsule")]
      public DragonPressurizedCapsule pressurized_capsule { get; set; }
    
      [JsonProperty("return_payload_mass")]
      public Mass return_payload_mass { get; set; }
    
      [JsonProperty("return_payload_vol")]
      public Volume return_payload_vol { get; set; }
    
      [JsonProperty("sidewall_angle_deg")]
      public float? sidewall_angle_deg { get; set; }
    
      [JsonProperty("thrusters")]
      public List<DragonThrust> thrusters { get; set; }
    
      [JsonProperty("trunk")]
      public DragonTrunk trunk { get; set; }
    
      [JsonProperty("type")]
      public string type { get; set; }
    
      [JsonProperty("wikipedia")]
      public string wikipedia { get; set; }
      #endregion
    }
    #endregion
    
    #region Distance
    public class Distance {
      #region members
      [JsonProperty("feet")]
      public float? feet { get; set; }
    
      [JsonProperty("meters")]
      public float? meters { get; set; }
      #endregion
    }
    #endregion
    
    #region DragonHeatShield
    public class DragonHeatShield {
      #region members
      [JsonProperty("dev_partner")]
      public string dev_partner { get; set; }
    
      [JsonProperty("material")]
      public string material { get; set; }
    
      [JsonProperty("size_meters")]
      public float? size_meters { get; set; }
    
      [JsonProperty("temp_degrees")]
      public int? temp_degrees { get; set; }
      #endregion
    }
    #endregion
    
    #region Mass
    public class Mass {
      #region members
      [JsonProperty("kg")]
      public int? kg { get; set; }
    
      [JsonProperty("lb")]
      public int? lb { get; set; }
      #endregion
    }
    #endregion
    
    #region Volume
    public class Volume {
      #region members
      [JsonProperty("cubic_feet")]
      public int? cubic_feet { get; set; }
    
      [JsonProperty("cubic_meters")]
      public int? cubic_meters { get; set; }
      #endregion
    }
    #endregion
    
    #region DragonPressurizedCapsule
    public class DragonPressurizedCapsule {
      #region members
      [JsonProperty("payload_volume")]
      public Volume payload_volume { get; set; }
      #endregion
    }
    #endregion
    
    #region DragonThrust
    public class DragonThrust {
      #region members
      [JsonProperty("amount")]
      public int? amount { get; set; }
    
      [JsonProperty("fuel_1")]
      public string fuel_1 { get; set; }
    
      [JsonProperty("fuel_2")]
      public string fuel_2 { get; set; }
    
      [JsonProperty("pods")]
      public int? pods { get; set; }
    
      [JsonProperty("thrust")]
      public Force thrust { get; set; }
    
      [JsonProperty("type")]
      public string type { get; set; }
      #endregion
    }
    #endregion
    
    #region Force
    public class Force {
      #region members
      [JsonProperty("kN")]
      public float? kN { get; set; }
    
      [JsonProperty("lbf")]
      public float? lbf { get; set; }
      #endregion
    }
    #endregion
    
    #region DragonTrunk
    public class DragonTrunk {
      #region members
      [JsonProperty("cargo")]
      public DragonTrunkCargo cargo { get; set; }
    
      [JsonProperty("trunk_volume")]
      public Volume trunk_volume { get; set; }
      #endregion
    }
    #endregion
    
    #region DragonTrunkCargo
    public class DragonTrunkCargo {
      #region members
      [JsonProperty("solar_array")]
      public int? solar_array { get; set; }
    
      [JsonProperty("unpressurized_cargo")]
      public bool? unpressurized_cargo { get; set; }
      #endregion
    }
    #endregion
    
    #region Info
    public class Info {
      #region members
      [JsonProperty("ceo")]
      public string ceo { get; set; }
    
      [JsonProperty("coo")]
      public string coo { get; set; }
    
      [JsonProperty("cto_propulsion")]
      public string cto_propulsion { get; set; }
    
      [JsonProperty("cto")]
      public string cto { get; set; }
    
      [JsonProperty("employees")]
      public int? employees { get; set; }
    
      [JsonProperty("founded")]
      public int? founded { get; set; }
    
      [JsonProperty("founder")]
      public string founder { get; set; }
    
      [JsonProperty("headquarters")]
      public Address headquarters { get; set; }
    
      [JsonProperty("launch_sites")]
      public int? launch_sites { get; set; }
    
      [JsonProperty("links")]
      public InfoLinks links { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("summary")]
      public string summary { get; set; }
    
      [JsonProperty("test_sites")]
      public int? test_sites { get; set; }
    
      [JsonProperty("valuation")]
      public float? valuation { get; set; }
    
      [JsonProperty("vehicles")]
      public int? vehicles { get; set; }
      #endregion
    }
    #endregion
    
    #region Address
    public class Address {
      #region members
      [JsonProperty("address")]
      public string address { get; set; }
    
      [JsonProperty("city")]
      public string city { get; set; }
    
      [JsonProperty("state")]
      public string state { get; set; }
      #endregion
    }
    #endregion
    
    #region InfoLinks
    public class InfoLinks {
      #region members
      [JsonProperty("elon_twitter")]
      public string elon_twitter { get; set; }
    
      [JsonProperty("flickr")]
      public string flickr { get; set; }
    
      [JsonProperty("twitter")]
      public string twitter { get; set; }
    
      [JsonProperty("website")]
      public string website { get; set; }
      #endregion
    }
    #endregion
    
    #region CoresFind
    public class CoresFind {
      #region members
      public int? asds_attempts { get; set; }
    
      public int? asds_landings { get; set; }
    
      public int? block { get; set; }
    
      public string id { get; set; }
    
      public string missions { get; set; }
    
      public DateTime original_launch { get; set; }
    
      public int? reuse_count { get; set; }
    
      public int? rtls_attempts { get; set; }
    
      public int? rtls_landings { get; set; }
    
      public string status { get; set; }
    
      public bool? water_landing { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Core
    public class Core {
      #region members
      [JsonProperty("asds_attempts")]
      public int? asds_attempts { get; set; }
    
      [JsonProperty("asds_landings")]
      public int? asds_landings { get; set; }
    
      [JsonProperty("block")]
      public int? block { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("missions")]
      public List<CapsuleMission> missions { get; set; }
    
      [JsonProperty("original_launch")]
      public DateTime original_launch { get; set; }
    
      [JsonProperty("reuse_count")]
      public int? reuse_count { get; set; }
    
      [JsonProperty("rtls_attempts")]
      public int? rtls_attempts { get; set; }
    
      [JsonProperty("rtls_landings")]
      public int? rtls_landings { get; set; }
    
      [JsonProperty("status")]
      public string status { get; set; }
    
      [JsonProperty("water_landing")]
      public bool? water_landing { get; set; }
      #endregion
    }
    #endregion
    
    #region HistoryFind
    public class HistoryFind {
      #region members
      public DateTime end { get; set; }
    
      public int? flight_number { get; set; }
    
      public string id { get; set; }
    
      public DateTime start { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region History
    public class History {
      #region members
      [JsonProperty("details")]
      public string details { get; set; }
    
      [JsonProperty("event_date_unix")]
      public DateTime event_date_unix { get; set; }
    
      [JsonProperty("event_date_utc")]
      public DateTime event_date_utc { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("links")]
      public Link links { get; set; }
    
      [JsonProperty("title")]
      public string title { get; set; }
    
      [JsonProperty("flight")]
      public Launch flight { get; set; }
      #endregion
    }
    #endregion
    
    #region Link
    public class Link {
      #region members
      [JsonProperty("article")]
      public string article { get; set; }
    
      [JsonProperty("reddit")]
      public string reddit { get; set; }
    
      [JsonProperty("wikipedia")]
      public string wikipedia { get; set; }
      #endregion
    }
    #endregion
    
    #region Launch
    public class Launch {
      #region members
      [JsonProperty("details")]
      public string details { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("is_tentative")]
      public bool? is_tentative { get; set; }
    
      [JsonProperty("launch_date_local")]
      public DateTime launch_date_local { get; set; }
    
      [JsonProperty("launch_date_unix")]
      public DateTime launch_date_unix { get; set; }
    
      [JsonProperty("launch_date_utc")]
      public DateTime launch_date_utc { get; set; }
    
      [JsonProperty("launch_site")]
      public LaunchSite launch_site { get; set; }
    
      [JsonProperty("launch_success")]
      public bool? launch_success { get; set; }
    
      [JsonProperty("launch_year")]
      public string launch_year { get; set; }
    
      [JsonProperty("links")]
      public LaunchLinks links { get; set; }
    
      [JsonProperty("mission_id")]
      public List<string> mission_id { get; set; }
    
      [JsonProperty("mission_name")]
      public string mission_name { get; set; }
    
      [JsonProperty("rocket")]
      public LaunchRocket rocket { get; set; }
    
      [JsonProperty("static_fire_date_unix")]
      public DateTime static_fire_date_unix { get; set; }
    
      [JsonProperty("static_fire_date_utc")]
      public DateTime static_fire_date_utc { get; set; }
    
      [JsonProperty("telemetry")]
      public LaunchTelemetry telemetry { get; set; }
    
      [JsonProperty("tentative_max_precision")]
      public string tentative_max_precision { get; set; }
    
      [JsonProperty("upcoming")]
      public bool? upcoming { get; set; }
    
      [JsonProperty("ships")]
      public List<Ship> ships { get; set; }
      #endregion
    }
    #endregion
    
    #region LaunchSite
    public class LaunchSite {
      #region members
      [JsonProperty("site_id")]
      public string site_id { get; set; }
    
      [JsonProperty("site_name_long")]
      public string site_name_long { get; set; }
    
      [JsonProperty("site_name")]
      public string site_name { get; set; }
      #endregion
    }
    #endregion
    
    #region LaunchLinks
    public class LaunchLinks {
      #region members
      [JsonProperty("article_link")]
      public string article_link { get; set; }
    
      [JsonProperty("flickr_images")]
      public List<string> flickr_images { get; set; }
    
      [JsonProperty("mission_patch_small")]
      public string mission_patch_small { get; set; }
    
      [JsonProperty("mission_patch")]
      public string mission_patch { get; set; }
    
      [JsonProperty("presskit")]
      public string presskit { get; set; }
    
      [JsonProperty("reddit_campaign")]
      public string reddit_campaign { get; set; }
    
      [JsonProperty("reddit_launch")]
      public string reddit_launch { get; set; }
    
      [JsonProperty("reddit_media")]
      public string reddit_media { get; set; }
    
      [JsonProperty("reddit_recovery")]
      public string reddit_recovery { get; set; }
    
      [JsonProperty("video_link")]
      public string video_link { get; set; }
    
      [JsonProperty("wikipedia")]
      public string wikipedia { get; set; }
      #endregion
    }
    #endregion
    
    #region LaunchRocket
    public class LaunchRocket {
      #region members
      [JsonProperty("fairings")]
      public LaunchRocketFairings fairings { get; set; }
    
      [JsonProperty("first_stage")]
      public LaunchRocketFirstStage first_stage { get; set; }
    
      [JsonProperty("rocket_name")]
      public string rocket_name { get; set; }
    
      [JsonProperty("rocket_type")]
      public string rocket_type { get; set; }
    
      [JsonProperty("rocket")]
      public Rocket rocket { get; set; }
    
      [JsonProperty("second_stage")]
      public LaunchRocketSecondStage second_stage { get; set; }
      #endregion
    }
    #endregion
    
    #region LaunchRocketFairings
    public class LaunchRocketFairings {
      #region members
      [JsonProperty("recovered")]
      public bool? recovered { get; set; }
    
      [JsonProperty("recovery_attempt")]
      public bool? recovery_attempt { get; set; }
    
      [JsonProperty("reused")]
      public bool? reused { get; set; }
    
      [JsonProperty("ship")]
      public string ship { get; set; }
      #endregion
    }
    #endregion
    
    #region LaunchRocketFirstStage
    public class LaunchRocketFirstStage {
      #region members
      [JsonProperty("cores")]
      public List<LaunchRocketFirstStageCore> cores { get; set; }
      #endregion
    }
    #endregion
    
    #region LaunchRocketFirstStageCore
    public class LaunchRocketFirstStageCore {
      #region members
      [JsonProperty("block")]
      public int? block { get; set; }
    
      [JsonProperty("core")]
      public Core core { get; set; }
    
      [JsonProperty("flight")]
      public int? flight { get; set; }
    
      [JsonProperty("gridfins")]
      public bool? gridfins { get; set; }
    
      [JsonProperty("land_success")]
      public bool? land_success { get; set; }
    
      [JsonProperty("landing_intent")]
      public bool? landing_intent { get; set; }
    
      [JsonProperty("landing_type")]
      public string landing_type { get; set; }
    
      [JsonProperty("landing_vehicle")]
      public string landing_vehicle { get; set; }
    
      [JsonProperty("legs")]
      public bool? legs { get; set; }
    
      [JsonProperty("reused")]
      public bool? reused { get; set; }
      #endregion
    }
    #endregion
    
    #region Rocket
    public class Rocket {
      #region members
      [JsonProperty("active")]
      public bool? active { get; set; }
    
      [JsonProperty("boosters")]
      public int? boosters { get; set; }
    
      [JsonProperty("company")]
      public string company { get; set; }
    
      [JsonProperty("cost_per_launch")]
      public int? cost_per_launch { get; set; }
    
      [JsonProperty("country")]
      public string country { get; set; }
    
      [JsonProperty("description")]
      public string description { get; set; }
    
      [JsonProperty("diameter")]
      public Distance diameter { get; set; }
    
      [JsonProperty("engines")]
      public RocketEngines engines { get; set; }
    
      [JsonProperty("first_flight")]
      public DateTime first_flight { get; set; }
    
      [JsonProperty("first_stage")]
      public RocketFirstStage first_stage { get; set; }
    
      [JsonProperty("height")]
      public Distance height { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("landing_legs")]
      public RocketLandingLegs landing_legs { get; set; }
    
      [JsonProperty("mass")]
      public Mass mass { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("payload_weights")]
      public List<RocketPayloadWeight> payload_weights { get; set; }
    
      [JsonProperty("second_stage")]
      public RocketSecondStage second_stage { get; set; }
    
      [JsonProperty("stages")]
      public int? stages { get; set; }
    
      [JsonProperty("success_rate_pct")]
      public int? success_rate_pct { get; set; }
    
      [JsonProperty("type")]
      public string type { get; set; }
    
      [JsonProperty("wikipedia")]
      public string wikipedia { get; set; }
      #endregion
    }
    #endregion
    
    #region RocketEngines
    public class RocketEngines {
      #region members
      [JsonProperty("number")]
      public int? number { get; set; }
    
      [JsonProperty("type")]
      public string type { get; set; }
    
      [JsonProperty("version")]
      public string version { get; set; }
    
      [JsonProperty("layout")]
      public string layout { get; set; }
    
      [JsonProperty("engine_loss_max")]
      public string engine_loss_max { get; set; }
    
      [JsonProperty("propellant_1")]
      public string propellant_1 { get; set; }
    
      [JsonProperty("propellant_2")]
      public string propellant_2 { get; set; }
    
      [JsonProperty("thrust_sea_level")]
      public Force thrust_sea_level { get; set; }
    
      [JsonProperty("thrust_vacuum")]
      public Force thrust_vacuum { get; set; }
    
      [JsonProperty("thrust_to_weight")]
      public float? thrust_to_weight { get; set; }
      #endregion
    }
    #endregion
    
    #region RocketFirstStage
    public class RocketFirstStage {
      #region members
      [JsonProperty("burn_time_sec")]
      public int? burn_time_sec { get; set; }
    
      [JsonProperty("engines")]
      public int? engines { get; set; }
    
      [JsonProperty("fuel_amount_tons")]
      public float? fuel_amount_tons { get; set; }
    
      [JsonProperty("reusable")]
      public bool? reusable { get; set; }
    
      [JsonProperty("thrust_sea_level")]
      public Force thrust_sea_level { get; set; }
    
      [JsonProperty("thrust_vacuum")]
      public Force thrust_vacuum { get; set; }
      #endregion
    }
    #endregion
    
    #region RocketLandingLegs
    public class RocketLandingLegs {
      #region members
      [JsonProperty("number")]
      public int? number { get; set; }
    
      [JsonProperty("material")]
      public string material { get; set; }
      #endregion
    }
    #endregion
    
    #region RocketPayloadWeight
    public class RocketPayloadWeight {
      #region members
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("kg")]
      public int? kg { get; set; }
    
      [JsonProperty("lb")]
      public int? lb { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
      #endregion
    }
    #endregion
    
    #region RocketSecondStage
    public class RocketSecondStage {
      #region members
      [JsonProperty("burn_time_sec")]
      public int? burn_time_sec { get; set; }
    
      [JsonProperty("engines")]
      public int? engines { get; set; }
    
      [JsonProperty("fuel_amount_tons")]
      public float? fuel_amount_tons { get; set; }
    
      [JsonProperty("payloads")]
      public RocketSecondStagePayloads payloads { get; set; }
    
      [JsonProperty("thrust")]
      public Force thrust { get; set; }
      #endregion
    }
    #endregion
    
    #region RocketSecondStagePayloads
    public class RocketSecondStagePayloads {
      #region members
      [JsonProperty("option_1")]
      public string option_1 { get; set; }
    
      [JsonProperty("composite_fairing")]
      public RocketSecondStagePayloadCompositeFairing composite_fairing { get; set; }
      #endregion
    }
    #endregion
    
    #region RocketSecondStagePayloadCompositeFairing
    public class RocketSecondStagePayloadCompositeFairing {
      #region members
      [JsonProperty("height")]
      public Distance height { get; set; }
    
      [JsonProperty("diameter")]
      public Distance diameter { get; set; }
      #endregion
    }
    #endregion
    
    #region LaunchRocketSecondStage
    public class LaunchRocketSecondStage {
      #region members
      [JsonProperty("block")]
      public int? block { get; set; }
    
      [JsonProperty("payloads")]
      public List<Payload> payloads { get; set; }
      #endregion
    }
    #endregion
    
    #region Payload
    public class Payload {
      #region members
      [JsonProperty("customers")]
      public List<string> customers { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("manufacturer")]
      public string manufacturer { get; set; }
    
      [JsonProperty("nationality")]
      public string nationality { get; set; }
    
      [JsonProperty("norad_id")]
      public List<int?> norad_id { get; set; }
    
      [JsonProperty("orbit_params")]
      public PayloadOrbitParams orbit_params { get; set; }
    
      [JsonProperty("orbit")]
      public string orbit { get; set; }
    
      [JsonProperty("payload_mass_kg")]
      public float? payload_mass_kg { get; set; }
    
      [JsonProperty("payload_mass_lbs")]
      public float? payload_mass_lbs { get; set; }
    
      [JsonProperty("payload_type")]
      public string payload_type { get; set; }
    
      [JsonProperty("reused")]
      public bool? reused { get; set; }
      #endregion
    }
    #endregion
    
    #region PayloadOrbitParams
    public class PayloadOrbitParams {
      #region members
      [JsonProperty("apoapsis_km")]
      public float? apoapsis_km { get; set; }
    
      [JsonProperty("arg_of_pericenter")]
      public float? arg_of_pericenter { get; set; }
    
      [JsonProperty("eccentricity")]
      public float? eccentricity { get; set; }
    
      [JsonProperty("epoch")]
      public DateTime epoch { get; set; }
    
      [JsonProperty("inclination_deg")]
      public float? inclination_deg { get; set; }
    
      [JsonProperty("lifespan_years")]
      public float? lifespan_years { get; set; }
    
      [JsonProperty("longitude")]
      public float? longitude { get; set; }
    
      [JsonProperty("mean_anomaly")]
      public float? mean_anomaly { get; set; }
    
      [JsonProperty("mean_motion")]
      public float? mean_motion { get; set; }
    
      [JsonProperty("periapsis_km")]
      public float? periapsis_km { get; set; }
    
      [JsonProperty("period_min")]
      public float? period_min { get; set; }
    
      [JsonProperty("raan")]
      public float? raan { get; set; }
    
      [JsonProperty("reference_system")]
      public string reference_system { get; set; }
    
      [JsonProperty("regime")]
      public string regime { get; set; }
    
      [JsonProperty("semi_major_axis_km")]
      public float? semi_major_axis_km { get; set; }
      #endregion
    }
    #endregion
    
    #region LaunchTelemetry
    public class LaunchTelemetry {
      #region members
      [JsonProperty("flight_club")]
      public string flight_club { get; set; }
      #endregion
    }
    #endregion
    
    #region Ship
    public class Ship {
      #region members
      [JsonProperty("abs")]
      public int? abs { get; set; }
    
      [JsonProperty("active")]
      public bool? active { get; set; }
    
      [JsonProperty("attempted_landings")]
      public int? attempted_landings { get; set; }
    
      [JsonProperty("class")]
      public int? @class { get; set; }
    
      [JsonProperty("course_deg")]
      public int? course_deg { get; set; }
    
      [JsonProperty("home_port")]
      public string home_port { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("image")]
      public string image { get; set; }
    
      [JsonProperty("imo")]
      public int? imo { get; set; }
    
      [JsonProperty("missions")]
      public List<ShipMission> missions { get; set; }
    
      [JsonProperty("mmsi")]
      public int? mmsi { get; set; }
    
      [JsonProperty("model")]
      public string model { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("position")]
      public ShipLocation position { get; set; }
    
      [JsonProperty("roles")]
      public List<string> roles { get; set; }
    
      [JsonProperty("speed_kn")]
      public float? speed_kn { get; set; }
    
      [JsonProperty("status")]
      public string status { get; set; }
    
      [JsonProperty("successful_landings")]
      public int? successful_landings { get; set; }
    
      [JsonProperty("type")]
      public string type { get; set; }
    
      [JsonProperty("url")]
      public string url { get; set; }
    
      [JsonProperty("weight_kg")]
      public int? weight_kg { get; set; }
    
      [JsonProperty("weight_lbs")]
      public int? weight_lbs { get; set; }
    
      [JsonProperty("year_built")]
      public int? year_built { get; set; }
      #endregion
    }
    #endregion
    
    #region ShipMission
    public class ShipMission {
      #region members
      [JsonProperty("flight")]
      public string flight { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
      #endregion
    }
    #endregion
    
    #region ShipLocation
    public class ShipLocation {
      #region members
      [JsonProperty("latitude")]
      public float? latitude { get; set; }
    
      [JsonProperty("longitude")]
      public float? longitude { get; set; }
      #endregion
    }
    #endregion
    
    #region HistoriesResult
    public class HistoriesResult {
      #region members
      [JsonProperty("result")]
      public Result result { get; set; }
    
      [JsonProperty("data")]
      public List<History> data { get; set; }
      #endregion
    }
    #endregion
    
    #region Result
    public class Result {
      #region members
      [JsonProperty("totalCount")]
      public int? totalCount { get; set; }
      #endregion
    }
    #endregion
    
    #region Landpad
    public class Landpad {
      #region members
      [JsonProperty("attempted_landings")]
      public string attempted_landings { get; set; }
    
      [JsonProperty("details")]
      public string details { get; set; }
    
      [JsonProperty("full_name")]
      public string full_name { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("landing_type")]
      public string landing_type { get; set; }
    
      [JsonProperty("location")]
      public Location location { get; set; }
    
      [JsonProperty("status")]
      public string status { get; set; }
    
      [JsonProperty("successful_landings")]
      public string successful_landings { get; set; }
    
      [JsonProperty("wikipedia")]
      public string wikipedia { get; set; }
      #endregion
    }
    #endregion
    
    #region Location
    public class Location {
      #region members
      [JsonProperty("latitude")]
      public float? latitude { get; set; }
    
      [JsonProperty("longitude")]
      public float? longitude { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("region")]
      public string region { get; set; }
      #endregion
    }
    #endregion
    
    #region LaunchFind
    public class LaunchFind {
      #region members
      public float? apoapsis_km { get; set; }
    
      public int? block { get; set; }
    
      public string cap_serial { get; set; }
    
      public string capsule_reuse { get; set; }
    
      public int? core_flight { get; set; }
    
      public string core_reuse { get; set; }
    
      public string core_serial { get; set; }
    
      public string customer { get; set; }
    
      public float? eccentricity { get; set; }
    
      public DateTime end { get; set; }
    
      public DateTime epoch { get; set; }
    
      public string fairings_recovered { get; set; }
    
      public string fairings_recovery_attempt { get; set; }
    
      public string fairings_reuse { get; set; }
    
      public string fairings_reused { get; set; }
    
      public string fairings_ship { get; set; }
    
      public string gridfins { get; set; }
    
      public string id { get; set; }
    
      public float? inclination_deg { get; set; }
    
      public string land_success { get; set; }
    
      public string landing_intent { get; set; }
    
      public string landing_type { get; set; }
    
      public string landing_vehicle { get; set; }
    
      public DateTime launch_date_local { get; set; }
    
      public DateTime launch_date_utc { get; set; }
    
      public string launch_success { get; set; }
    
      public string launch_year { get; set; }
    
      public string legs { get; set; }
    
      public float? lifespan_years { get; set; }
    
      public float? longitude { get; set; }
    
      public string manufacturer { get; set; }
    
      public float? mean_motion { get; set; }
    
      public string mission_id { get; set; }
    
      public string mission_name { get; set; }
    
      public string nationality { get; set; }
    
      public int? norad_id { get; set; }
    
      public string orbit { get; set; }
    
      public string payload_id { get; set; }
    
      public string payload_type { get; set; }
    
      public float? periapsis_km { get; set; }
    
      public float? period_min { get; set; }
    
      public float? raan { get; set; }
    
      public string reference_system { get; set; }
    
      public string regime { get; set; }
    
      public string reused { get; set; }
    
      public string rocket_id { get; set; }
    
      public string rocket_name { get; set; }
    
      public string rocket_type { get; set; }
    
      public string second_stage_block { get; set; }
    
      public float? semi_major_axis_km { get; set; }
    
      public string ship { get; set; }
    
      public string side_core1_reuse { get; set; }
    
      public string side_core2_reuse { get; set; }
    
      public string site_id { get; set; }
    
      public string site_name_long { get; set; }
    
      public string site_name { get; set; }
    
      public DateTime start { get; set; }
    
      public string tbd { get; set; }
    
      public string tentative_max_precision { get; set; }
    
      public string tentative { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region LaunchesPastResult
    public class LaunchesPastResult {
      #region members
      [JsonProperty("result")]
      public Result result { get; set; }
    
      [JsonProperty("data")]
      public List<Launch> data { get; set; }
      #endregion
    }
    #endregion
    
    #region Launchpad
    public class Launchpad {
      #region members
      [JsonProperty("attempted_launches")]
      public int? attempted_launches { get; set; }
    
      [JsonProperty("details")]
      public string details { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("location")]
      public Location location { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("status")]
      public string status { get; set; }
    
      [JsonProperty("successful_launches")]
      public int? successful_launches { get; set; }
    
      [JsonProperty("vehicles_launched")]
      public List<Rocket> vehicles_launched { get; set; }
    
      [JsonProperty("wikipedia")]
      public string wikipedia { get; set; }
      #endregion
    }
    #endregion
    
    #region MissionsFind
    public class MissionsFind {
      #region members
      public string id { get; set; }
    
      public string manufacturer { get; set; }
    
      public string name { get; set; }
    
      public string payload_id { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Mission
    public class Mission {
      #region members
      [JsonProperty("description")]
      public string description { get; set; }
    
      [JsonProperty("id")]
      public string id { get; set; }
    
      [JsonProperty("manufacturers")]
      public List<string> manufacturers { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("twitter")]
      public string twitter { get; set; }
    
      [JsonProperty("website")]
      public string website { get; set; }
    
      [JsonProperty("wikipedia")]
      public string wikipedia { get; set; }
    
      [JsonProperty("payloads")]
      public List<Payload> payloads { get; set; }
      #endregion
    }
    #endregion
    
    #region MissionResult
    public class MissionResult {
      #region members
      [JsonProperty("result")]
      public Result result { get; set; }
    
      [JsonProperty("data")]
      public List<Mission> data { get; set; }
      #endregion
    }
    #endregion
    
    #region PayloadsFind
    public class PayloadsFind {
      #region members
      public float? apoapsis_km { get; set; }
    
      public string customer { get; set; }
    
      public float? eccentricity { get; set; }
    
      public DateTime epoch { get; set; }
    
      public float? inclination_deg { get; set; }
    
      public float? lifespan_years { get; set; }
    
      public float? longitude { get; set; }
    
      public string manufacturer { get; set; }
    
      public float? mean_motion { get; set; }
    
      public string nationality { get; set; }
    
      public int? norad_id { get; set; }
    
      public string orbit { get; set; }
    
      public string payload_id { get; set; }
    
      public string payload_type { get; set; }
    
      public float? periapsis_km { get; set; }
    
      public float? period_min { get; set; }
    
      public float? raan { get; set; }
    
      public string reference_system { get; set; }
    
      public string regime { get; set; }
    
      public bool? reused { get; set; }
    
      public float? semi_major_axis_km { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Roadster
    public class Roadster {
      #region members
      [JsonProperty("apoapsis_au")]
      public float? apoapsis_au { get; set; }
    
      [JsonProperty("details")]
      public string details { get; set; }
    
      [JsonProperty("earth_distance_km")]
      public float? earth_distance_km { get; set; }
    
      [JsonProperty("earth_distance_mi")]
      public float? earth_distance_mi { get; set; }
    
      [JsonProperty("eccentricity")]
      public float? eccentricity { get; set; }
    
      [JsonProperty("epoch_jd")]
      public float? epoch_jd { get; set; }
    
      [JsonProperty("inclination")]
      public float? inclination { get; set; }
    
      [JsonProperty("launch_date_unix")]
      public DateTime launch_date_unix { get; set; }
    
      [JsonProperty("launch_date_utc")]
      public DateTime launch_date_utc { get; set; }
    
      [JsonProperty("launch_mass_kg")]
      public int? launch_mass_kg { get; set; }
    
      [JsonProperty("launch_mass_lbs")]
      public int? launch_mass_lbs { get; set; }
    
      [JsonProperty("longitude")]
      public float? longitude { get; set; }
    
      [JsonProperty("mars_distance_km")]
      public float? mars_distance_km { get; set; }
    
      [JsonProperty("mars_distance_mi")]
      public float? mars_distance_mi { get; set; }
    
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("norad_id")]
      public int? norad_id { get; set; }
    
      [JsonProperty("orbit_type")]
      public float? orbit_type { get; set; }
    
      [JsonProperty("periapsis_arg")]
      public float? periapsis_arg { get; set; }
    
      [JsonProperty("periapsis_au")]
      public float? periapsis_au { get; set; }
    
      [JsonProperty("period_days")]
      public float? period_days { get; set; }
    
      [JsonProperty("semi_major_axis_au")]
      public float? semi_major_axis_au { get; set; }
    
      [JsonProperty("speed_kph")]
      public float? speed_kph { get; set; }
    
      [JsonProperty("speed_mph")]
      public float? speed_mph { get; set; }
    
      [JsonProperty("wikipedia")]
      public string wikipedia { get; set; }
      #endregion
    }
    #endregion
    
    #region RocketsResult
    public class RocketsResult {
      #region members
      [JsonProperty("result")]
      public Result result { get; set; }
    
      [JsonProperty("data")]
      public List<Rocket> data { get; set; }
      #endregion
    }
    #endregion
    
    #region ShipsFind
    public class ShipsFind {
      #region members
      public string id { get; set; }
    
      public string name { get; set; }
    
      public string model { get; set; }
    
      public string type { get; set; }
    
      public string role { get; set; }
    
      public bool? active { get; set; }
    
      public int? imo { get; set; }
    
      public int? mmsi { get; set; }
    
      public int? abs { get; set; }
    
      public int? @class { get; set; }
    
      public int? weight_lbs { get; set; }
    
      public int? weight_kg { get; set; }
    
      public int? year_built { get; set; }
    
      public string home_port { get; set; }
    
      public string status { get; set; }
    
      public int? speed_kn { get; set; }
    
      public int? course_deg { get; set; }
    
      public float? latitude { get; set; }
    
      public float? longitude { get; set; }
    
      public int? successful_landings { get; set; }
    
      public int? attempted_landings { get; set; }
    
      public string mission { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region ShipsResult
    public class ShipsResult {
      #region members
      [JsonProperty("result")]
      public Result result { get; set; }
    
      [JsonProperty("data")]
      public List<Ship> data { get; set; }
      #endregion
    }
    #endregion
    
    #region Mutation
    public class Mutation {
      #region members
      /// <summary>
      /// delete data from the table: "users"
      /// </summary>
      [JsonProperty("delete_users")]
      public users_mutation_response delete_users { get; set; }
    
      /// <summary>
      /// insert data into the table: "users"
      /// </summary>
      [JsonProperty("insert_users")]
      public users_mutation_response insert_users { get; set; }
    
      /// <summary>
      /// update data of the table: "users"
      /// </summary>
      [JsonProperty("update_users")]
      public users_mutation_response update_users { get; set; }
      #endregion
    }
    #endregion
    
    #region users_mutation_response
    /// <summary>
    /// response of any mutation on the table "users"
    /// </summary>
    public class users_mutation_response {
      #region members
      /// <summary>
      /// number of affected rows by the mutation
      /// </summary>
      [JsonProperty("affected_rows")]
      public int affected_rows { get; set; }
    
      /// <summary>
      /// data of the affected rows by the mutation
      /// </summary>
      [JsonProperty("returning")]
      public List<users> returning { get; set; }
      #endregion
    }
    #endregion
    
    #region Users_Insert_Input
    /// <summary>
    /// input type for inserting data into table "users"
    /// </summary>
    public class Users_Insert_Input {
      #region members
      public Guid id { get; set; }
    
      public string name { get; set; }
    
      public string rocket { get; set; }
    
      public DateTime timestamp { get; set; }
    
      public string twitter { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Users_On_Conflict
    /// <summary>
    /// on conflict condition type for table "users"
    /// </summary>
    public class Users_On_Conflict {
      #region members
      [JsonRequired]
      public Users_Constraint constraint { get; set; }
    
      [JsonRequired]
      public List<Users_Update_Column> update_columns { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
      /// <summary>
      /// unique or primary key constraints on table "users"
      /// </summary>
    public enum Users_Constraint {
      /// <summary>
      /// unique or primary key constraint
      /// </summary>
      users_pkey
    }
    
      /// <summary>
      /// update columns of table "users"
      /// </summary>
    public enum Users_Update_Column {
      /// <summary>
      /// column name
      /// </summary>
      id,
      /// <summary>
      /// column name
      /// </summary>
      name,
      /// <summary>
      /// column name
      /// </summary>
      rocket,
      /// <summary>
      /// column name
      /// </summary>
      timestamp,
      /// <summary>
      /// column name
      /// </summary>
      twitter
    }
    
    
    #region Users_Set_Input
    /// <summary>
    /// input type for updating data in table "users"
    /// </summary>
    public class Users_Set_Input {
      #region members
      public Guid id { get; set; }
    
      public string name { get; set; }
    
      public string rocket { get; set; }
    
      public DateTime timestamp { get; set; }
    
      public string twitter { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Subscription
    public class Subscription {
      #region members
      /// <summary>
      /// fetch data from the table: "users"
      /// </summary>
      [JsonProperty("users")]
      public List<users> users { get; set; }
    
      /// <summary>
      /// fetch aggregated fields from the table: "users"
      /// </summary>
      [JsonProperty("users_aggregate")]
      public users_aggregate users_aggregate { get; set; }
    
      /// <summary>
      /// fetch data from the table: "users" using primary key columns
      /// </summary>
      [JsonProperty("users_by_pk")]
      public users users_by_pk { get; set; }
      #endregion
    }
    #endregion
      /// <summary>
      /// conflict action
      /// </summary>
    public enum Conflict_Action {
      /// <summary>
      /// ignore the insert on this row
      /// </summary>
      ignore,
      /// <summary>
      /// update the row with the given values
      /// </summary>
      update
    }
    
    
    #region Users_Aggregate_Order_By
    /// <summary>
    /// order by aggregate values of table "users"
    /// </summary>
    public class Users_Aggregate_Order_By {
      #region members
      public Order_By? count { get; set; }
    
      public Users_Max_Order_By max { get; set; }
    
      public Users_Min_Order_By min { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Users_Max_Order_By
    /// <summary>
    /// order by max() on columns of table "users"
    /// </summary>
    public class Users_Max_Order_By {
      #region members
      public Order_By? name { get; set; }
    
      public Order_By? rocket { get; set; }
    
      public Order_By? timestamp { get; set; }
    
      public Order_By? twitter { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Users_Min_Order_By
    /// <summary>
    /// order by min() on columns of table "users"
    /// </summary>
    public class Users_Min_Order_By {
      #region members
      public Order_By? name { get; set; }
    
      public Order_By? rocket { get; set; }
    
      public Order_By? timestamp { get; set; }
    
      public Order_By? twitter { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Users_Arr_Rel_Insert_Input
    /// <summary>
    /// input type for inserting array relation for remote table "users"
    /// </summary>
    public class Users_Arr_Rel_Insert_Input {
      #region members
      [JsonRequired]
      public List<Users_Insert_Input> data { get; set; }
    
      public Users_On_Conflict on_conflict { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region Users_Obj_Rel_Insert_Input
    /// <summary>
    /// input type for inserting object relation for remote table "users"
    /// </summary>
    public class Users_Obj_Rel_Insert_Input {
      #region members
      [JsonRequired]
      public Users_Insert_Input data { get; set; }
    
      public Users_On_Conflict on_conflict { get; set; }
      #endregion
    
      #region methods
      public dynamic GetInputObject()
      {
        IDictionary<string, object> d = new System.Dynamic.ExpandoObject();
    
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var propertyInfo in properties)
        {
          var value = propertyInfo.GetValue(this);
          var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
    
          var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
          if (requiredProp || value != defaultValue)
          {
            d[propertyInfo.Name] = value;
          }
        }
        return d;
      }
      #endregion
    }
    #endregion
    
    #region CoreMission
    public class CoreMission {
      #region members
      [JsonProperty("name")]
      public string name { get; set; }
    
      [JsonProperty("flight")]
      public int? flight { get; set; }
      #endregion
    }
    #endregion
  }
  
}
