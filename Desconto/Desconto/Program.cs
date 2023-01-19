// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quanto é o valor do produto que você quer comprar?");

int produto, desconto;

while(!(int.TryParse(Console.ReadLine(), out produto)))
{
    Console.WriteLine("Digite um número válido");
}

Console.WriteLine("Quanto é o desconto?");


while (!(int.TryParse(Console.ReadLine(), out desconto)))
{
    Console.WriteLine("Digite um número válido");
}

var Conta = produto * desconto / 100;
var Resultado = produto - Conta; 

Console.WriteLine($"O valor do produto de {produto} reais com {desconto}% de desconto é {Resultado} reais");

Console.ReadKey();


