using ListaTarefaSala.Models;

namespace ListaTarefaSala.Services;

public class TarefaService
{
    private Tarefa tarefa1 = new Tarefa();
  
    private string caminhoTarefa1 = "tarefa1.json";

    public void CadastrarTarefa(string titulo, string descricao)
    {
        Tarefa tarefa = new Tarefa();
        tarefa.Titulo = titulo;
        tarefa.Descricao = descricao;
        tarefa.Concluida = false;
    }
}

