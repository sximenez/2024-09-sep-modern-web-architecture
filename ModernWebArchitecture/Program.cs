#region Interface -----------------------------------------

public interface IEngine
{
    void Start();
}

#endregion

#region Implementations -----------------------------------

public class GasEngine : IEngine
{
    public void Start() => Console.WriteLine("Gas engine started.");
}

public class ElectricEngine : IEngine
{
    public void Start() => Console.WriteLine("Electric engine started.");
}

public class Car
{
    private readonly IEngine _engine;

    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
        Console.WriteLine("Car is running.");
    }
}

#endregion

public class Program
{
    static void Main(string[] args)
    {
        Car petrolCar = new Car(new GasEngine());
        Car electricCar = new Car(new ElectricEngine());
                
        petrolCar.Start();
        electricCar.Start();
    }
}