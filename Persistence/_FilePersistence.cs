using System.IO;

namespace Telemetry {
    // Persistencia de los eventos en un archivo
    class FilePersistence : Persistence {
        string fileName;

        // Guarda una ruta para crear en la carpeta de telemetria (GameName_SessionID.[json/csv/bin])
        public FilePersistence(ISerializer serializer_) : base(serializer_) {
            if (!Directory.Exists(Telemetry.Instance.Directory))
                Directory.CreateDirectory(Telemetry.Instance.Directory);
            fileName = Telemetry.Instance.Directory + Telemetry.Instance.GameName + "_" + Telemetry.Instance.SessionID.ToString() + serializer.Extension();
        }

        // Escribe el evento en la ruta guardada
        public override void Save(TelemetryEvent t_event) {
            using (StreamWriter streamWriter = new StreamWriter(fileName, true)) {
                string serialisedEvent = serializer.Serialize(t_event);
                streamWriter.WriteLine(serialisedEvent);
            }
        }
    }
}