using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ReservationSystem
{
    public record Reservation
    {
    public DateTime Time { get; set; }
    public DateTime Date { get; set; }
    public string ReserverName { get; set; }
    public Room Room { get; set; }
    }
}