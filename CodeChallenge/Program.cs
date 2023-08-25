namespace CodeChallenge
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var elevator = new Elevator();
            var sensor = new Sensor(elevator);
            var requestManager = new RequestManager();

            Console.WriteLine(
                "Elevator is ready! (Press 'Q' to quit, Enter a number for a floor request, Add 'U' for an external up request, or 'D' for an external down request)");

            // Start an async task to handle user input
            var inputTask = Task.Run(() => HandleUserInput(requestManager, sensor));

            // Main simulation loop
            while (true)
            {
                var (currentFloor, direction, state) = sensor.GetData();

                int? nextRequest = requestManager.GetNextRequest(direction, currentFloor);
                if (nextRequest.HasValue)
                {
                    if (nextRequest.Value > currentFloor)
                    {
                        elevator.MoveUp();
                        Console.WriteLine($"Moving Up: Current Floor {elevator.CurrentFloor}");
                    }
                    else if (nextRequest.Value < currentFloor)
                    {
                        elevator.MoveDown();
                        Console.WriteLine($"Moving Down: Current Floor {elevator.CurrentFloor}");
                    }
                    else
                    {
                        elevator.Stop();
                        requestManager.RemoveRequest(currentFloor);
                        Console.WriteLine($"Stopped at Floor {currentFloor}");
                        Thread.Sleep(1000); // Wait for 1 second
                    }
                }

                if (state == State.Stopped)
                {
                    requestManager.ProcessSkipRequests(direction);
                }

                // Simulate time taken to move between floors
                if (state == State.Moving) Thread.Sleep(Elevator.TravelTime * 1000);

                // Check if user wants to end the simulation
                if (inputTask.IsCompleted) break;
            }
        }

        static async Task HandleUserInput(RequestManager requestManager, Sensor sensor)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToUpper() == "Q") break; // End the simulation

                var (currentFloor, direction, _) = sensor.GetData();

                if (int.TryParse(input, out int floor))
                {
                    requestManager.AddInternalRequest(floor, currentFloor, direction);
                    Console.WriteLine($"Internal request added for floor {floor}");
                }
                else if (input.EndsWith("U"))
                {
                    int externalFloor = int.Parse(input.Substring(0, input.Length - 1));
                    requestManager.AddExternalRequest(externalFloor, currentFloor, direction);
                    Console.WriteLine($"External request added for floor {externalFloor} direction Up");
                }
                else if (input.EndsWith("D"))
                {
                    int externalFloor = int.Parse(input.Substring(0, input.Length - 1));
                    requestManager.AddExternalRequest(externalFloor, currentFloor, direction);
                    Console.WriteLine($"External request added for floor {externalFloor} direction Down");
                }
            }
        }
    }
}