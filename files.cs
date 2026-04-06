// ===========================================
// FILE I/O (Input/Output)
// ===========================================
// System.IO namespace provides file operations
// File class has static methods for common file tasks

using System.IO;  // Required for file operations

class Program8
{
  static void Main(string[] args)
  {
    // WRITING to a file
    string writeText = "Hello World!";
    File.WriteAllText("filename.txt", writeText);  // Creates file and writes content

    // READING from a file
    string readText = File.ReadAllText("filename.txt");  // Reads entire file content
    Console.WriteLine(readText);  // Output: Hello World!

    // Other useful File methods:
    // File.Exists(path)        - Check if file exists
    // File.Delete(path)        - Delete a file
    // File.AppendAllText()     - Add text to existing file
    // File.ReadAllLines()      - Read file as array of lines
  }
}
