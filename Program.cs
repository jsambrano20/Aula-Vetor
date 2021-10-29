using System;

namespace AulaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] meuvetor = new int[100];
            //double[] meusegundovetor = new double[50];
            //char[] maisumvetor = new char[25];

            //int[] vetor;
            //int n, i;
            //Console.WriteLine("Digite um tamanho para o valor: ");
            //n = int.Parse(Console.ReadLine());
            //vetor = new int[n];
            //for (i = 0; i < n; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(vetor[i] + " ");
            //}

            //int[] n = new int[10];
            //int i;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.Write("Elemento " + (i+1) + " = ");
            //    n[i] = int.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine( n[i] + " ");
            //}

            //int[] vetor;
            //int n,i;
            //Console.WriteLine("Digite um tamanho para o vetor: ");
            //n = int.Parse(Console.ReadLine());
            //vetor = new int[n];
            //for (i = 0; i < n; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(" "+ vetor[i] = vetor[i] * 2 );
            //}


            //int[] n = new int[5];
            //int i,c=0;

            //for (i = 0; i < 5; i++)
            //{
            //    Console.Write("Elemento " + (i + 1) + " = ");
            //    n[i] = int.Parse(Console.ReadLine());

            //}
            //for (i = 0; i < 5; i++)
            //{
            //    if (n[i] % 2 == 0)
            //    {
            //        Console.WriteLine("par = " + n[i]);
            //        c++;
            //    }
            //}


            //int[] n = new int[10];
            //int i, impar = 0, par = 0;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.Write("Elemento " + (i + 1) + " = ");
            //    n[i] = int.Parse(Console.ReadLine());

            //}
            //for (i = 0; i < 10; i++)
            //{
            //    if (n[i] % 2 == 0)
            //    {
            //        Console.WriteLine("par = " + n[i]);
            //        par++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Impar = " + n[i]);
            //        impar++;
            //    }
            //    Console.WriteLine("o vetor possui " + par + "Elementos pares e " + impar + "Elementos impares");

            //}





            //int[] vetor = new int[10];

            //int i;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.Write("Elemento " + (i + 1) + " = ");
            //    vetor[i] = int.Parse(Console.ReadLine());

            //}
            //for (i = 9; i >= 0; i++)
            //{
            //    Console.Write(vetor[i]+ " ");
            //}

            //int[] v1 = new int[20];
            //int[] v2 = new int[20];
            //int[] v3 = new int[20];
            //int i;

            //for (i = 0; i < 20; i++)
            //{
            //    Console.Write("Elemento " + (i + 1) + " vetor 1 =  ");
            //    v1[i] = int.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < 20; i++)
            //{
            //    Console.Write("Elemento " + (i + 1) + " Vetor 2 =  ");
            //    v2[i] = int.Parse(Console.ReadLine());

            //}
            //for (i = 0; i < 20; i++)
            //{
            //    v3[i] = v1[i] + v2[i];
            //    Console.WriteLine("Elemento " + (i + 1) + "do novo vetor  = " + v3[i]);
            //}

            //double[] vetor = new double[30];
            //int[] v2 = new int[30];
            //int i, j=0;
            //for (i = 0; i < 5; i++)
            //{
            //    Console.Write("Elemento " + (i + 1) + " vetor =  ");
            //    vetor[i] = double.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < 5; i++)
            //{
            //    if (vetor[i] < 0)
            //    {
            //        v2[j] = i+1;
            //        j++;
            //        //Console.WriteLine(i + " ");
            //    }
            //    for (i = 0; i < j; i++)
            //    {
            //        Console.WriteLine(v2[i] + " ");
            //    }

            //}




            int[] n = new int[10];
            int[] j = new int[10];
            int i, impar = 0, par = 0;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Elemento " + (i + 1) + " = ");
                n[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                if (n[i] % 2 == 0)
                {
                    Console.WriteLine("par = " + n[i]);
                    par++;
                    par = j[i];
                }
                else
                {
                    Console.WriteLine("Impar = " + n[i]);
                    impar++;
                    impar = j[i];
                }

            }




            //Escreva um algoritmo que leia um vetor inteiro de 20 posições.
            //    Crie um segundo vetor, substituindo os valores nulos por 2
            //    .Mostre os vetores lidos e o vetor resultado.
        }
    }
}
