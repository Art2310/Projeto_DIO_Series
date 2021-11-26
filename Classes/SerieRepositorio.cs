using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
/* A função desse arquivo é fazer o intermédio entre o programo e 
o nossso "banco de dados" em memória, isso deixa o nosso código mais 
organizado e facilita a manutenção dele caso queiramos por exemplo depois 
conectar a aplicação a um banco de dados ou colocar num arquivo texto*/
namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}