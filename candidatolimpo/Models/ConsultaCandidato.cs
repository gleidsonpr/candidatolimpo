using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace candidatolimpo.Models
{
    public class ConsultaCandidato
    {
        int id;
        DateTime data_geracao;
        string hora_geracao;
        int ano_eleicao;
        int num_turno;
        string descricao_eleicao;
        string sigla_uf;
        int siglas_ue;
        string descricao_ue;
        int codigo_cargo;
        string descricao_cargo;
        string nome_canditado;
        string sequencial_canditado;
        string numero_candidato;
        string cpf_candidato;
        string nome_urna_candidato;
        int cod_situacao_candidatura;
        string des_situacao_candidatura;
        int numero_partido;
        string sigla_partido;
        string nome_partido;
        string codigo_legenda;
        string sigla_legenda;
        string composicao_legenda;
        string nome_legenda;
        int codigo_ocupacao;
        string descricao_ocupacao;
        DateTime data_nascimento;
        string num_titulo_eleitoral_candidato;
        int idade_data_eleicao;
        int codigo_sexo;
        string descricao_sexo;
        int cod_grau_instrucao;
        string descricao_grau_instrucao;
        int codigo_estado_civil;
        string descricao_estado_civil;
        int codigo_cor_raca;
        string descricao_cor_raca;
        int codigo_nacionalidade;
        string descricao_nacionalidade;
        string sigla_uf_nascimento;
        int codigo_municipio_nascimento;
        string nome_municipio_nascimento;
        double despesa_max_campanha;
        int cod_sit_tot_turno;
        string desc_sit_tot_turno;
        string nm_email;

        public ConsultaCandidato(int id, DateTime data_geracao, string hora_geracao, int ano_eleicao, int num_turno, string descricao_eleicao, string sigla_uf, int siglas_ue, string descricao_ue, int codigo_cargo, string descricao_cargo, string nome_canditado, string sequencial_canditado, string numero_candidato, string cpf_candidato, string nome_urna_candidato, int cod_situacao_candidatura, string des_situacao_candidatura, int numero_partido, string sigla_partido, string nome_partido, string codigo_legenda, string sigla_legenda, string composicao_legenda, string nome_legenda, int codigo_ocupacao, string descricao_ocupacao, DateTime data_nascimento, string num_titulo_eleitoral_candidato, int idade_data_eleicao, int codigo_sexo, string descricao_sexo, int cod_grau_instrucao, string descricao_grau_instrucao, int codigo_estado_civil, string descricao_estado_civil, int codigo_cor_raca, string descricao_cor_raca, int codigo_nacionalidade, string descricao_nacionalidade, string sigla_uf_nascimento, int codigo_municipio_nascimento, string nome_municipio_nascimento, double despesa_max_campanha, int cod_sit_tot_turno, string desc_sit_tot_turno, string nm_email)
        {
            Id = id;
            Data_geracao = data_geracao;
            Hora_geracao = hora_geracao;
            Ano_eleicao = ano_eleicao;
            Num_turno = num_turno;
            Descricao_eleicao = descricao_eleicao;
            Sigla_uf = sigla_uf;
            Siglas_ue = siglas_ue;
            Descricao_ue = descricao_ue;
            Codigo_cargo = codigo_cargo;
            Descricao_cargo = descricao_cargo;
            Nome_canditado = nome_canditado;
            Sequencial_canditado = sequencial_canditado;
            Numero_candidato = numero_candidato;
            Cpf_candidato = cpf_candidato;
            Nome_urna_candidato = nome_urna_candidato;
            Cod_situacao_candidatura = cod_situacao_candidatura;
            Des_situacao_candidatura = des_situacao_candidatura;
            Numero_partido = numero_partido;
            Sigla_partido = sigla_partido;
            Nome_partido = nome_partido;
            Codigo_legenda = codigo_legenda;
            Sigla_legenda = sigla_legenda;
            Composicao_legenda = composicao_legenda;
            Nome_legenda = nome_legenda;
            Codigo_ocupacao = codigo_ocupacao;
            Descricao_ocupacao = descricao_ocupacao;
            Data_nascimento = data_nascimento;
            Num_titulo_eleitoral_candidato = num_titulo_eleitoral_candidato;
            Idade_data_eleicao = idade_data_eleicao;
            Codigo_sexo = codigo_sexo;
            Descricao_sexo = descricao_sexo;
            Cod_grau_instrucao = cod_grau_instrucao;
            Descricao_grau_instrucao = descricao_grau_instrucao;
            Codigo_estado_civil = codigo_estado_civil;
            Descricao_estado_civil = descricao_estado_civil;
            Codigo_cor_raca = codigo_cor_raca;
            Descricao_cor_raca = descricao_cor_raca;
            Codigo_nacionalidade = codigo_nacionalidade;
            Descricao_nacionalidade = descricao_nacionalidade;
            Sigla_uf_nascimento = sigla_uf_nascimento;
            Codigo_municipio_nascimento = codigo_municipio_nascimento;
            Nome_municipio_nascimento = nome_municipio_nascimento;
            Despesa_max_campanha = despesa_max_campanha;
            Cod_sit_tot_turno = cod_sit_tot_turno;
            Desc_sit_tot_turno = desc_sit_tot_turno;
            Nm_email = nm_email;
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

        public DateTime Data_geracao
        {
            get
            {
                return data_geracao;
            }

            set
            {
                data_geracao = value;
            }
        }

        public string Hora_geracao
        {
            get
            {
                return hora_geracao;
            }

            set
            {
                hora_geracao = value;
            }
        }

        public int Ano_eleicao
        {
            get
            {
                return ano_eleicao;
            }

            set
            {
                ano_eleicao = value;
            }
        }

        public int Num_turno
        {
            get
            {
                return num_turno;
            }

            set
            {
                num_turno = value;
            }
        }

        public string Descricao_eleicao
        {
            get
            {
                return descricao_eleicao;
            }

            set
            {
                descricao_eleicao = value;
            }
        }

        public string Sigla_uf
        {
            get
            {
                return sigla_uf;
            }

            set
            {
                sigla_uf = value;
            }
        }

        public int Siglas_ue
        {
            get
            {
                return siglas_ue;
            }

            set
            {
                siglas_ue = value;
            }
        }

        public string Descricao_ue
        {
            get
            {
                return descricao_ue;
            }

            set
            {
                descricao_ue = value;
            }
        }

        public int Codigo_cargo
        {
            get
            {
                return codigo_cargo;
            }

            set
            {
                codigo_cargo = value;
            }
        }

        public string Descricao_cargo
        {
            get
            {
                return descricao_cargo;
            }

            set
            {
                descricao_cargo = value;
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

        public string Sequencial_canditado
        {
            get
            {
                return sequencial_canditado;
            }

            set
            {
                sequencial_canditado = value;
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

        public string Cpf_candidato
        {
            get
            {
                return cpf_candidato;
            }

            set
            {
                cpf_candidato = value;
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

        public int Cod_situacao_candidatura
        {
            get
            {
                return cod_situacao_candidatura;
            }

            set
            {
                cod_situacao_candidatura = value;
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

        public int Numero_partido
        {
            get
            {
                return numero_partido;
            }

            set
            {
                numero_partido = value;
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

        public string Nome_partido
        {
            get
            {
                return nome_partido;
            }

            set
            {
                nome_partido = value;
            }
        }

        public string Codigo_legenda
        {
            get
            {
                return codigo_legenda;
            }

            set
            {
                codigo_legenda = value;
            }
        }

        public string Sigla_legenda
        {
            get
            {
                return sigla_legenda;
            }

            set
            {
                sigla_legenda = value;
            }
        }

        public string Composicao_legenda
        {
            get
            {
                return composicao_legenda;
            }

            set
            {
                composicao_legenda = value;
            }
        }

        public string Nome_legenda
        {
            get
            {
                return nome_legenda;
            }

            set
            {
                nome_legenda = value;
            }
        }

        public int Codigo_ocupacao
        {
            get
            {
                return codigo_ocupacao;
            }

            set
            {
                codigo_ocupacao = value;
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

        public DateTime Data_nascimento
        {
            get
            {
                return data_nascimento;
            }

            set
            {
                data_nascimento = value;
            }
        }

        public string Num_titulo_eleitoral_candidato
        {
            get
            {
                return num_titulo_eleitoral_candidato;
            }

            set
            {
                num_titulo_eleitoral_candidato = value;
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

        public int Codigo_sexo
        {
            get
            {
                return codigo_sexo;
            }

            set
            {
                codigo_sexo = value;
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

        public int Cod_grau_instrucao
        {
            get
            {
                return cod_grau_instrucao;
            }

            set
            {
                cod_grau_instrucao = value;
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

        public int Codigo_estado_civil
        {
            get
            {
                return codigo_estado_civil;
            }

            set
            {
                codigo_estado_civil = value;
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

        public int Codigo_cor_raca
        {
            get
            {
                return codigo_cor_raca;
            }

            set
            {
                codigo_cor_raca = value;
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

        public int Codigo_nacionalidade
        {
            get
            {
                return codigo_nacionalidade;
            }

            set
            {
                codigo_nacionalidade = value;
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

        public string Sigla_uf_nascimento
        {
            get
            {
                return sigla_uf_nascimento;
            }

            set
            {
                sigla_uf_nascimento = value;
            }
        }

        public int Codigo_municipio_nascimento
        {
            get
            {
                return codigo_municipio_nascimento;
            }

            set
            {
                codigo_municipio_nascimento = value;
            }
        }

        public string Nome_municipio_nascimento
        {
            get
            {
                return nome_municipio_nascimento;
            }

            set
            {
                nome_municipio_nascimento = value;
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

        public int Cod_sit_tot_turno
        {
            get
            {
                return cod_sit_tot_turno;
            }

            set
            {
                cod_sit_tot_turno = value;
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

        public string Nm_email
        {
            get
            {
                return nm_email;
            }

            set
            {
                nm_email = value;
            }
        }
    }
}