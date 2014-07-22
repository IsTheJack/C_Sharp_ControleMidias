using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMidias.BancoDeDados;

namespace ControleMidias.Classes
{
    class _Amigo
    {
        /// <summary>
        /// Esta classe representa a entidade amigo, fornecendo todas as operações necessárias
        /// para a manutenção dos dados da tabela 'Amigo' no banco de dados 'BancoControleMidia'. 
        /// </summary>

        #region Propriedades e Atributos
        // Atributos globais encapsulados
        private uint idAmigo;
        private string nome;
        private string apelido;
        private string celular;
        private string telefone;
        private string email;
        private string cidade;
        private string bairro;
        private string numeroCasa;
        private string nomePai;
        private string nomeMae;

        // Propriedades
        public uint IdAmigo
        {
            get { return idAmigo; }
            set { idAmigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string NumeroCasa
        {
            get { return numeroCasa; }
            set { numeroCasa = value; }
        }

        public string NomePai
        {
            get { return nomePai; }
            set { nomePai = value; }
        }

        public string NomeMae
        {
            get { return nomeMae; }
            set { nomeMae = value; }
        }
        #endregion

        #region CRUD completo das informações dos amigos
        // Método para salvar os dados
        public bool SalvarDados()
        {
            try
            {
                LinqControleMidiaDataContext dc = new LinqControleMidiaDataContext();

                Amigo amigo = new Amigo();
                amigo.Nome = nome;
                amigo.Apelido = apelido;
                amigo.Celular = celular;
                amigo.Telefone = telefone;
                amigo.Email = email;
                amigo.Cidade = cidade;
                amigo.Bairro = bairro;
                amigo.NumeroCasa = numeroCasa;
                amigo.NomePai = nomePai;
                amigo.NomeMae = nomeMae;
                dc.Amigos.InsertOnSubmit(amigo);
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

                var Pesquisa = from Amigo in dc.Amigos
                               where Amigo.IdAmigo == id
                               select Amigo;

                Amigo amigo = new Amigo();
                amigo = Pesquisa.Single();
                amigo.Nome = nome;
                amigo.Apelido = apelido;
                amigo.Celular = celular;
                amigo.Telefone = telefone;
                amigo.Email = email;
                amigo.Cidade = cidade;
                amigo.Bairro = bairro;
                amigo.NumeroCasa = numeroCasa;
                amigo.NomePai = nomePai;
                amigo.NomeMae = nomeMae;
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

                var Pesquisa = from Amigo in dc.Amigos
                               where Amigo.IdAmigo == id
                               select Amigo;

                Amigo amigo = new Amigo();
                amigo = Pesquisa.Single();
                dc.Amigos.DeleteOnSubmit(amigo);
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
        #endregion 
    }
}
