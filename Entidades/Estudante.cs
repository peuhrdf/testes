namespace Entidades;

public class Estudante
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }
    public string Matricula { get; private set; }

    public Estudante(string nome, int idade, string matricula)
    {
        Nome = nome;
        Idade = idade;
        Matricula = matricula;
    }
}