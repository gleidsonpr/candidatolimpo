using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace candidatolimpo.Models
{
    public class Prefeito
    {

        /*classe prefeito com os atributos solicitados no enunciado do exercicio*/
        int id;
        string nome_canditado;

        string nome_urna_candidato;

        string sigla_partido;

        int idade_data_eleicao;
  
        string descricao_sexo;

        string descricao_grau_instrucao;

        string descricao_estado_civil;

        string descricao_cor_raca;

        public string Nome_canditado
        {
            get
            {
                return nome_canditado;
            }

            set
            {
                nome_canditado = value;
            }
        }

        public string Nome_urna_candidato
        {
            get
            {
                return nome_urna_candidato;
            }

            set
            {
                nome_urna_candidato = value;
            }
        }

        public string Sigla_partido
        {
            get
            {
                return sigla_partido;
            }

            set
            {
                sigla_partido = value;
            }
        }

        public int Idade_data_eleicao
        {
            get
            {
                return idade_data_eleicao;
            }

            set
            {
                idade_data_eleicao = value;
            }
        }

        public string Descricao_sexo
        {
            get
            {
                return descricao_sexo;
            }

            set
            {
                descricao_sexo = value;
            }
        }

        public string Descricao_grau_instrucao
        {
            get
            {
                return descricao_grau_instrucao;
            }

            set
            {
                descricao_grau_instrucao = value;
            }
        }

        public string Descricao_estado_civil
        {
            get
            {
                return descricao_estado_civil;
            }

            set
            {
                descricao_estado_civil = value;
            }
        }

        public string Descricao_cor_raca
        {
            get
            {
                return descricao_cor_raca;
            }

            set
            {
                descricao_cor_raca = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }


    }
}