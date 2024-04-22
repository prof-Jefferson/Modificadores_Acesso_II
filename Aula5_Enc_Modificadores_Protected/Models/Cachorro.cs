public class Cachorro : Animal
{
    public Cachorro(int idadeInicial) : base(idadeInicial) {}

    public override void ComemorarAniversario()
    {
        idade++;
        OnIdadeAlterada();
        Console.WriteLine("Cachorro comemora aniversário!");
    }

    public void Latir()
    {
        Console.WriteLine("Au au!");
    }
}
