namespace Whatsaap
{
    public class Mensagem
{
    public string  Texto { get; set; }
    public Contato Destinatario { get; set; }

    public string Enviar()
    {
        return $"Para {Destinatario.NomeContato} \n Mensagem{Texto}";
    }
}
}