
using ListaTarefaSala.Models;

bool continuar = true;
Tarefa tarefa = new Tarefa();


while (continuar)
{
    tarefa.CarregarDoJson();
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

        //Tarefa novaTarefa = new Tarefa();
        tarefa.CadastrarTarefa(titulo, descricao);

    }

    else if (opcao == "2")
    {
        //Listagem de tarefa
        tarefa.ListarTarefas();
    }

    else if (opcao == "3")
    {
        //concluir tarefa
        Console.WriteLine("Digite a tarefa a ser concluida");
        int numero = int.Parse(Console.ReadLine());
        tarefa.ConcluirTarefa(numero);
    }

    else if(opcao == "4")
    {
        //Remover tarefa
        Console.WriteLine("Digite a tarefa a ser removida");
        int numero = int.Parse(Console.ReadLine());
        tarefa.RemoverTarefa(numero);
    }

    else if (opcao == "0")
    {
        continuar = false;
        Console.WriteLine("Programa encerrado.");
    }
}