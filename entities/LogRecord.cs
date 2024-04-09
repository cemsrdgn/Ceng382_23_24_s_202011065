using System;


namespace ReservationSystem
{
    public record LogRecord
    {
        private DateTime TimeStamp { get; set; }
        private string ReserverName { get; set;}
        private string RoomName { get; set; }

        public DateTime getTimeStamp(){
            return this.TimeStamp;
        }

        public string getReserverName(){
            return this.ReserverName;
        }

        public string getRoomName(){
            return this.RoomName;
        }

        public void setTimeStamp(DateTime value){
            this.TimeStamp = value;
        }

        public void setReserverName(string value){
            this.ReserverName = value;
        }

        public void setRoomName(string value){
            this.RoomName = value;
        }

        
    }
}