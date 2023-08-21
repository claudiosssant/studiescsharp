using System.ComponentModel.Design;

int num1, num2, resultado = 0;

string operacao;

Console.WriteLine("Informe o primeiro número");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a operação");
operacao = Console.ReadLine();

if(operacao == "+")
{
    resultado = num1 + num2;
}
else if(operacao == "-")
{
    resultado = num1 - num2;
}
else if(operacao == "*")
{
    resultado = num1 * num2;
}
else if(operacao == "/")
{
    resultado = num1 / num2;
}

Console.WriteLine(resultado);