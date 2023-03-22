using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1

            //int quantidade, laranjas_compradas;
            //double preco, precototal;

            //Console.WriteLine("Quantas laranjas foram vendidas?");
            //quantidade = int.Parse(Console.ReadLine());

            //if (quantidade < 12) 
            //preco = quantidade *  0.35;

            //else
            //    preco = quantidade * 0.28;


            //Console.WriteLine("O valor da compra é: " + preco);


            //exercicio 2

            //int anonasc, idade;
            //Console.WriteLine("Digite seu ano de nascimento");
            //anonasc = int.Parse(Console.ReadLine());

            //idade = 2023 - anonasc;

            //if (idade >= 16)
            //    Console.WriteLine("Você pode votar nas proximas eleições! ");

            //else
            //    Console.WriteLine("Você não pode votar nas proximas eleicões! ");

            //Console.ReadKey();


            //exercicio 3 

            //double lado1, lado2, lado3;

            //Console.WriteLine("Digite a medida do primeiro lado do triangulo: ");
            //lado1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a medida do segundo lado do triangulo: ");
            //lado2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a medida do terceiro lado do triangulo: ");
            //lado3 = double.Parse(Console.ReadLine());

            //if (lado1 == lado2 && lado1 == lado3 && lado2==lado3 ) 
            //Console.WriteLine("O triangulo é equilatero.");

            //else if (lado1 < lado2 + lado3)  
            //Console.WriteLine("O triangulo é isosceles");

            //else
            //Console.WriteLine("O triangulo é escaleno");

            //Console.WriteLine("As medidas formam um triangulo ");
            //Console.ReadKey();


            //exercicio 4

            //int A, B, C, delta;

            //Console.WriteLine("Digite um numero para A, B, C: ");
            //A = int.Parse(Console.ReadLine());

            //B = int.Parse(Console.ReadLine());  

            //C = int.Parse(Console.ReadLine());

            //delta = B * B - 4 * A * C;

            //if (delta == 0)
            //    Console.WriteLine("Não tem raiz");

            //else if (delta > 0)
            //    Console.WriteLine("Tem raiz");

            //else                    
            //    Console.WriteLine("Tem duas raizes");

            //Console.ReadKey();


            //exercicio 5  

            //int num;
            //Console.WriteLine("Digite um numero");
            //num = int.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("O numero é divisivel por 3 e 5");
            //}
            //else
            //{
            //    if (num % 3 == 0)
            //    { Console.WriteLine("O numero é divisivel por 3 "); }

            //else
            //{
            //        if (num % 5 == 0)
            //        {
            //            Console.WriteLine("O numero é divisvel por 5");

            //        }
            //        else
            //        {
            //            Console.WriteLine("O numero não é divisivel nem po 3 nem por 5");

            //        }

            //        Console.ReadKey();


            //exercicio 6 

            //float ang1, ang2, ang3;

            //Console.WriteLine("Digite angulo 1 do seu triângulo: ");
            //ang1 = float.Parse(Console.ReadLine());  //Lê o numero

            //Console.WriteLine("Digite o angulo 2 do seu triângulo: ");
            // ang2 = float.Parse(Console.ReadLine());  //Lê o numero

            // Console.WriteLine("Digite o angulo 3 do seu triângulo: ");
            // ang3 = float.Parse(Console.ReadLine());  //Lê o numero

            // if ((ang1 == 90) || (ang2 == 90) || (ang3 == 90))
            //      Console.WriteLine("Seu triângulo é um triângulo retângulo ");

            // else if ((ang1 > 90) || (ang2 > 90) || (ang3 > 90))
            //    Console.WriteLine("Seu triângulo é um triângulo obtusângulo ");

            //  else
            //    Console.WriteLine("É um triângulo de três ângulos agudos");


            //  Console.ReadKey();


            //exercicio 7 

            //int a, b, c;

            // Console.WriteLine("qual o valor do numero ");
            //a = int.Parse(Console.ReadLine());

            // Console.WriteLine("qual o valor do numero ");
            // b = int.Parse(Console.ReadLine());

            //Console.WriteLine("qual o valor do numero ");
            // c = int.Parse(Console.ReadLine());

            //if (a < b && b < c) 
            //  Console.WriteLine(a +" "+ b+" " + c);

            // else if (a < b  && b > c)
            // Console.WriteLine(a + " " + c + " "+b);

            // else if (b < a  && a < c)
            // Console.WriteLine(b + " " + a + " "+c);

            //  else if (b < a  && a > c)
            // Console.WriteLine(b + " " + c + " "+a);

            // else if (c < a  && a < b)
            // Console.WriteLine(c + " " + a + " "+b);

            // else if (c < a  && a > c)
            // Console.WriteLine(c + " " + b + " "+a);

            //Console.ReadKey();


            //exercicio 8

            // int ano;

            // Console.WriteLine("digite um ano: ");
            // ano = int.Parse(Console.ReadLine());

            // if (ano % 4 == 0)
            // {
            //     Console.WriteLine("O ano é bissexto");
            // }
            // else
            // {
            //     Console.WriteLine("O ano não é bissexto");
            // }

            //Console.ReadKey();


            //exercicio 9 

            //double a, b, r;
            //char apli;

            // Console.WriteLine("escreve um valor para a: ");
            //  a = double.Parse(Console.ReadLine());
            // Console.WriteLine("escreve um valor para b: ");
            //   b = double.Parse(Console.ReadLine());
            // Console.WriteLine("escreve uma operação: ");
            //  apli = char.Parse(Console.ReadLine());

            // if (apli == '+')
            //  {
            //      Console.WriteLine(a + b);
            //  }
            //  else if (apli == '-')
            //  {
            //      Console.WriteLine(a - b);
            //  }
            //  else if (apli == '*')
            //  {
            //      Console.WriteLine(a * b);
            //  }
            //    else if (apli == '/')
            //    {
            //     Console.WriteLine(a / b);
            //    }

            //Console.ReadKey();


            //exercicio 10

            // Na linguagem C#, é possível gerar números aleatórios usando a classe Random. Esta classe permite gerar números inteiros e reais aleatórios usando diferentes métodos.
            // Para gerar números inteiros aleatórios em C#, basta criar uma instância da classe Random e chamar o método Next() da seguinte forma:

            // Aleatório random = new Random();
            // int randomInt = random.Next();

            // Para gerar números aleatórios reais em C#, é possível usar o método NextDouble(), que retorna um número aleatório entre 0 e 1, Se quiser gerar um número aleatório dentro de um intervalo específico, basta multiplicar o resultado pelo tamanho do intervalo e somar o valor mínimo

            // Aleatório random = new Random();
            // double randomDouble = Random.NextDouble();

            // Em ambos os casos, é importante criar uma única instância da classe Random e reutilizá-la para gerar números aleatórios diferentes. Isso porque, se você criar várias instâncias em sucessão rápida, elas podem gerar números semelhantes, tornando a distribuição menos aleatória.

            //Console.ReadKey();

















        }
    }
}


