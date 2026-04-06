// ===========================================
// PROPERTIES AND ENCAPSULATION
// ===========================================
// Encapsulation: Hiding internal data and providing controlled access
// Properties: Special methods (get/set) that act like fields
//
// Benefits:
// - Control over data (validation in setter)
// - Read-only or write-only access possible
// - Can change internal implementation without breaking code

class Person
{
  // Private field - hidden from outside
  private string name;

  // Public property - provides controlled access to private field
  public string Name
  {
    get { return name; }      // Getter: returns the field value
    set { name = value; }     // Setter: assigns value to field
  }
}

class Program1
{
  static void Main(string[] args)
  {
    Person myObj = new Person();

    // Using property setter (looks like field assignment)
    myObj.Name = "Liam";

    // Using property getter
    Console.WriteLine(myObj.Name);  // Output: Liam
  }
}
