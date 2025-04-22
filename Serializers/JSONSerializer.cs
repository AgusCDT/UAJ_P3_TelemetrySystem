using Newtonsoft.Json;
using System.Xml;

namespace Telemetry {
    // Serializar en JSON
    public class JsonSerializer : Serializer {
        public string Serialize(Event t_event){
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.Formatting = Formatting.Indented;
            return JsonConvert.SerializeObject(t_event, jsonSerializerSettings);
        }

        public string Extension() {
            return ".json";
        }
    }
}