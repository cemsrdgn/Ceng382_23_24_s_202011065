using ReservationSystem;

public class ReservationRepository : IReservationRepository{

    private List<Reservation> _reservations;

    public void AddReservation(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public void DeleteReservation(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public List<Reservation> GetAllReservation()
    {
        return _reservations;
    }
}