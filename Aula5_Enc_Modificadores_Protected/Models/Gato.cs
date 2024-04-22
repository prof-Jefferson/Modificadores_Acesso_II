
public class Gato : Animal
{
    public Gato(int idadeInicial) : base(idadeInicial) {}

    public override void ComemorarAniversario()
    {
        idade++;
        OnIdadeAlterada();
        Console.WriteLine("Gato comemora aniversário!");
    }

    public void Miar()
    {
        Console.WriteLine("Miau!");
    }
}