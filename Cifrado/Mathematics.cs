namespace Cifrado;

public static class Mathematics{
  private static List<string> previousCipheredWords = new List<string>();
  private static bool input = true;
  private static List<char> abecedario = new List<char>{
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
    '1', '2', '3', '4', '5', '6', '7', '8', '9'
  };
  private static List<char> abecedarioMayus = new List<char>{
    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
    '1', '2', '3', '4', '5', '6', '7', '8', '9'
  };

  // Cifrado Automático
  public static string CifradoAuto(string phrase, int displacement){ 
    if (string.IsNullOrEmpty(phrase)){
      throw new ArgumentException("La entrada no puede estar vacía.");
    }
    if (string.IsNullOrWhiteSpace(phrase)){
      throw new ArgumentException("La entrada no puede estar vacía.");
    }
    string[] wordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
    List<string> cypherwords = new List<string>();
    List<string> words = new List<string>();
    foreach (string word in wordarray){
      words.Add(word);
    }
    foreach (var word in words){
      string encryptedword = "";
      foreach (var wchar in word){
        if (char.IsLower(wchar)){
          int index = (abecedario.IndexOf(wchar) + displacement) % 35; // 26 letras + 9 dígitos = 35
          char yes = abecedario[index];
          encryptedword += yes;
        } else if (char.IsUpper(wchar)){
          int index = (abecedarioMayus.IndexOf(wchar) + displacement) % 35; // 26 letras + 9 dígitos = 35
          char yes = abecedarioMayus[index];
          encryptedword += yes;
        } else {
          encryptedword += wchar; // Si no es una letra del abecedario, mantenerla sin cambios
        }
      }
      cypherwords.Add(encryptedword);
    }
    previousCipheredWords.AddRange(cypherwords);
    return string.Join(" ", cypherwords);
  }

  // Descifrado Automático
  public static string DecifradoAuto(int displacement){
    if(input){
      List<string> words = new List<string>();
      foreach (var cypherword in previousCipheredWords){
        string word = "";
        foreach (var wchar in cypherword){
          if (char.IsLower(wchar)){
            int index = (abecedario.IndexOf(wchar) - displacement) % 35;
            if(index < 0){
              index += 35;
            }
            char yes = abecedario[index];
            word += yes;
          } else if (char.IsUpper(wchar)){
            int index = (abecedarioMayus.IndexOf(wchar) - displacement) % 35;
            if(index < 0){
              index += 35;
            }
            char yes = abecedarioMayus[index];
            word += yes;
          } else {
            word += wchar; // Si no es una letra del abecedario, mantenerla sin cambios
          }
        }
        words.Add(word);
      }
      return string.Join(" ", words);
    } else {
      throw new ArgumentException("La entrada no puede estar vacía.");
    }
  }

  // Cifrado Manual
  public static string Cifrado(string phrase, int displacement){ 
    if (string.IsNullOrEmpty(phrase)){
      throw new ArgumentException("La entrada no puede estar vacía.");
    }
    if (string.IsNullOrWhiteSpace(phrase)){
      throw new ArgumentException("La entrada no puede estar vacía.");
    }
    string[] wordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
    List<string> cypherwords = new List<string>();
    List<string> words = new List<string>();
    foreach (string word in wordarray){
      words.Add(word);
    }
    foreach (var word in words){
      string encryptedword = "";
      foreach (var wchar in word){
        if (char.IsLower(wchar)){
          int index = (abecedario.IndexOf(wchar) + displacement) % 35; // 26 letras + 9 dígitos = 35
          char yes = abecedario[index];
          encryptedword += yes;
        } else if (char.IsUpper(wchar)){
          int index = (abecedarioMayus.IndexOf(wchar) + displacement) % 35; // 26 letras + 9 dígitos = 35
          char yes = abecedarioMayus[index];
          encryptedword += yes;
        } else {
          encryptedword += wchar; // Si no es una letra del abecedario, mantenerla sin cambios
        }
      }
      cypherwords.Add(encryptedword);
    }
    return string.Join(" ", cypherwords);
  }

  // Descifrado Manual
  public static string Decifrado(string phrase, int displacement){
    if (string.IsNullOrEmpty(phrase)){
      throw new ArgumentException("La entrada no puede estar vacía.");
    }
    if (string.IsNullOrWhiteSpace(phrase)){
      throw new ArgumentException("La entrada no puede estar vacía.");
    }
    string[] cypherwordarray = phrase.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
    List<string> cypherwords = new List<string>();
    List<string> words = new List<string>();
    foreach (string cypherword in cypherwordarray){
      cypherwords.Add(cypherword);
    }
    foreach (var cypherword in cypherwords){
      string word = "";
      foreach (var wchar in cypherword){
        if (char.IsLower(wchar)){
          int index = (abecedario.IndexOf(wchar) - displacement) % 35;
          if(index < 0){
            index += 35;
          }
          char yes = abecedario[index];
          word += yes;
        } else if (char.IsUpper(wchar)){
          int index = (abecedarioMayus.IndexOf(wchar) - displacement) % 35;
          if(index < 0){
            index += 35;
          }
          char yes = abecedarioMayus[index];
          word += yes;
        } else {
          word += wchar; // Si no es una letra del abecedario, mantenerla sin cambios
        }
      }
      words.Add(word);
    }
    return string.Join(" ", words);
  }
}
