namespace Telemetry {
    // Clase base para la persistencia
    public abstract class Persistence {
        protected ISerializer serializer;

        // Receive el tipo de serializacion
        protected Persistence(ISerializer serializer_) {
            serializer = serializer_;
        }

        // Persiste el evento enviado 
        // El metodo debe ser redefinido en cada clase hija
        public abstract void Save(TelemetryEvent t_event);
    }
}