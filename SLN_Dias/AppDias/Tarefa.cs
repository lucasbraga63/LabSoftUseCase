namespace GestaoTarefas;

public class Tarefa
{
    public string Nome { get; set; } = string.Empty;
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string NomeFuncionario { get; set; } = string.Empty;

    public Tarefa(string nome, DateTime dataInicio, DateTime dataFim, string NomeFuncionarioResponsavel)
    {
        Nome = nome;
        DataInicio = dataInicio;
        DataFim = dataFim;
        NomeFuncionario = NomeFuncionarioResponsavel;

    }

    public int ObterQuantidadeDias()
    {
        return (DataFim - DataInicio).Days;
    }
}