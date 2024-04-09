using ReservationSystem;

public class FileLogger : ILogger
{
    public void LogRecord(LogRecord log)
    {
         Console.WriteLine("file logger");
        throw new NotImplementedException();
       
    }
}