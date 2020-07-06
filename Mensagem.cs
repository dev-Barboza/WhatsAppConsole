using System;

public class Mensagem 
{
    public string Texto { get; set; }

    public Contato Destinatario;


    public void Enviar(Contato _Contato)
    {
        System.Console.WriteLine("Enviar mensagem para o contato " + _Contato.Nome);
        Texto = Console.ReadLine();

        System.Console.WriteLine("Mensagem enviada" + Texto + "foi enviada para "+ _Contato.Nome);
    }
}