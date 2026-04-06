// ===========================================
// ABSTRACTION
// ===========================================
// Abstraction: Hiding complex implementation, showing only essentials
//
// abstract class - Cannot be instantiated directly
// abstract method - Has no body, MUST be overridden in derived class
//
// Use case: Define a contract that derived classes must follow

// Abstract class - serves as a template
abstract class Animal3
{
  // Abstract method - no implementation here
  // Forces derived classes to provide their own implementation
  public abstract void animalSound();

  // Regular method - has implementation, inherited as-is
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Concrete class - must implement all abstract methods
class Pig3 : Animal3
{
  // Required: Must override and provide body for abstract method
  public override void animalSound()
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program3
{
  static void Main(string[] args)
  {
    // Cannot do: Animal3 a = new Animal3(); // Error!

    Pig3 myPig = new Pig3();
    myPig.animalSound();  // Output: The pig says: wee wee
    myPig.sleep();        // Output: Zzz (inherited method)
  }
}
