using System;

namespace Aula
{
    class Ex01{

        public static void Renderizar(){
            
            Console.WriteLine("Digite a altura: ");
            int altura = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a largura: ");
            // Outra forma de converter, convert aceita todo tipo
            int largura = Convert.ToInt32(Console.ReadLine());

            int area = largura * altura;

            Console.WriteLine($"Área: {area} ");

        }

    }
}
    