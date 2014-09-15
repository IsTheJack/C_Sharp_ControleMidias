using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMidias.BancoDeDados;

namespace ControleMidias.Classes
{
    class _Midia
    {
        /// <summary>
        /// Esta classe representa a entidade mídia, fornecendo todas as operações necessárias
        /// para a manutenção dos dados da tabela 'Midia' no banco de dados 'BancoControleMidia'. 
        /// </summary>

        // Atributos globais encapsulados
        //  Da mídia:
        private uint idMidia;
        private string nome;
        private string tipo;

        // Propriedades
        public uint IdMidia
        {
            get { return idMidia; }
            set { idMidia = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        // Método para salvar os dados
        public bool SalvarDados()
        {
            try
            {
                LinqControleMidiaDataContext dc = new LinqControleMidiaDataContext();

                Midia midia = new Midia();
                midia.Nome = nome;
                midia.Tipo = tipo;
                dc.Midias.InsertOnSubmit(midia);
                dc.SubmitChanges();
                return true; // Retorna true caso a operação ocorra com sucesso
            }
            catch (Exception)
            {
                // Para obter detalhes da excessão (se ocorrer), pode-se tornar a linha abaixo um comentário
                return false; // Retorna false caso ocorra uma excessão na operação
                throw;
            }
        }

        // Método para alterar os dados
        public bool AlterarDados(uint id)
        {
            try
            {
                LinqControleMidiaDataContext dc = new LinqControleMidiaDataContext();

                var pesquisa = from Midia in dc.Midias
                               where Midia.IdMidia == id
                               select Midia;

                Midia midia = new Midia();
                midia = pesquisa.Single();
                midia.Nome = nome;
                midia.Tipo = tipo;
                dc.SubmitChanges();

                return true; // Retorna true caso a operação ocorra com sucesso
            }
            catch (Exception)
            {
                // Para obter detalhes da excessão (se ocorrer), pode-se tornar a linha abaixo um comentário
                return false; // Retorna false caso ocorra uma excessão na operação
                throw;
            }
        }

        // Método para excluir os dados
        public bool ExcluirDados(uint id)
        {
            try
            {
                LinqControleMidiaDataContext dc = new LinqControleMidiaDataContext();

                var pesquisa = from Midia in dc.Midias
                               where Midia.IdMidia == id
                               select Midia;

                Midia midia = new Midia();
                midia = pesquisa.Single();
                midia.Nome = nome;
                midia.Tipo = tipo;
                dc.Midias.DeleteOnSubmit(midia);
                dc.SubmitChanges();

                return true; // Retorna true caso a operação ocorra com sucesso
            }
            catch (Exception)
            {
                // Para obter detalhes da excessão (se ocorrer), pode-se tornar a linha abaixo um comentário
                return false; // Retorna false caso ocorra uma excessão na operação
                throw;
            }
        }
    }
}
