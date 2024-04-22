public abstract class Animal : IAnimal
{
    protected int idade;
    public event Action<string, int>? IdadeAlterada;

    public Animal(int idadeInicial)
    {
        idade = idadeInicial;
    }

    public virtual void ExibirIdade()
    {
        Console.WriteLine($"Idade do {this.GetType().Name.ToLower()}: {idade} anos.");
    }

    public abstract void ComemorarAniversario();

    protected void OnIdadeAlterada()
    {
        IdadeAlterada?.Invoke(this.GetType().Name, idade);
    }
}
