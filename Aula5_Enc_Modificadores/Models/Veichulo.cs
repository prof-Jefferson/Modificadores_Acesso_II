public class Veiculo
{
	protected int velocidade;

	public Veiculo()
	{
		velocidade = 0;
	}
}

public class Carro : Veiculo
{
	public void Acelerar()
	{
		velocidade += 10;
		Console.WriteLine("Velocidade atual do carro: " + velocidade + " km/h");
	}
}

/*
// Uso
var meuCarro = new Carro();
meuCarro.Acelerar();
*/


