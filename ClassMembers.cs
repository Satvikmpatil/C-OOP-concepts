// ===========================================
// CLASS MEMBERS (Fields)
// ===========================================
// Fields are variables declared inside a class
// Each object has its own copy of fields

class Car1
{
  // Fields - define the data a class holds
  string model;
  string color;
  int year;

  static void Main(string[] args)
  {
    // Creating first object and setting its field values
    Car1 Ford = new Car1();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    // Creating second object with different values
    // Each object maintains its own state
    Car1 Opel = new Car1();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);  // Output: Mustang
    Console.WriteLine(Opel.model);  // Output: Astra
  }
}
