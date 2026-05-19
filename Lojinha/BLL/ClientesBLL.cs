using Lojinha.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.BLL
{
    public class ClientesBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //o nome do cliente é obrigatorio 
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Cliente é obrigatorio");
            }

            //retira os espaços antes do nome 
            cliente.Nome = cliente.Nome.Trim();
            //email é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            //se está tudo ok, chama a rotina de inserção
            ClientesDAL obj = new ClientesDAL();
            obj.Incluir(cliente);
        }
        public void Alterar(ClienteInformation cliente)
        {
            //o nome do cliente é obrigatorio 
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Cliente é obrigatorio");
            }
            //email é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            //se está tudo ok, chama a rotina de alteração
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);
        }
        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de excluir");
            }
            ClientesDAL obj = new ClientesDAL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem(string filtro)
        {
            ClientesDAL obj = new ClientesDAL();
            return obj.Listagem(filtro);
        }


    }
}
