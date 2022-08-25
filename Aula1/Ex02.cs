using System;

namespace Aula{

class Ex02{

        public static void Renderizar(){
        
        Console.WriteLine("Digite a sua idade: ");
        int idade = Int32.Parse(Console.ReadLine());

        if(idade <= 13){
            Console.WriteLine("Criança");
        }
        else if(idade <= 18){
            Console.WriteLine("Adolescente");
        }
        else if(idade > 18 && idade < 60){
            Console.WriteLine("Adulto");
        }
        else{
            Console.WriteLine("Idoso");

        }
        }
    }
}