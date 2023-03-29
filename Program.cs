//Crie um programa para calcular o IMC de uma pessoa

//Algoritmo
//entrada: nome, peso, altura
//processamento: peso dividido por altura ao quadrado

//entrada

Console.WriteLine(@$"
:--------------------:
:   Programa para    :       
:   calcular o IMC   :        
:--------------------:
");


Console.Write ($"Informe o nome do paciente:");
string nome = Console.ReadLine();

Console.WriteLine ($"Seja bem vindo {nome} :)");


Console.Write ($"Informe o peso do paciente:");
float peso = float.Parse(Console.ReadLine());

// EXEMPLO
// Console.WriteLine($"Informe a altura do paciente:");
// double altura = double.Parse(Console.ReadLine());

Console.Write ($"Informe a altura do paciente:");
float altura = float.Parse(Console.ReadLine());

// PROCESSAMENTO

float imc = peso / ((float)Math.Pow(altura,2));

Console.Write ($"O IMC do paciente {nome} é {imc}");










