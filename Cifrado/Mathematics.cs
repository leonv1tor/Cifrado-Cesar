namespace Cifrado;

public static class Mathematics{
  private static List<string> previousCipheredWords = new List<string>();
  private static bool input = true;
  private static List<char> abecedario = new List<char>{    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm','n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
  private static List<char> abecedarioMayus = new List<char>{'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};


  ///Aca es el Cifrado Automatico

 public static void CifradoAuto(){ 
  Console.WriteLine("Ingresa la frase: \n");
  string? phrase = Console.ReadLine(); // Permitir null
  if (string.IsNullOrEmpty(phrase)){
    Console.WriteLine("La entrada no puede estar vacía.");
    input = false;
    return;
  }
  if (string.IsNullOrWhiteSpace(phrase)){
    Console.WriteLine("La entrada no puede estar vacía.");
    input = false;
    return;
  }
  string[] wordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
  List<string> cypherwords = new List<string>();
  List<string> words = new List<string>();
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
      }else if (wchar >= 'A' && wchar <= 'Z'){
        int index = (abecedarioMayus.IndexOf(wchar) + displacement) % 26;
        char yes = abecedarioMayus[index];
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


  /// Decifrado Automatico

  public static void DecifradoAuto(){
    if(input){
      List<string> words = new List<string>();
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
          }else if (wchar >= 'A' && wchar <= 'Z'){
            int index = (abecedarioMayus.IndexOf(wchar) - displacement) % 26;
            if(index < 0){
              index += 26;
            }
            char yes = abecedarioMayus[index];
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
    }else{
      Console.WriteLine("\nLa entrada no puede estar vacía.");
      return;
    }
  }


  ///Cifrado Manual


 public static void Cifrado(){ 
  Console.WriteLine("Ingresa la frase: \n");
  string? phrase = Console.ReadLine(); // Permitir null
  if (string.IsNullOrEmpty(phrase)){
    Console.WriteLine("La entrada no puede estar vacía.");
    return;
  }
  if (string.IsNullOrWhiteSpace(phrase)){
    Console.WriteLine("La entrada no puede estar vacía.");
    input = false;
    return;
  }
  string[] wordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
  List<string> cypherwords = new List<string>();
  List<string> words = new List<string>();
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
      }else if (wchar >= 'A' && wchar <= 'Z'){
        int index = (abecedarioMayus.IndexOf(wchar) + displacement) % 26;
        char yes = abecedarioMayus[index];
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

  ///Decifrado Manual


  public static void Decifrado(){
    Console.WriteLine("Ingresa la frase cifrada: \n");
    string? phrase = Console.ReadLine(); // Permitir null
    if (string.IsNullOrEmpty(phrase)){
      Console.WriteLine("La entrada no puede estar vacía.");
      return;
    }
    if (string.IsNullOrWhiteSpace(phrase)){
      Console.WriteLine("La entrada no puede estar vacía.");
      input = false;
      return;
    }
    string[] cypherwordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
    List<string> cypherwords = new List<string>();
    List<string> words = new List<string>();
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
        }else if (wchar >= 'A' && wchar <= 'Z'){
          int index = (abecedarioMayus.IndexOf(wchar) - displacement) % 26;
          if(index < 0){
            index += 26;
          }
          char yes = abecedarioMayus[index];
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
