using UnityEngine;

namespace Telemetry {
    public static class TelemetryLogger {
        public static void LogEvent(string eventName) {
            Debug.Log($"[Telemetry] Evento registrado: {eventName}");
        }
    }
}
