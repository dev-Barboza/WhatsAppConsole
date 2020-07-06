namespace Whatsaap
{
    public interface IAgenda
    {
         void Cadastrar(string _Contato);

         void Excluir(string _Contato);

         void Listar();
    }
}