namespace ListaTarefaSala.Models;

using System.Text.Json;
public class Tarefa
{
    public string Titulo = "";
    public string Descricao = "";
    public bool Concluida;

    private string caminhoTarefa1 = "tarefa1.json";
    private string caminhoTarefa2 = "tarefa2.json";
    
    public Tarefa tarefa1;
    public Tarefa tarefa2;

    private JsonSerializerOptions options = new JsonSerializerOptions()
    {
        WriteIndented = true,
        IncludeFields = true,
    };

    public void CadastrarTarefa(string titulo, string descricao)
    {
        Tarefa novaTarefa = new Tarefa();
        novaTarefa.Titulo = titulo;
        novaTarefa.Descricao = descricao;
        novaTarefa.Concluida = false;

        if (tarefa1 == null || tarefa1.Titulo == "")
        {
            string json = JsonSerializer.Serialize(novaTarefa, options);
            File.WriteAllText(caminhoTarefa1, json);

            Console.WriteLine("Tarefa 1 cadastrada com sucesso.");
            Console.ReadLine();
        }

        else if (tarefa2 == null || tarefa2.Titulo == "")
        {
            string json = JsonSerializer.Serialize(novaTarefa, options);
            File.WriteAllText(caminhoTarefa2, json);

            Console.WriteLine("Tarefa 2 cadastrada com sucesso.");
            Console.ReadLine();
        }

    }

    public void ListarTarefas()
    {
        if (tarefa1 == null || tarefa1.Titulo == "")
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
            Console.WriteLine("Status: " + status);
        }

        Console.WriteLine();

        if (tarefa2 == null || tarefa2.Titulo == "")
        {
            Console.WriteLine("Tarefa2: vazia");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Tarefa2:");
            Console.WriteLine("Titulo: " + tarefa2.Titulo);
            Console.WriteLine("Titulo: " + tarefa2.Descricao);
            string status;

            if (tarefa2.Concluida)
            {
                status = "Concluida";
            }

            else
            {
                status = "Pendente";
            }
            Console.WriteLine("Status: " + status);
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

        if (File.Exists(caminhoTarefa2))
        {
            string json = File.ReadAllText(caminhoTarefa2);
            tarefa2 = JsonSerializer.Deserialize<Tarefa>(json, options);
        }

        else
        {
            tarefa2 = null;
        }
    }

    public void ConcluirTarefa(int numero)
    {
        if (numero == 1)
        {
            tarefa1.Concluida = true;
            string json = JsonSerializer.Serialize(tarefa1, options);
            File.WriteAllText(caminhoTarefa1, json);

            Console.WriteLine("Tarefa 1 marcada como concluida.");
            Console.ReadLine();
        }

        else if (numero == 2)
        {
            tarefa2.Concluida = true;
            string json = JsonSerializer.Serialize(tarefa2, options);
            File.WriteAllText(caminhoTarefa2, json);

            Console.WriteLine("Tarefa 2 marcada como concluida.");
            Console.ReadLine();
        }

        else if (numero == 3)
        {

        }
    }
      
    public void RemoverTarefa(int numero)
    {
        if (numero == 1)
        {
            string json = JsonSerializer.Serialize(new Tarefa(), options);
            File.WriteAllText(caminhoTarefa1, json);

            Console.WriteLine("Tarefa 1 removida com sucesso.");
            Console.ReadLine();
        }

        else if (numero == 2)
        {
            string json = JsonSerializer.Serialize(new Tarefa(), options);
            File.WriteAllText(caminhoTarefa2, json);

            Console.WriteLine("Tarefa 2 removida com sucesso.");
            Console.ReadLine();
        }

        else if (numero == 3)
        {

        }
    }
}

