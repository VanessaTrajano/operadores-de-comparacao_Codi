using System;

class Program {
  public static void Main (string[] args) {
    // Exercicio 1 ----------------------------------
    // Faça um programa que leia do teclado um valor real que represente a altura de uma pessoa, em seguida, faça uma comparação com a altura mínima exigida 1,50, atribua o resultado a uma variável lógica.
    float altura;
    bool alturaMinima;
    altura = Convert.ToSingle(Console.ReadLine());
    alturaMinima = altura >= 1.50;
    Console.WriteLine(alturaMinima);


    // Exercicio 2 ----------------------------------
    // Faça um programa que leia do teclado um valor inteiro correspondente a idade de um possível aluno da Codi Academy, depois faça uma comparação com a idade mínima necessária (14 anos) e atribua este resultado a uma variável lógica.
    int idade;
    idade = Convert.ToInt32(Console.ReadLine());
    bool estaNaIdadeMinima = idade >= 14;
    Console.WriteLine(estaNaIdadeMinima);
  }
}