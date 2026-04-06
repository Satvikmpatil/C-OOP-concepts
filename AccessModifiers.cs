// ===========================================
// ACCESS MODIFIERS
// ===========================================
// Control the visibility/accessibility of class members
//
// public    - Accessible from anywhere
// private   - Only accessible within the same class (default)
// protected - Accessible in same class and derived classes
// internal  - Accessible within the same assembly

class Car3
{
  // Private field: Can only be accessed inside this class
  // This hides internal data from outside code
  private string model = "Mustang";

  static void Main(string[] args)
  {
    Car3 myObj = new Car3();

    // This works because Main() is inside Car3 class
    Console.WriteLine(myObj.model);  // Output: Mustang

    // Note: If accessed from another class, this would cause error
  }
}
