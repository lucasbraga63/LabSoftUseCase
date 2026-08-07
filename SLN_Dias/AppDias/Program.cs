using System;

namespace GestaoTarefas;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=================================");
        Console.WriteLine("   SISTEMA DE GESTÃO DE TAREFAS - Versão 1.1.0");
        Console.WriteLine("=================================\\n");

        Console.Write("Digite o nome da tarefa: ");
        string nome = Console.ReadLine() ?? "Sem nome";

        Console.Write("Digite a data de início (dd/mm/aaaa): ");
        string dataInicioStr = Console.ReadLine() ?? "";
        DateTime dataInicio = DateTime.Parse(dataInicioStr);

        Console.Write("Digite a data de término (dd/mm/aaaa): ");
        string dataFimStr = Console.ReadLine() ?? "";
        DateTime dataFim = DateTime.Parse(dataFimStr);

        Console.Write("Digite qual funcionário estará responsável por essa tarefa: ");
        string NomeFuncionarioResponsavel = Console.ReadLine();

        Tarefa tarefa = new Tarefa(nome, dataInicio, dataFim, NomeFuncionarioResponsavel);

        Console.WriteLine("\\n--- RESUMO DA TAREFA ---");
        Console.WriteLine($"Tarefa: {tarefa.Nome}");
        Console.WriteLine($"Início: {tarefa.DataInicio:dd/MM/yyyy}");
        Console.WriteLine($"Término: {tarefa.DataFim:dd/MM/yyyy}");
        Console.WriteLine($"Funcionário responsável: {tarefa.NomeFuncionario}");
        Console.WriteLine($"Duração: {tarefa.ObterQuantidadeDias()} dias");
    }
}