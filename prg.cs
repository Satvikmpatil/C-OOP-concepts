// ===========================================
// EXCEPTION HANDLING
// ===========================================
// Exceptions: Runtime errors that disrupt normal program flow
//
// try     - Code that might throw an exception
// catch   - Handles the exception if one occurs
// finally - Always executes (cleanup code)
//
// Purpose: Gracefully handle errors instead of crashing

class Program7
{
  public static void Main(String[] args)
  {
    try
    {
      // Code that might cause an error
      int[] myNum = {1, 2, 3};
      Console.WriteLine(myNum[1]);  // OK: prints 2
      // Console.WriteLine(myNum[10]); // Would throw IndexOutOfRangeException
    }
    catch (Exception e)
    {
      // Executes only if an exception occurs in try block
      Console.WriteLine("Something went wrong: " + e.Message);
    }
    finally
    {
      // Always executes - good for cleanup (closing files, connections)
      Console.WriteLine("The 'try catch' is finished.");
    }
  }
}
