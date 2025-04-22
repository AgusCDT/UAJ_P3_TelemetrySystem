using System.Threading;

namespace Telemetry
{
    /// <summary>
    /// Prueba
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Telemetry.Init("./telemetry_data/", "TelemetrySystem", 1);

            Telemetry.Instance.TrackEvent(new LevelEndEvent(Event.ID_Event.LEVEL_END, 1));
            Thread.Sleep(1500 * 2);
            Telemetry.Instance.TrackEvent(new LevelEndEvent(Event.ID_Event.DEATH, 1));

            Telemetry.Release();
        }
    }
}
