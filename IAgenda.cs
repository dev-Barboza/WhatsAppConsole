using System.Collections.Generic;

namespace Whatsaap
{
    public interface IAgenda
    {
         void Cadastrar(Contato cont);

         void Excluir(Contato cont);

         List<Contato> Listar();
    }
}