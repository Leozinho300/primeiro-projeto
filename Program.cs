



using System;
using System.Net.Mail;
using System.Reflection;
bool continuar = true;

while (continuar)
{
     Console.Write("digite seu nome:  ");
     string name = Console.ReadLine();
     Console.WriteLine($"Ola {name}!");
     Console.Write("digite o ano do seu nascimento:");
     int ano = int.Parse(Console.ReadLine());
     int idade = 2022 - ano;
     Console.WriteLine($"você tem {idade} anos");

 if (idade >= 18)
 {
    Console.WriteLine("você eh maior de idade");
 }
 else if (idade < 18 && name == "leonardo")
 {
    Console.WriteLine("voçe eh menor de idade mais pode dirigir por ser o criador");
 }

 else
 {
    Console.WriteLine("você eh de menor");
    Console.WriteLine("voçê não pode dirigir");
 }

Console.WriteLine("vamos tentar mais uma vez ok ?");
Console.Write("digite 'sim' se deseja continuar ou 'nao' se deseja encerrar o programa: ");
string continuarresposta=Console.ReadLine();
 if (continuarresposta.ToLower() !="sim" )
 {
    continuar = false;
 } 

}
