using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manha
{
    public class Cliente
    {

        private Endereco Endereco;
        private int Id;
        private string Telefone;
        private string Name;

        public Cliente(int id, string telefone, string name, Endereco endereco)
        {
            Id = id;
            Telefone = telefone;
            Name = telefone;
            Endereco = endereco;
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

        public Endereco getEndereco()
        {
            return Endereco;
        }

        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }
    }
}
