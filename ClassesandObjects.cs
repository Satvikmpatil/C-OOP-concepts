// ===========================================
// CLASSES AND OBJECTS
// ===========================================
// Class: A blueprint/template for creating objects
// Object: An instance of a class with actual values

class Car
{
  // Field: A variable inside a class
  string color = "red";

  static void Main(string[] args)
  {
    // Creating an object using 'new' keyword
    Car myObj = new Car();

    // Accessing object's field using dot notation
    Console.WriteLine(myObj.color);  // Output: red
  }
}
