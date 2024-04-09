using System;
using System.Text.Json;
using System.Text.Json.Serialization;

using System.Collections.Generic;
namespace ReservationSystem
{
    public record Room
    {
        [JsonPropertyName("roomId")]
        public string RoomId { get; init; }

        [JsonPropertyName("roomName")]
        public string RoomName { get; init; }

        [JsonPropertyName("capacity")]
        public int Capacity { get; init; }
    }
}