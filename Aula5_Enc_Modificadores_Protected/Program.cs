class Program
{
    static void Main()
    {
        // Criar instâncias de Cachorro e Gato
        Cachorro meuCachorro = new Cachorro(5);
        Gato meuGato = new Gato(3);

        // Inscrever um observador para o evento IdadeAlterada
        meuCachorro.IdadeAlterada += Animal_IdadeAlterada;
        meuGato.IdadeAlterada += Animal_IdadeAlterada;

        // Ações com o cachorro
        meuCachorro.Latir();
        meuCachorro.ExibirIdade();
        meuCachorro.ComemorarAniversario();

        // Ações com o gato
        meuGato.Miar();
        meuGato.ExibirIdade();
        meuGato.ComemorarAniversario();
    }

    // Método que responde ao evento IdadeAlterada
    private static void Animal_IdadeAlterada(string nome, int novaIdade)
    {
        Console.WriteLine($"A idade do {nome.ToLower()} foi alterada para {novaIdade} anos.");
    }
}