namespace Cifrado;

public static class Mathematics{
  private static List<string> previousCipheredWords = new List<string>();
 public static void CifradoAuto(){ 
  Console.WriteLine("Ingresa la frase: \n");
  string? phrase = Console.ReadLine(); // Permitir null
  if (string.IsNullOrEmpty(phrase)){
    Console.WriteLine("La entrada no puede estar vacía.");
    return;
  }
  string[] wordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
  List<string> cypherwords = new List<string>();
  List<string> words = new List<string>();
  List<char> abecedario = new List<char>{
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm','n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
  foreach (string word in wordarray){
    words.Add(word);
  }
  Console.WriteLine("\nIngresa el desplazamiento: \n");
  if (!int.TryParse(Console.ReadLine(), out int displacement)) {
    Console.WriteLine("Invalid displacement value.");
    return;
  }
  foreach (var word in words){
    string encryptedword = "";
    foreach (var wchar in word){
      if (wchar >= 'a' && wchar <= 'z'){
        int index = (abecedario.IndexOf(wchar) + displacement) % 26;
        char yes = abecedario[index];
        encryptedword += yes;
      }else{
        encryptedword += wchar; // Si no es una letra del abecedario, mantenerla sin cambios
      }
    }
    cypherwords.Add(encryptedword);
  }
  Console.WriteLine("\nFrase cifrada: \n");
  foreach (var cypherword in cypherwords){
  Console.Write(cypherword + " ");
  }
  previousCipheredWords.AddRange(cypherwords);
 }

  public static void DecifradoAuto(){
    List<string> words = new List<string>();
    List<char> abecedario = new List<char>{
      'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm','n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    Console.WriteLine("\nIngresa el desplazamiento: \n");
    if (!int.TryParse(Console.ReadLine(), out int displacement)) {
      Console.WriteLine("Invalid displacement value.");
      return;
    }
    foreach (var cypherword in previousCipheredWords){
      string word = "";
      foreach (var wchar in cypherword){
        if (wchar >= 'a' && wchar <= 'z'){
          int index = (abecedario.IndexOf(wchar) - displacement) % 26;
          if(index < 0){
            index += 26;
          }
          char yes = abecedario[index];
          word += yes;
        }else{
          word += wchar; // Si no es una letra del abecedario, mantenerla sin cambios
        }
      }
      words.Add(word);
    }
    Console.WriteLine("\nFrase decifrada: \n");
    foreach (var word in words){
    Console.Write(word + " ");
    }
  }
 public static void Cifrado(){ 
  Console.WriteLine("Ingresa la frase: \n");
  string? phrase = Console.ReadLine(); // Permitir null
  if (string.IsNullOrEmpty(phrase)){
    Console.WriteLine("La entrada no puede estar vacía.");
    return;
  }
  string[] wordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
  List<string> cypherwords = new List<string>();
  List<string> words = new List<string>();
  List<char> abecedario = new List<char>{
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm','n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
  foreach (string word in wordarray){
    words.Add(word);
  }
  Console.WriteLine("\nIngresa el desplazamiento: \n");
  if (!int.TryParse(Console.ReadLine(), out int displacement)) {
    Console.WriteLine("Invalid displacement value.");
    return;
  }
  foreach (var word in words){
    string encryptedword = "";
    foreach (var wchar in word){
      if (wchar >= 'a' && wchar <= 'z'){
        int index = (abecedario.IndexOf(wchar) + displacement) % 26;
        char yes = abecedario[index];
        encryptedword += yes;
      }else{
        encryptedword += wchar; // Si no es una letra del abecedario, mantenerla sin cambios
      }
    }
    cypherwords.Add(encryptedword);
  }
  Console.WriteLine("\nFrase cifrada: \n");
  foreach (var cypherword in cypherwords){
  Console.Write(cypherword + " ");
  }
 }
  public static void Decifrado(){
    Console.WriteLine("Ingresa la frase cifrada: \n");
    string? phrase = Console.ReadLine(); // Permitir null
    if (string.IsNullOrEmpty(phrase)){
      Console.WriteLine("La entrada no puede estar vacía.");
      return;
    }
    string[] cypherwordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
    List<string> cypherwords = new List<string>();
    List<string> words = new List<string>();
    List<char> abecedario = new List<char>{'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm','n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    foreach (string cypherword in cypherwordarray){
      cypherwords.Add(cypherword);
    }
    Console.WriteLine("\nIngresa el desplazamiento: \n");
    if (!int.TryParse(Console.ReadLine(), out int displacement)) {
      Console.WriteLine("Invalid displacement value.");
      return;
    }
    foreach (var cypherword in cypherwords){
      string word = "";
      foreach (var wchar in cypherword){
        if (wchar >= 'a' && wchar <= 'z'){
          int index = (abecedario.IndexOf(wchar) - displacement) % 26;
          if(index < 0){
            index += 26;
          }
          char yes = abecedario[index];
          word += yes;
        }else{
          word += wchar; // Si no es una letra del abecedario, mantenerla sin cambios
        }
      }
      words.Add(word);
    }
    Console.WriteLine("\nFrase decifrada: \n");
    foreach (var word in words){
    Console.Write(word + " ");
    }
  }
}
