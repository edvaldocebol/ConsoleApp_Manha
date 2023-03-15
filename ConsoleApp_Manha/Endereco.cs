using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manha
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string CEP;
        private string Bairro;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, string numero, string cep, string bairro, string cidade, string estado, string v)
        {
            Rua = rua;
            Numero = numero;
            CEP = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        
        public string getRua()
        {
            return Rua;
        }

        public string getNumero()
        {
            return Numero;
        }

        public string getCep()
        {
            return CEP;
        }

        public string getBairro()
        {
            return Bairro;
        }
        public string getCidade()
        {
            return Cidade;
        }
        public string getEstado()
        {
            return Estado;
        }
       
        public void setRua(string rua)
        {
            Rua = rua;
        }
        
        public void setNumero(string numero)
        {
            Numero = numero;
        }

        public void setCep(string cep)
        {
            CEP = cep;
        }

        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }

        public void setEstado(string estado)
        {
            Estado = estado;
        }
    }
}
