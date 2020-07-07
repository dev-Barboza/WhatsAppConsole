using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Whatsaap
{
    public class Agenda : IAgenda

    {
        List<Contato> contatos = new List<Contato>();
        
        /// <summary>
        /// Criar pasta PATH, caso ñ exista
        /// </summary>
        public Agenda()
        {
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);}
            
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
            
        }
        private const string PATH = "Database/contato.csv";
        
        /// <summary>
        /// Ajustar e organizar uma linha CSV
        /// </summary>
        /// <param name="cont"></param>
        public void Cadastrar(Contato cont)
        {
            string [] linhas = {PrepararLinhaCSV(cont)};
            File.AppendAllLines(PATH ,linhas);
        }

        /// <summary>
        /// retornar nome e telefone do contato
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private string PrepararLinhaCSV(Contato c)
        {
            return $"{c.NomeContato};{c.Telefone}";
        }

       /// <summary>
       /// excluirá contato indicado
       /// </summary>
       /// <param name="cont"></param>
        public void Excluir(Contato cont)
        {
             List<string> linhas = new List<string>();

            // ler.csv
            using(StreamReader arquivo = new StreamReader(PATH))
            {
                string linha;
                while((linha = arquivo.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }

            linhas.RemoveAll(x => x.Contains(cont.NomeContato));
            ReescreverCSV(linhas);
        }

        
        /// <summary>
        /// irá listar e add um contato
        /// </summary>
        /// <returns></returns>
        public List<Contato> Listar()
        {
           List<Contato> produtos = new List<Contato>();
            
            //arry de linhas 
            string[] linhas = File.ReadAllLines(PATH);

            //separar cada linha com split
            foreach(string linha in linhas)
            {
            string[] dado = linha.Split(";");

            //criar instancia para add na lista

            Contato c = new Contato(dado[0],dado[1]);

           
            
            contatos.Add(c);
            }

            contatos = contatos.OrderBy(y=> y.NomeContato).ToList();
            return contatos;
        }

        /// <summary>
        /// reescreer csv
        /// </summary>
        /// <param name="lines"></param>
        private void ReescreverCSV(List<string> lines){
            
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach(string ln in lines)
                {
                    output.Write(ln + "\n");
                }
            }   
        }
    }
}
