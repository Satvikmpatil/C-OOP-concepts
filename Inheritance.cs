// ===========================================
// INHERITANCE
// ===========================================
// Inheritance: Creating new class from existing class
// - Base/Parent class: The class being inherited from
// - Derived/Child class: The class that inherits
// - Use colon (:) to inherit
//
// Benefits: Code reuse, hierarchical relationships

// Base class (Parent)
class Vehicle
{
  public string brand = "Ford";

  public void honk()
  {
    Console.WriteLine("Tuut, tuut!");
  }
}

// Derived class (Child) - inherits from Vehicle
// Car4 gets all public members of Vehicle
class Car4 : Vehicle
{
  public string modelName = "Mustang";  // Car4's own field
}

class Program4
{
  static void Main(string[] args)
  {
    Car4 myCar = new Car4();

    // Calling inherited method from Vehicle
    myCar.honk();  // Output: Tuut, tuut!

    // Accessing inherited field (brand) and own field (modelName)
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
    // Output: Ford Mustang
  }
}
