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
        /// Esta classe representa a entidade amigo, fornecendo todas as operações necessárias
        /// para a manutenção dos dados da tabela 'Amigo' no banco de dados 'BancoControleMidia'. 
        /// </summary>

        // Atributos globais encapsulados
        //  Da mídia:
        private uint idMidia;
        private string nome;
        private string tipo;
        //  Do empréstimo:
        private uint idAmigo;
        private DateTime dataSaida;
        private DateTime dataPrevistaEntrega;
        private DateTime dataEfetivaEntrega;

        // Propriedades
        
        // Método para salvar os dados
        public bool AlterarDados()
        {
            try
            {
                LinqControleMidiaDataContext dc = new LinqControleMidiaDataContext();
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
        public bool AlterarDados(uint id)
        {
            try
            {
                LinqControleMidiaDataContext dc = new LinqControleMidiaDataContext();
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
