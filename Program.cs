using System;
using System.Collections.Generic;

namespace Whatsaap
{
    class Program
    {
        static void Main(string[] args)
        {
             Agenda agenda = new Agenda();
            
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Bem vindo ao WhatsApp,Todas as mensagens são criptografadas");
            Console.ResetColor();
            
            System.Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Red;
            Contato c1 = new Contato("Matheus","(11)94121561");
            Contato c2 = new Contato("Luan","(11)955212232");
            Contato c3 = new Contato("Raphael","(11)9454152");
            Console.ResetColor();

            agenda.Cadastrar(c1);
            agenda.Cadastrar(c2);
            agenda.Cadastrar(c3);

            agenda.Excluir(c2);

            List<Contato> list = new List<Contato>();
            list = agenda.Listar();

                foreach(Contato c in list)
                {
                    System.Console.WriteLine($"Nome : {c.NomeContato} - Tel : {c.Telefone}");
                }
            Mensagem msg = new Mensagem();
            msg.Destinatario = c3;
            msg.Texto = "Ola , Como você está nessa quarentena ?" + msg.Destinatario.NomeContato +  "!";
            System.Console.WriteLine(msg.Enviar());
        }
    }
}
