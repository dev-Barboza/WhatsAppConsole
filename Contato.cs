namespace Whatsaap
{
    public class Contato
{
    public string NomeContato { get; set; }
    public string Telefone { get; set; }
    public Contato(string _nome , string _telefone)
    {
        this.NomeContato = _nome;
        this.Telefone = _telefone;
    }
}
}
