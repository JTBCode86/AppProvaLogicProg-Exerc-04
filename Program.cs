using System;

namespace AppProvaLogicProg_Exerc_04
{
    class Program
    {
        public static void CalcularEquacaoSegundoGrau(double A, double B, double C) 
        {
            double Delta=0;
            double raizDelta = 0;
            double aux =0;
            double X1;
            double X2;

            if (A==0)
            {
                Console.WriteLine("O valor de A, não pode ser igual a zero!");
            }
            else
            {
                 Delta = (Math.Pow(B, 2) - 4 * A * C);
                 raizDelta = Math.Sqrt(Delta);
                 aux = (2*A);
            }

            if (Delta < 0 || A==0)
            {
                Console.WriteLine("Impossivel calcular!");
            }
            else
            {
                X1 = ((-B + raizDelta) / aux);
                X2 = ((-B - raizDelta) / aux);

                Console.WriteLine($"O Valor de X linha é: {X1:0.00000}");
                Console.WriteLine($"O Valor de X duas linhas é:{X2:0.00000}");
            }
        }
        
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;

            Console.WriteLine("Entre com o valor de A:");
            A = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o valor de B:");
            B = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o valor de C:");
            C = double.Parse(Console.ReadLine());

            CalcularEquacaoSegundoGrau(A, B, C);
            Console.ReadLine();

        }
    }
}
