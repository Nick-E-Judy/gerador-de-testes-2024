﻿namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Cadastrar(Disciplina novaDisciplina);
        bool Editar(int id, Disciplina disciplinaEditada);
        bool Excluir(int id);
        Disciplina SelecionarPorId(int idSelecionado);
        List<Disciplina> SelecionarTodos();
    }
}