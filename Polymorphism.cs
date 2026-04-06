// ===========================================
// POLYMORPHISM
// ===========================================
// Polymorphism: "Many forms" - same method behaves differently
//
// virtual  - Marks method in base class as overridable
// override - Provides new implementation in derived class
//
// Key concept: A parent reference can hold child objects,
// and the correct overridden method gets called at runtime

// Base class
class Animal
{
  // virtual allows derived classes to override this method
  public virtual void animalSound()
  {
    Console.WriteLine("The animal makes a sound");
  }
}

// Derived class - overrides the base method
class Pig : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

// Another derived class with different behavior
class Dog : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program2
{
  static void Main(string[] args)
  {
    // All variables declared as Animal type
    Animal myAnimal = new Animal();
    Animal myPig = new Pig();    // Parent type, child object
    Animal myDog = new Dog();    // Parent type, child object

    // Each calls its own version of the method
    myAnimal.animalSound();  // Output: The animal makes a sound
    myPig.animalSound();     // Output: The pig says: wee wee
    myDog.animalSound();     // Output: The dog says: bow wow
  }
}
