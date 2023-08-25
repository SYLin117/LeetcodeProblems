using ElevatorSimulator;

Console.WriteLine("Enter your floor request. Example: '5u', '8D', or '2'. Enter 'Q' to quit.");
var elevator = new Elevator(10); // Assuming a 10-floor building for simplicity

while (true)
{
    Console.Write("Enter floor request: ");
    var requestStr = Console.ReadLine()?.Trim().ToLower();

    if (requestStr == "q")
    {
        await elevator.MoveAsync(); // finish all remaining requests
        break;
    }

    elevator.Request(requestStr);
    if (elevator.State != State.Moving)
    {
        await elevator.MoveAsync();
    }
}