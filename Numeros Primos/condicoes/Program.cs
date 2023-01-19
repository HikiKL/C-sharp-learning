// Esse é só um programa simples pra decidir se um número é primo ou não.

Console.WriteLine("Digite um número.");

int numero;  
/* Estou declarando uma variável antes de usa-la em loops já que 
   variáveis são usadas somente dentro do seu escopo, ou seja, as variáveis usadas
   dentro do while serão válidas somente no escobo de while.
   Nesse caso o while permite apenas que eu altere o valor de uma variável já definida. */

/* Abaixo um loop while onde eu usei como argumento um método TryParse, ele devolve um valor booleano
 * onde continua resultando em false caso eu não insira um valor corresponde ao declarado que no caso é um
 * inteiro - int.TryParse -, quando a condição for satisfeita o valor será armazenado na variável numero
 * atravez da sintaxe - ,out numero -)
 * 
 * Eu tive que por um operador de negação ( ! ) pra inverter a lógica já que se o usuário digitasse
 * algo que não fosse um inteiro, o loop não aconteceria já que o while só funciona em condições
 * onde os argumentos sejam True.
 */

while (!(int.TryParse(Console.ReadLine(), out numero )))  
{                                                        
Console.Clear();                                //O comando de limpar a tela.
Console.WriteLine("Digite um valor correto");    
}
Console.Clear();
Console.WriteLine($"Você digitou {numero}");

/* Abaixo um operador ternário, ele é uma forma simplificada de um if-else pra ser usado quando os argumento não 
 * são tão complexos.
 * A sintaxe é a seguinte:
 * 
 * condição ? resultado True : resultado False;
 * 
 * Após isso dependendo da condição o valor de True ou False será a resposta. */

string Resultado = numero % 2 == 0 ? $"{numero} É um número primo " : $"{numero} Não é um número primo";
Console.WriteLine(Resultado);


