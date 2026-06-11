void Separador()
{ 
Console.WriteLine("\n────────────────────────────────────────────────\n");
}

void Titulo(string titulo)
{
    Console.WriteLine();
    Console.WriteLine($"\n┌──────────────{titulo}──────────────┐\n");
    Console.WriteLine();
}


Separador();

Titulo("Apresentação Pessoal");

String nomePessoa = "Larissa Victoria";
Console.WriteLine("Nome: " + nomePessoa);
int idade = 25;
Console.WriteLine($"Idade: {idade}");
var cidade = "Rio de Janeiro";
Console.WriteLine("Cidade: " + cidade);
var profissao = "Desenvolvedora Backend";
Console.WriteLine("Profissão dos sonhos: " + profissao);

Separador();

Titulo("Cadastro de Produto");

var nomeDoProduto = "Teclado Mecânico";
Console.WriteLine($"Produto: {nomeDoProduto}");
decimal preco = 19.90m;
Console.WriteLine($"Preço: R$ {preco}");
int quantidadeEmEstoque = 15;
Console.WriteLine($"Quantidade: {quantidadeEmEstoque}");

Separador();

Titulo("Calculadora Simples");


var numero1 = 10;
var numero2 = 5;
var soma = numero1 + numero2;
Console.WriteLine($" *SOMA*            {numero1} + {numero2} = {soma}");
var subtracao = numero1 - numero2;
Console.WriteLine($" *SUBTRAÇÃO*       {numero1} - {numero2} = {subtracao}");
var divisao = numero1 / numero2;
Console.WriteLine($" *DIVISÃO*         {numero1} / {numero2} = {divisao}");
var multiplicacao = numero1 * numero2;
Console.WriteLine($" *MULTIPLICAÇÃO*       {numero1} * {numero2} = {multiplicacao}");

Separador();

Titulo("VERIFICADOR DE IDADE");

Console.WriteLine("Digite sua idade: ");
string? entradaIdade = Console.ReadLine();
int idade2 = int.Parse( entradaIdade!);

bool maiorIdade = idade2 >= 18;

if (maiorIdade)
{
    Console.WriteLine("Você é maior de idade!");
}
else
{
    Console.WriteLine("Você é menor de idade!");
}

Separador();

Titulo("PRIMEIRA FUNÇÃO");

string ExibirMensagem()
{
    return ("Estou aprendendo C# e criando minhas primeiras funções");
}

string texto = ExibirMensagem();
Console.WriteLine(texto);


Separador();

Titulo("CALCULAR MEDIA");

double nota1 = 8;
double nota2 = 7;
double nota3 = 9;

Console.WriteLine($"Primeira nota: {nota1}");
Console.WriteLine($"Segunda nota: {nota2}");
Console.WriteLine($"Terceira nota: {nota3}");

double CalcularMedia(double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3) / 3;

}

double media = CalcularMedia(nota1, nota2, nota3);

Console.WriteLine($"Média final: {media}");

Separador();
