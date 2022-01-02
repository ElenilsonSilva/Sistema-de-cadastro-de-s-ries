using Series.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            return "Genero do filme: "+this.Genero +"\n"+
                    "Titulo do filme: "+this.Titulo +"\n"+
                    "Descrição: "+this.Descricao + "\n"+
                    "Ano de lançamento: "+this.Ano;

        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }
        public int RetornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }


    }
}
