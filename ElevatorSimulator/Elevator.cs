namespace ElevatorSimulator
{
    public enum Direction
    {
        Up,
        Down,
        Idle
    }

    public enum State
    {
        Moving,
        Stopped
    }

    public class Elevator
    {
        public int CurrentFloor { get; private set; } = 1;
        private Direction Direction { get; set; } = Direction.Idle; // can be "UP", "DOWN" or null
        public State State { get; private set; } = State.Stopped;
        private readonly List<int> RequestedFloors = new();
        private readonly List<int> UpRequestFloors = new();
        private readonly List<int> DownRequestFloors = new();
        private readonly int MaxFloors;

        public Elevator(int maxFloors)
        {
            MaxFloors = maxFloors;
        }

        public void Request(string requestStr)
        {
            requestStr = requestStr.ToLower();
            int floor;

            if (Int32.TryParse(requestStr, out floor))
            {
                RequestedFloors.Add(floor);
            }
            else if (requestStr.EndsWith("u"))
            {
                floor = int.Parse(requestStr.Substring(0, requestStr.Length - 1));
                RequestedFloors.Add(floor);
            }
            else if (requestStr.EndsWith("d"))
            {
                floor = int.Parse(requestStr.Substring(0, requestStr.Length - 1));
                RequestedFloors.Add(floor);
            }
            else
            {
                RequestedFloors.Add(int.Parse(requestStr));
            }

            Console.WriteLine($"{DateTime.Now} - Requested floor: {requestStr}");
        }

        public async Task MoveAsync()
        {
            while (RequestedFloors.Any())
            {
                SetDirection();

                var nextFloor = Direction == Direction.Up ? CurrentFloor + 1 : CurrentFloor - 1;

                State = State.Moving;
                await Task.Delay(TimeSpan.FromSeconds(3));
                CurrentFloor = nextFloor;

                Console.WriteLine($"{DateTime.Now} - Passed floor: {CurrentFloor}");

                if (RequestedFloors.Contains(CurrentFloor))
                {
                    State = State.Stopped;
                    Console.WriteLine($"{DateTime.Now} - Stopped at floor: {CurrentFloor}");
                    RequestedFloors.Remove(CurrentFloor);
                    await Task.Delay(TimeSpan.FromSeconds(1));
                }
            }

            Direction = Direction.Idle;
        }

        private void SetDirection()
        {
            if (Direction == Direction.Idle)
            {
                var request = RequestedFloors.FirstOrDefault();
                if (request > CurrentFloor)
                {
                    Direction = Direction.Up;
                }
                else if (request < CurrentFloor)
                {
                    Direction = Direction.Down;
                }

                return;
            }

            if (Direction == Direction.Up && CurrentFloor == MaxFloors && RequestedFloors.Count > 0) // reach top
            {
                Direction = Direction.Down;
            }
            else if (Direction == Direction.Down && CurrentFloor == 1 && RequestedFloors.Count > 0) // reach bottom
            {
                Direction = Direction.Up;
            }
        }
    }
}