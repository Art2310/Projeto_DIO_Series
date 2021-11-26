using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
/* A função desse arquivo é fazer o intermédio entre o programo e 
o nossso "banco de dados" em memória, isso deixa o nosso código mais 
organizado e facilita a manutenção dele caso queiramos por exemplo depois 
conectar a aplicação a um banco de dados ou colocar num arquivo texto*/
namespace DIO.Series
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();
        public void Atualiza(int id, Filme objeto)
        {
            listaFilme[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Filme objeto)
        {
            listaFilme.Add(objeto);
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];
        }
    }
}