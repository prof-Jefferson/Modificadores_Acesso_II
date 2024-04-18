// Classe derivada Gato
public class Gato : Animal
{
    // Construtor da classe Gato
    public Gato(int idadeInicial) : base(idadeInicial) {}

    // Método para fazer o gato "miar"
    public void Miar()
    {
        Console.WriteLine("Miau!");
    }

    // Método para "comemorar aniversário" e aumentar a idade
    public void ComemorarAniversario()
    {
        idade++;
    }
}