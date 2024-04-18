// Classe derivada Cachorro
public class Cachorro : Animal
{
    // Construtor da classe Cachorro
    public Cachorro(int idadeInicial) : base(idadeInicial) {}

    // Método para fazer o cachorro "latir"
    public void Latir()
    {
        Console.WriteLine("Au au!");
    }

    // Método para "comemorar aniversário" e aumentar a idade
    public void ComemorarAniversario()
    {
        idade++;
    }
}