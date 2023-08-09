int alcool = 0;
int gasolina = 0;
int diesel = 0;
bool escolha = true;

Console.WriteLine("Bem vindo!");

while (escolha)
{   Console.WriteLine("Escolha a opção desejada: \n 1 - Álcool \n 2 - Gasolina \n 3 - Diesel \n 4 - Sair");
string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            alcool += 1;
            break;

        case "2":
            gasolina += 1;
            break;

        case "3":
            diesel += 1;
            break;

        case "4":
            escolha = false;
            break;

        default:
            Console.WriteLine("Selecione uma opção válida. \n");
            break;
    }
}
Console.Clear();

Console.WriteLine("Muito Obrigado!");
Console.WriteLine($"Álcool: {alcool}");
Console.WriteLine($"Gasolina: {gasolina}");
Console.WriteLine($"Diesel: {diesel}");

Console.ReadKey();