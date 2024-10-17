using System;

namespace Alisson.Models;

public class Folha
{
    public int Id { get; set; }
    public double Valor { get; set; }
    public double Quantidade { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public double SalarioBruto { get; set; }
    public double ImpostoIrrf { get; set; }
    public double ImpostoInns { get; set; }
    public double ImpostoFgts { get; set; }
    public double SalarioLiquido { get; set; }
    public Funcionario Funcionario { get; set; }
    public int FuncionarioId { get; set; }

    public Folha(){
    }

    public Folha(int valor, int quantidade, int mes, int ano, int funcionarioId, Funcionario funcionario) {
    Valor = valor;
    Quantidade = quantidade;
    Mes = mes;
    Ano = ano;
    FuncionarioId = funcionarioId;
    Funcionario = funcionario;
 }
}
