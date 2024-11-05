using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
				Console.WriteLine($"La suma es: {SumarNumeros(numeros)} ");
                //imprime 56
                Console.WriteLine($"La suma de numeros pares es: {sumaPares(numeros)}");
                //64
                Console.WriteLine($"La suma de numeros impares es: {sumaImpares(numeros)}");
                //numero random, en mi caso 67
                Console.WriteLine($"La suma de numeros random es: {sumaRandom()}");
			}
			catch (Exception ex)
			{

                Console.WriteLine($"Error {ex.ToString()}");
			}
        }

		static int sumaPares(List<int> numeros)
		{
			int sumapares = 0;
			foreach (var n in numeros)
			{
                //Primero n=2, la primer suma es 2
                //2da suma=4
                //3era suma=6
                //4ta suma=12
                //5ta suma= 20
                //6ta suma=30
                //7ma suma=42
                //8va suma=56
				if (n%2 ==0)
				{
					sumapares += n;
				}
				
			}
            return sumapares;
        }

        static int sumaImpares(List<int> numeros)
        {
            int sumaImpares = 0;
            foreach (var n in numeros)
            {
                if (!(n % 2 == 0))
                {
                    //inicializa suma=0 y n=1
                    //1,+3(4),+5(9),+7(16),+9(25),+11(36),+13(49),+15(64)
                    sumaImpares += n;
                }

            }
            return sumaImpares;
        }
        static int sumaRandom()
        {
            Random random = new Random();
            int suma = 0;
            for (int i = 0;i<10; i++)
            {
                //2,11,16,21,29,39,47,50,59,67,
                suma += random.Next(1,11);
            }
            return suma;
        }

        static int SumarNumeros(List<int> numeros)
		{
			//inicializo la suma a 0
			int suma = 0;
			//cicla en foreach por cada i en numeros
			foreach (int i in numeros)
			{
                //suma el valor de suma mas i
                //primera suma=0
                //segunda suma=1
                //tercera suma=3
                //cuarta suma=6
                //quinta suma=10
                //sexta suma=15
                //septima suma=21
                //8 suma=28
                //9 suma=36
				//10 suma=45
				//11 suma=55
                //12 =66
                //13=78
                //14=91
                //15=105
                //16=120


                suma += i;
			}
			return suma;
		}
    }
}
