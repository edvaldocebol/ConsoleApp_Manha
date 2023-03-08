using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manha
{
    public class Pessoa
    {

        private string Telefone;
        private int Id;

        public Pessoa(string telefone, int id)
        {
            Id = id;
            Telefone = telefone;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public int getId()
        {
            return Id;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public void steId(int id)
        {
            Id = id;
        }
    }
}
