namespace Cifrado;

public static class Mathematics
{
 public static void Cifrado() { 
  Console.WriteLine("Ingresa la frase y el desplazamiento: \n");
  string? phrase = Console.ReadLine(); // Permitir null
    if (string.IsNullOrEmpty(phrase))
    {
      Console.WriteLine("La entrada no puede estar vacía.");
      return;
    }
  string[] wordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
  List<string> words = new List<string>();
  foreach (string word in wordarray)
  {
    words.Add(word);
  }
  Console.WriteLine("\nThe words are:");
  foreach (var word in words)
  {
    Console.WriteLine(word);
  }
 }
 public static void Decifrado() { 
  Console.WriteLine("Ingresa la frase y el desplazamiento: \n");
  string? phrase = Console.ReadLine(); // Permitir null
    if (string.IsNullOrEmpty(phrase))
    {
      Console.WriteLine("La entrada no puede estar vacía.");
      return;
    }
  string[] wordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
  List<string> words = new List<string>();
  foreach (string word in wordarray)
  {
    words.Add(word);
  }
  Console.WriteLine("\nThe words are:");
  foreach (var word in words)
  {
    Console.WriteLine(word);
  }
 }
}
