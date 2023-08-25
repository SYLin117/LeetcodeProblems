namespace CodeChallenge
{
    public class Sensor
    {
        private readonly Elevator _elevator;

        public Sensor(Elevator elevator)
        {
            _elevator = elevator;
        }

        public (int currentFloor, Direction direction, State state) GetData()
        {
            return (_elevator.CurrentFloor, _elevator.Direction, _elevator.State);
        }
    }
}