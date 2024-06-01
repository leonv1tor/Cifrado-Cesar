// See https://aka.ms/new-console-template for more information
using Cifrado;

  Console.WriteLine("\n***** CALCULADOR DE CIFRADO *****\n"); 
  Console.WriteLine("1 ---> Cifrado\n2 ---> Decifrado\n3 ---> Cifrado y Decifrado\nSeleccione una opcion (1 - 2 - 3): ");
  int optionMr = Convert.ToInt32(Console.ReadLine());
  switch (optionMr)
  {
    case 1:
  Console.WriteLine("\n***** CIFRADO CESAR *****\n"); 
  Mathematics.Cifrado();
    break;
    case 2:
  Console.WriteLine("\n\n***** DECIFRADO CESAR *****");
  Mathematics.Decifrado();
    break;
    case 3:
  Console.WriteLine("\n***** CIFRADO CESAR *****\n"); 
  Mathematics.CifradoAuto();
  Console.WriteLine("\n\n***** DECIFRADO CESAR *****");
  Mathematics.DecifradoAuto();
    break;
    default:
    break;
  }

