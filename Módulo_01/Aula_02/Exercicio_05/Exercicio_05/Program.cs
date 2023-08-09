/* 5- Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.*/

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