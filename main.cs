using System;

/*
1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
*/

class MainClass {
  public static void Main (string[] args)  {
    
    Console.WriteLine("Digite dois numeros: ");
    double n1 = double.Parse(Console.ReadLine());
    double n2 = double.Parse(Console.ReadLine());

    Console.WriteLine();

    Console.Write("Digite\n * Multiplicação \n / Divisão \n - Subtração \n + Adição\n ");
    string cod = Console.ReadLine();

    Console.WriteLine();

    switch(cod)    
    {
      
      case "*":
      Console.WriteLine(n1*n2);
      break;

      case "/":
      Console.WriteLine(n1/n2);
      break;

      case "+":
      Console.WriteLine(n1+n2);
      break;

      case "-":
      Console.WriteLine(n1-n2);
      break;
    }
  }  
}