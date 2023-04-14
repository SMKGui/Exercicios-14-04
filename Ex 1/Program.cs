Console.WriteLine($"Em que ano nasceu? ");
int anoNasc = int.Parse(Console.ReadLine());

int anoAtual = DateTime.Now.Year;

if (anoAtual - anoNasc >= 16)
{
    Console.WriteLine($"Pode votar!");
}
else
{
    Console.WriteLine($"Nao pode votar!");
}