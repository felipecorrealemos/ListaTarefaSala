
using ListaTarefaSala.Models;

bool continuar = true;
Tarefa tarefa = new Tarefa();
tarefa.CarregarDoJson();

while (continuar)
{
    Console.Clear();
    Console.WriteLine("== Sistema de tarefas - Turma 3B ==");
    Console.WriteLine("1 - Cadastrar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Concluir tarefa");
    Console.WriteLine("4 - Remover tarefa");
    Console.WriteLine("0 - Sair");

    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        // Cadastrar tarefa
        Console.WriteLine("Digite o titulo da tarefa:");
        string titulo = Console.ReadLine();

        Console.WriteLine("Digite a descricao da tarefa:");
        string descricao = Console.ReadLine();

        Tarefa novaTarefa = new Tarefa();
        novaTarefa.CadastrarTarefa(titulo, descricao);

    }

    else if (opcao == "2")
    {
        //Listagem de tarefa
        tarefa.ListarTarefas();
    }


    
}