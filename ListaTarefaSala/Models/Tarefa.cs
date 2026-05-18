namespace ListaTarefaSala.Models;

public class Tarefa
{
    public string Titulo = "";
    public string Descricao = "";
    public bool Concluida;

    private string caminhoTarefa1 = "tarefa1.json";

    public void CadastrarTarefa(string titulo, string descricao)
    {
        Tarefa tarefa = new Tarefa();
        tarefa.Titulo = titulo;
        tarefa.Descricao = descricao;
        tarefa.Concluida = false;
    }
}

