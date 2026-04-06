// ===========================================
// ENUMERATIONS (enum)
// ===========================================
// Enum: A special type representing a group of named constants
// - Makes code more readable (Level.High vs just 2)
// - Type-safe: Can only assign defined values
// - By default: First value = 0, then 1, 2, etc.

class Program6
{
  // Define an enum with three constant values
  enum Level
  {
    Low,     // = 0
    Medium,  // = 1
    High     // = 2
  }

  static void Main(string[] args)
  {
    // Declare variable of enum type and assign a value
    Level myVar = Level.Medium;

    Console.WriteLine(myVar);        // Output: Medium
    Console.WriteLine((int)myVar);   // Output: 1 (cast to see numeric value)
  }
}
