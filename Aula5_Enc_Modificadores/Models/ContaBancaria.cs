using System;
using System.Collections.Generic;

public class ContaBancaria
{
	private double saldo;
	private List<string> transacoes;


	/*
	Em C#, eventos são uma forma de comunicação entre objetos que permite
	que um objeto (o publicador) notifique outros objetos (os assinantes)
	sobre a ocorrência de algo interessante.
	*/	
	public event EventHandler SaldoAlterado;
	public event EventHandler TransacaoRegistrada;

	public ContaBancaria(double saldoInicial)
	{
		saldo = saldoInicial;
		transacoes = new List<string>();
		RegistrarTransacao($"Saldo inicial: {saldoInicial}");
	}

	public void Depositar(double quantia)
	{
		if (quantia <= 0)
		{
			throw new ArgumentException("A quantia do depósito deve ser positiva.");
		}

		saldo += quantia;
		RegistrarTransacao($"Depositado: {quantia}");
		OnSaldoAlterado();
	}

	public void Sacar(double quantia)
	{
		if (quantia <= 0)
		{
			throw new ArgumentException("A quantia do saque deve ser positiva.");
		}

		if (saldo < quantia)
		{
			throw new InvalidOperationException("Saldo insuficiente para o saque.");
		}

		saldo -= quantia;
		RegistrarTransacao($"Sacado: {quantia}");
		OnSaldoAlterado();
	}

	public double ObterSaldo()
	{
		return saldo;
	}

	public IEnumerable<string> ObterTransacoes()
	{
		return transacoes.AsReadOnly();
	}

	protected virtual void OnSaldoAlterado()
	{
		SaldoAlterado?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnTransacaoRegistrada(string transacao)
	{
		TransacaoRegistrada?.Invoke(this, new TransacaoEventArgs(transacao));
	}

	private void RegistrarTransacao(string descricao)
	{
		transacoes.Add($"{DateTime.Now}: {descricao}");
		OnTransacaoRegistrada(descricao);
	}
}

public class TransacaoEventArgs : EventArgs
{
	public string Descricao { get; }

	public TransacaoEventArgs(string descricao)
	{
		Descricao = descricao;
	}
}
