using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace candidatolimpo.Models
{
    public class Vereador
    {
        int id;        
        string nome_canditado;
        string numero_candidato;
        string des_situacao_candidatura;
        string sigla_partido;
        string descricao_ocupacao;
        int idade_data_eleicao;
        string descricao_sexo;
        string descricao_grau_instrucao;
        string descricao_estado_civil;
        string descricao_cor_raca;
        string descricao_nacionalidade;
        double despesa_max_campanha;
        string desc_sit_tot_turno;

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

        public string Numero_candidato
        {
            get
            {
                return numero_candidato;
            }

            set
            {
                numero_candidato = value;
            }
        }



        public string Des_situacao_candidatura
        {
            get
            {
                return des_situacao_candidatura;
            }

            set
            {
                des_situacao_candidatura = value;
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

        public string Descricao_ocupacao
        {
            get
            {
                return descricao_ocupacao;
            }

            set
            {
                descricao_ocupacao = value;
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

        public string Descricao_nacionalidade
        {
            get
            {
                return descricao_nacionalidade;
            }

            set
            {
                descricao_nacionalidade = value;
            }
        }



        public double Despesa_max_campanha
        {
            get
            {
                return despesa_max_campanha;
            }

            set
            {
                despesa_max_campanha = value;
            }
        }

        public string Desc_sit_tot_turno
        {
            get
            {
                return desc_sit_tot_turno;
            }

            set
            {
                desc_sit_tot_turno = value;
            }
        }


    }
}