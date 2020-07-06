using System;

public class Contato
{
    public string Nome { get; set; }

    public int Telefone { get; set; }


     public Contato(){}

     public Contato(string Contato_Nome , int TelefoneContato)
     {
         this.Nome = Contato_Nome;
         this.Telefone = TelefoneContato;
     }
}