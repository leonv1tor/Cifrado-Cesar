// See https://aka.ms/new-console-template for more information
using Cifrado;

  Console.WriteLine("\n***** CALCULADORA *****");
    double ancho;
    double largo;
    double radio;
    double horizontal;
    double alpha;

    Console.WriteLine("Calcular el volumen de una esfera\n");
    Console.WriteLine("Ingrese radio: ");
    radio = Convert.ToDouble(Console.ReadLine());
    double ans1 = Mathematics.Esfera(radio);
    Console.WriteLine($"El volumen es: {ans1}"); 

    Console.WriteLine("Calcular el area de un lote\n");
    Console.WriteLine("Ingrese el ancho: ");
    ancho = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el largo: ");
    largo = Convert.ToDouble(Console.ReadLine());
    double ans2 = Mathematics.Lote(ancho,largo);
    Console.WriteLine($"Son {ans2} kilometros"); 

    Console.WriteLine("Calcular la altura de un edificio\n");
    Console.WriteLine("Ingrese la distancia horizontal: ");
    horizontal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el grado: ");
    alpha = Convert.ToDouble(Console.ReadLine());
    double ans3 = Mathematics.Edificio(horizontal, alpha);
    Console.WriteLine($"La altura del edificio es: {ans3}"); 
