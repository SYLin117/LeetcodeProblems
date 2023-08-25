namespace CodeChallenge
{
    public class Elevator
    {
        public int CurrentFloor { get; private set; } = 1;
        public Direction Direction { get; private set; } = Direction.Stopped;
        public State State { get; private set; } = State.Stopped;

        public const int TravelTime = 3; // Time in seconds between floors

        public void MoveUp()
        {
            CurrentFloor++;
            Direction = Direction.Up;
            State = State.Moving;
        }

        public void MoveDown()
        {
            CurrentFloor--;
            Direction = Direction.Down;
            State = State.Moving;
        }

        public void Stop()
        {
            Direction = Direction.Stopped;
            State = State.Stopped;
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Stopped
    }

    public enum State
    {
        Moving,
        Stopped
    }
}