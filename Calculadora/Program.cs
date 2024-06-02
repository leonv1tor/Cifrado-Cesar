using Cifrado;

Console.WriteLine("\n***** CALCULADOR DE CIFRADO *****\n");
Console.WriteLine("1 ---> Cifrado\n2 ---> Decifrado\n3 ---> Cifrado y Decifrado\n");
Console.Write("Seleccione una opcion (1 - 2 - 3): ");

if (!int.TryParse(Console.ReadLine(), out int optionMr))
{
    Console.WriteLine("Invalid option value.");
    return;
}

switch (optionMr)
{
    case 1:
        Console.WriteLine("\n***** CIFRADO CESAR *****\n");
        Console.Write("Ingresa la frase: ");
        string? phrase = Console.ReadLine(); // Permitir null
        if (string.IsNullOrEmpty(phrase))
        {
            Console.WriteLine("Frase no puede ser vacía o nula.");
            return;
        }
        Console.Write("\nIngresa el desplazamiento: ");
        if (!int.TryParse(Console.ReadLine(), out int displacement))
        {
            Console.WriteLine("Invalid displacement value.");
            return;
        }
        Console.WriteLine("\nFrase cifrada: ");
        Console.WriteLine(Mathematics.Cifrado(phrase, displacement));
        break;

    case 2:
        Console.WriteLine("\n\n***** DECIFRADO CESAR *****");
        Console.Write("Ingresa la frase: ");
        string? phrase2 = Console.ReadLine(); // Permitir null
        if (string.IsNullOrEmpty(phrase2))
        {
            Console.WriteLine("Frase no puede ser vacía o nula.");
            return;
        }
        Console.Write("\nIngresa el desplazamiento: ");
        if (!int.TryParse(Console.ReadLine(), out int displacement2))
        {
            Console.WriteLine("Invalid displacement value.");
            return;
        }
        Console.WriteLine("\nFrase decifrada: ");
        Console.WriteLine(Mathematics.Decifrado(phrase2, displacement2));
        break;

    case 3:
        Console.WriteLine("\n***** CIFRADO CESAR *****\n");
        Console.Write("Ingresa la frase: ");
        string? phraseAuto = Console.ReadLine(); // Permitir null
        if (string.IsNullOrEmpty(phraseAuto))
        {
            Console.WriteLine("Frase no puede ser vacía o nula.");
            return;
        }
        Console.Write("\nIngresa el desplazamiento: ");
        if (!int.TryParse(Console.ReadLine(), out int displacementAuto))
        {
            Console.WriteLine("Invalid displacement value.");
            return;
        }
        Console.WriteLine("\nFrase cifrada: ");
        Console.WriteLine(Mathematics.CifradoAuto(phraseAuto, displacementAuto));
        Console.WriteLine("\n\n***** DECIFRADO CESAR *****");
        Console.Write("\nIngresa el desplazamiento: ");
        if (!int.TryParse(Console.ReadLine(), out int displacement3))
        {
            Console.WriteLine("Invalid displacement value.");
            return;
        }
        Console.WriteLine("\nFrase decifrada: ");
        Console.WriteLine(Mathematics.DecifradoAuto(displacement3));
        break;

    default:
        Console.WriteLine("Opcion no valida.");
        break;
}

