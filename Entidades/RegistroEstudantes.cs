namespace Entidades;

public class RegistroEstudantes
{
    private List<Estudante> estudantes = new List<Estudante>();

    public void AdicionarEstudante(Estudante estudante)
    {
        estudantes.Add(estudante);
    }

    public bool RemoverEstudante(string matricula)
    {
        var estudante = estudantes.FirstOrDefault(e => e.Matricula == matricula);
        if (estudante != null)
        {
            estudantes.Remove(estudante);
            return true;
        }
        return false;
    }

    public List<Estudante> ListarEstudantes()
    {
        return estudantes.ToList();
    }
}
