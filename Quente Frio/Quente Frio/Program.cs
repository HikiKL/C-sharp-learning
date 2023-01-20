// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número entre 1 a 100 e tente acertar o número secreto");


int numero;
Random numeroSeed = new Random();

int numeroAleatorio = numeroSeed.Next(1, 100);
int seteErros = 0;

for (int chances = 1; chances <= 7; chances++){

    while (!(int.TryParse(Console.ReadLine(), out numero))) {

        Console.WriteLine("Digite um número válido");

    }

    if (numero == numeroAleatorio)
    {
        Console.WriteLine($"Parabens você acertou, o número é {numeroAleatorio}");
        break;
    }
    else if (numeroAleatorio > numero)
    {
        Console.WriteLine();
        Console.WriteLine($"O número secreto é maior que {numero}");
        Console.WriteLine();
        Console.WriteLine($"Você tem {7 - chances} chances");
        Console.WriteLine("-------------------------------");
        seteErros++;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"O número secreto é menor que {numero}");
        Console.WriteLine();
        Console.WriteLine($"Você tem {7 - chances} chances");
        Console.WriteLine("-------------------------------");
        seteErros++;
    }   

}

if(seteErros == 7){
    Console.Write("Você não tem mais chances.");
}

Console.WriteLine("Digite qualquer tecla para finalziar");
Console.ReadKey();



