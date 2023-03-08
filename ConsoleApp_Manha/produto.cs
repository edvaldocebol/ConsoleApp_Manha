using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manha
{
    internal class produto
    {
        private int Id;
        private string Descricao;
        private decimal Valor;

        public produto(int id, string descricao, decimal valor) {

            Id = id;
            Descricao = descricao;
            Valor = valor;

        }

        public string getDescricao()
        {
            return Descricao;
        }

        public void setDescricao(string Descricaco)
        {
            Descricao = Descricaco;
        }

        public void setValor(decimal valor)
        {
            Valor = valor;
        }

        public decimal getValor()
        {
            return Valor;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            if (id > 0)
            {
                Id = id;
            }
        }
    }

   
}
