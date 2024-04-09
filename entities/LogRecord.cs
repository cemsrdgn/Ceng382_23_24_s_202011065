using System;


namespace ReservationSystem
{
    public record LogRecord
    {
        private DateTime TimeStamp;
        private string ReserverName;
        private string RoomName;
    }
}