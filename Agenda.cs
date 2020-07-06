using System;
using System.IO;
using Whatsaap;

public class Agenda : IAgenda
    {
       public float ValorTotal;

       private const string PATH = "Database/contatos.csv";

        public Agenda(){
            
            string directory = PATH.Split('/')[0];

            if(!Directory.Exists(directory)){
                Directory.CreateDirectory(directory);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

    public void Cadastrar(string _Contato)
    {
        
    }

    public void Excluir(string _Contato)
    {
        
    }

    public void Listar()
    {
        
    }
}