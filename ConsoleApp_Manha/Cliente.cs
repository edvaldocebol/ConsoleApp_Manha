using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manha
{
    public class Cliente
    {

        private string Telefone;
        private int Id;
        private string Name;

        public Cliente(string telefone, int id, string name)
        {
            Id = id;
            Telefone = telefone;
            Name = telefone;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public int getId()
        {
            return Id;
        }

        public string getName()
        {
            return Name;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public void steId(int id)
        {
            Id = id;
        }

        public void setName(string name)
        {
            Name = name;
        }
    }
}
