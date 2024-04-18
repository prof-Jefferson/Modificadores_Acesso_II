using System;

namespace Aula5_Enc_Modificadores;

class Program
{
	static void Main(string[] args)
	{
		// Cria uma nova conta bancária com um saldo inicial.
		ContaBancaria conta = new ContaBancaria(1000);

		// Inscreve os manipuladores de evento na conta.
		conta.SaldoAlterado += Conta_SaldoAlterado;
		conta.TransacaoRegistrada += Conta_TransacaoRegistrada;

		// Realiza algumas operações na conta.
		Console.WriteLine("Realizando operações na conta bancária:");
		
		try
		{
			conta.Depositar(500);
			conta.Sacar(200);
			conta.Sacar(50);
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Erro: {ex.Message}");
		}

		// Exibe todas as transações realizadas.
		Console.WriteLine("\nHistórico de Transações:");
		foreach (var transacao in conta.ObterTransacoes())
		{
			Console.WriteLine(transacao);
		}
	}

	// Manipulador de eventos para SaldoAlterado.
	private static void Conta_SaldoAlterado(object sender, EventArgs e)
	{
		Console.WriteLine("Notificação: O saldo da conta foi alterado.");
	}

	// Manipulador de eventos para TransacaoRegistrada.
	private static void Conta_TransacaoRegistrada(object sender, EventArgs e)
	{
		// Como sabemos que o sender é uma ContaBancaria, podemos converter e acessar suas propriedades.
		var conta = sender as ContaBancaria;
		Console.WriteLine($"Notificação: Uma nova transação foi registrada. Saldo atual: {conta.ObterSaldo()}");
	}
}

