
namespace iHgMc.Utils.Model
{
    public class LogMessage
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public LogType Type { get; set; }
    }

    public enum LogType
    {
        Error,
        Info
    }
}
