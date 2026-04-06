// ===========================================
// INTERFACES
// ===========================================
// Interface: A contract that defines what a class must do
// - Contains only method signatures (no implementation)
// - A class can implement MULTIPLE interfaces (unlike single inheritance)
// - Interface names typically start with 'I'
//
// Use case: Define capabilities a class must have

// First interface
interface IFirstInterface
{
  void myMethod();  // No body - just the signature
}

// Second interface
interface ISecondInterface
{
  void myOtherMethod();
}

// Class implementing multiple interfaces
// Must provide implementation for ALL interface methods
class DemoClass : IFirstInterface, ISecondInterface
{
  // Implementation of IFirstInterface method
  public void myMethod()
  {
    Console.WriteLine("Some text..");
  }

  // Implementation of ISecondInterface method
  public void myOtherMethod()
  {
    Console.WriteLine("Some other text...");
  }
}

class Program5
{
  static void Main(string[] args)
  {
    DemoClass myObj = new DemoClass();
    myObj.myMethod();       // Output: Some text..
    myObj.myOtherMethod();  // Output: Some other text...
  }
}
