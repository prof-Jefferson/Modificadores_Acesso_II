using System;

// Classe base Animal
public class Animal
{
    // Campo protegido idade
    protected int idade;

    // Construtor da classe base
    public Animal(int idadeInicial)
    {
        idade = idadeInicial;
    }

    // Método para exibir a idade
    public void ExibirIdade()
    {
        Console.WriteLine($"Idade do {this.GetType().Name.ToLower()}: {idade} anos.");
    }
}