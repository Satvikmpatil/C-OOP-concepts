// ===========================================
// CONSTRUCTORS
// ===========================================
// Constructor: Special method called when object is created
// - Same name as the class
// - No return type
// - Used to initialize object state

class Car2
{
  public string model;
  public string color;
  public int year;

  // Constructor with parameters
  // Allows initializing fields at object creation time
  public Car2(string modelName, string modelColor, int modelYear)
  {
    model = modelName;
    color = modelColor;
    year = modelYear;
  }

  static void Main(string[] args)
  {
    // Creating object and passing values to constructor
    // Much cleaner than setting each field separately
    Car2 Ford = new Car2("Mustang", "Red", 1969);

    Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    // Output: Red 1969 Mustang
  }
}
