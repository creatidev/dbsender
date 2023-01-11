using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using DBSender.Properties;

namespace DBSender.Classes
{
    [JsonObject("Settings")]
    public partial class Settings
    {
        [JsonProperty("File")]
        public DataFile DataFile { get; set; }

        [JsonProperty("EmailSettings")]
        public Email EmailSettings { get; set; }

        [JsonProperty("Contacts")]
        public Contacts Contacts { get; set; }

        [JsonProperty("EnableLog")]
        public bool EnableLog { get; set; }
    }

    [JsonObject("Contacts")]
    public class Contacts
    {
        [JsonProperty("Address")]
        public List<Address> Address { get; set; }

        [JsonProperty("Categories")]
        public List<string> Categories { get; set; }
    }

    [JsonObject("Address")]
    public class Address
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Category")]
        public int Category { get; set; }

        [JsonProperty("Clients")]
        public List<Client> Clients { get; set; }

        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    [JsonObject("Client")]
    public class Client
    {
        public string Name { get; set; }
        public List<string> Projects { get; set; }
    }

    [JsonObject("Email")]
    public class Email
    {
        [JsonProperty("Template")]
        public Template Template { get; set; }

        [JsonProperty("Server")]
        public Server Server { get; set; }
    }

    [JsonObject("Server")]
    public class Server
    {
        [JsonProperty("SMPTServer")]
        public string SmptServer { get; set; }

        [JsonProperty("SMPTPort")]
        public int SmptPort { get; set; }

        [JsonProperty("User")]
        public string User { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("TLS")]
        public bool TLS { get; set; }
    }

    [JsonObject("Template")]
    public class Template
    {
        [JsonProperty("Html")]
        public bool Html { get; set; }

        [JsonProperty("Subject")]
        public string Subject { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }
    }

    [JsonObject("DataFile")]
    public class DataFile
    {
        [JsonProperty("Autoload")]
        public bool Autoload { get; set; }

        [JsonProperty("Path")]
        public string Path { get; set; }
    }

    public partial class Settings
    {
        public static Settings FromJson(string json) => JsonConvert.DeserializeObject<Settings>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Settings self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    public static class JsonFile
    {
        public static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + Assembly.GetExecutingAssembly().GetName().Name;
        public static readonly string SettingsFile = AppDataPath + @"\Settings.json";
        public static Settings Settings = LoadSettings();

        public static void Save(string settings)
        {
            File.WriteAllText(SettingsFile, settings);
        }

        /// <summary>
        /// Json file location, if file does not exist, write it in the Appdata folder 
        /// </summary>
        /// <returns></returns>
        public static Settings LoadSettings()
        {
            if (!File.Exists(SettingsFile)) File.WriteAllBytes(SettingsFile, Resources.Settings);
            return Settings.FromJson(File.ReadAllText(SettingsFile));
        }
    }
}