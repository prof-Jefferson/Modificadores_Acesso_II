namespace Aula5_Enc_Modificadores_Public;

class Program
{
    static void Main()
    {
        // Criar instâncias de Cachorro e Gato
        Cachorro meuCachorro = new Cachorro(5);
        Gato meuGato = new Gato(3);

        // Ações com o cachorro
        meuCachorro.Latir();
        meuCachorro.ExibirIdade();
        meuCachorro.ComemorarAniversario();
        meuCachorro.ExibirIdade();

        // Ações com o gato
        meuGato.Miar();
        meuGato.ExibirIdade();
        meuGato.ComemorarAniversario();
        meuGato.ExibirIdade();
    }
}
