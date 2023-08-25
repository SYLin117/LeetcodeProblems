namespace CodeChallenge
{
    public class RequestManager
    {
        private List<int> InternalRequests = new List<int>();
        private List<int> ExternalRequests = new List<int>();

        private List<int> SkipRequests = new List<int>();

        public void AddInternalRequest(int floor, int currentFloor, Direction direction)
        {
            if (ShouldSkipRequest(floor, currentFloor, direction)) return;
            if (!InternalRequests.Contains(floor))
                InternalRequests.Add(floor);
        }

        public void AddExternalRequest(int floor, int currentFloor, Direction direction)
        {
            if (ShouldSkipRequest(floor, currentFloor, direction)) return;
            if (!ExternalRequests.Contains(floor))
                ExternalRequests.Add(floor);
        }

        private bool ShouldSkipRequest(int floor, int currentFloor, Direction direction)
        {
            if (direction == Direction.Up && floor == currentFloor + 1)
            {
                SkipRequests.Add(floor);
                return true;
            }

            if (direction == Direction.Down && floor == currentFloor - 1)
            {
                SkipRequests.Add(floor);
                return true;
            }

            return false;
        }

        public void ProcessSkipRequests(Direction currentDirection)
        {
            if (currentDirection == Direction.Up)
            {
                SkipRequests.RemoveAll(x => InternalRequests.Contains(x));
                SkipRequests.RemoveAll(x => ExternalRequests.Contains(x));
            }
            else
            {
                SkipRequests.Clear();
            }
        }

        public int? GetNextRequest(Direction direction, int currentFloor)
        {
            // Combine internal and external requests
            var requests = InternalRequests.Concat(ExternalRequests).Distinct().ToList();

            // If no requests, return null
            if (!requests.Any()) return null;

            // Handle upward movement
            if (direction == Direction.Up)
            {
                var upwardRequests = requests.Where(x => x > currentFloor).OrderBy(x => x);
                if (upwardRequests.Any()) return upwardRequests.First();
                return requests.Min(); // If no requests above, get the lowest floor
            }
            // Handle downward movement
            else if (direction == Direction.Down)
            {
                var downwardRequests = requests.Where(x => x < currentFloor).OrderByDescending(x => x);
                if (downwardRequests.Any()) return downwardRequests.First();
                return requests.Max(); // If no requests below, get the highest floor
            }
            // If stopped, get the closest request
            else
            {
                return requests.OrderBy(x => Math.Abs(currentFloor - x)).First();
            }
        }

        public void RemoveRequest(int floor)
        {
            InternalRequests.Remove(floor);
            ExternalRequests.Remove(floor);
        }
    }
}