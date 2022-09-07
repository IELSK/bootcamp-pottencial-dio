int a = 10;
int b = 20;

int c = a + b;

// c = c + 5;
c += 5;

Console.WriteLine(c);


// Casting
// int d = Convert.ToInt32("5");
int d = int.Parse("5");

Console.WriteLine(d);

int integer = 5;
string e = integer.ToString();

Console.WriteLine(e);

string f = "15-";

int g = 0;

int.TryParse(f, out g);

int quantityInStock = 10;
int quantityToBuy = 4;
bool possibleSale = quantityToBuy > 0 && quantityInStock >= quantityToBuy;

Console.WriteLine($"Quantidade em estoque: {quantityInStock}");
Console.WriteLine($"Quantidade compra: {quantityToBuy}");
Console.WriteLine($"É possível realizar a venda? {possibleSale}");

if (quantityToBuy == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possibleSale)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}

Console.WriteLine("Digite uma letra");
string letter = Console.ReadLine();

switch (letter)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;
}