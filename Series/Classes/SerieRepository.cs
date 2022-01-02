using Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series.Classes
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            listSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listSerie.Add(entidade);
        }

        public List<Serie> List()
        {
            return listSerie;
        }

        public List<Serie> list()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            return listSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listSerie[id];
        }
    }
}
