using System;

namespace Alisson.Models;

public class Funcionario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }

    public Funcionario(){
    }
    public Funcionario(string nome, string cpf) {
    Nome = nome;
    Cpf = cpf;
  }
}
