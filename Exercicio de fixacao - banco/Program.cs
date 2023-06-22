using ExercicioDeFixacaoBanco;
using System.Globalization;
ContaBancaria cb;

Console.Write("Entre com o número da conta: ");
int account = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string name = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
Char initialdeposit = char.Parse(Console.ReadLine());



if (initialdeposit == 's' || initialdeposit == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    cb = new ContaBancaria(name, account, balance);
}
else
{
    cb = new ContaBancaria(name, account);
}



Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(cb);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
cb.AddBalance(deposit);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(cb);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
cb.WithDrawBalance(withdraw);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(cb);
