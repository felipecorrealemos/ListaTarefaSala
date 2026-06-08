namespace ListaTarefaSala.Models;

using System.Text.Json;

public class Tarefa
{
    public string Titulo = "";
    public string Descricao = "";
    public bool Concluida;

    private string caminhoTarefa1 = "tarefa1.json";
    public Tarefa tarefa1;

    private JsonSerializerOptions options = new JsonSerializerOptions()
    {
        WriteIndented = true,
        IncludeFields = true,
    };

    //Tarefa tarefa1 = new Tarefa();

    public void CadastrarTarefa(string titulo, string descricao)
    {
        Tarefa novaTarefa = new Tarefa();
        novaTarefa.Titulo = titulo;
        novaTarefa.Descricao = descricao;
        novaTarefa.Concluida = false;

        //tarefa1 = novaTarefa;
        string json = JsonSerializer.Serialize(novaTarefa, options);
        File.WriteAllText(caminhoTarefa1, json);

        Console.WriteLine("");


    }

    public void ListarTarefas()
    {
        if (tarefa1 == null)
        {
            Console.WriteLine("Tarefa1: vazia");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Tarefa1:");
            Console.WriteLine("Titulo: " + tarefa1.Titulo);
            Console.WriteLine("Titulo: " + tarefa1.Descricao);
            string status;

            if (tarefa1.Concluida)
            {
                status = "Concluida";
            }

            else
            {
                status = "Pendente";
            }
        }

        Console.ReadLine();
    }

    public void CarregarDoJson()
    {
        if (File.Exists(caminhoTarefa1))
        {
            string json = File.ReadAllText(caminhoTarefa1);
            tarefa1 = JsonSerializer.Deserialize<Tarefa>(json, options);
        }

        else
        {
            tarefa1 = null;
        }
    }

    public void ConcluirTarefa(int numero)
    {
        if (numero == 1)
        {

        }

        else if (numero == 2)
        {

        }

        else if (numero == 3)
        {

        }
    }
      

}

