using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ReservationSystem
{
    public record Room
    {
        [JsonPropertyName("roomId")]
        private string Id { get; set; }

        [JsonPropertyName("roomName")]
        private string Name { get; set; }

        [JsonPropertyName("capacity")]
        private int Capacity { get; set; }

        public string getRoomId(){
            return this.Id;
        }

         public string getRoomName(){
            return this.Name;
        }

         public int getCapacity(){
            return this.Capacity;
        }
        public void setRoomId(string value){
            this.Id = value;
        }

         public void setRoomName(string value){
            this.Name = value;
        }

         public void setCapacity(int value){
            this.Capacity = value;
        } 


    }
}