namespace Telemetry { 
    public interface Serializer {
        // Serializa un evento al formato correspondiente
        public string Serialize(Event t_event);
        // Extension del archivo en funcion del tipo de serializacion
        public string Extension();
    }
}