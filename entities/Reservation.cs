using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ReservationSystem
{
    public record Reservation
    {
        private DateTime Time { get; set; }
        private DateTime Date { get; set; }
        private string ReserverName { get; set; }
        private Room Room { get; set; }

        public DateTime getTime(){
            return this.Time;
        }

        public DateTime getDate(){
            return this.Date;
        }

        public string getReserverName(){
            return this.ReserverName;
        }

        public Room getRoom(){
            return this.Room;
        }

        public void setTime(DateTime value){
            this.Time = value;
        }

        public void setDate(DateTime value){
            this.Date = value;
        }

        public void setReserverName(string value){
            this.ReserverName = value;
        }

        public void setRoom(Room value){
            this.Room = value;
        }

    }
}