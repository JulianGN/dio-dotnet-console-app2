using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Serie> // Implementa uma interface repositório de série
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            // listaSerie.RemoveAt(id); // Não indicado pois mudará a quantidade total de índices
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
            return listaSerie.Count; // 
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}