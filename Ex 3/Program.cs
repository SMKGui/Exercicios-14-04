// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

//algoritmo
//Qual o produto?
//Qual a quantia?
//Qual o preco unitario?
//Calcular e escrever total
//Qual o desconto adquirido?



Console.WriteLine(@$"Qual desses produtos deseja?
refri;
agua;
suco.");
string prod = Console.ReadLine();

double refri = 10.50;
double agua = 5.75;
double suco = 15;

Console.WriteLine($"Quantas unidades?");
int quant = int.Parse(Console.ReadLine());
double resultado = 0;

if (prod == "refri")
{
    resultado = refri * quant;
}

else if (prod == "agua")
{
    resultado = agua * quant;
}

else
{
    resultado = suco * quant;
}

if (quant <= 5)
{
    resultado = resultado - ((resultado / 100)  * 2);
    Console.WriteLine($"O valor sera: {resultado}");
}

else if (quant > 5 && quant <= 10)
{
    resultado = resultado - ((resultado / 100) * 3);
    Console.WriteLine($"O valor sera: {resultado}");
}

else 
{
    resultado = resultado - ((resultado / 100) * 3);
    Console.WriteLine($"O valor sera: {resultado}");
}

