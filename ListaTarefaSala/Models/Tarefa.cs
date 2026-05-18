namespace ListaTarefaSala.Models;

using System.Text.Json;

public class Tarefa
{
    public string Titulo = "";
    public string Descricao = "";
    public bool Concluida;

    private string caminhoTarefa1 = "tarefa1.json";

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
}

