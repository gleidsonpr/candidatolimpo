using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace candidatolimpo.Models
{
    public class PerfilEleitor
    {
        int id;
        int periodo;
        string uf;
        string municipio;
        string sexo;
        string faixa_etaria;
        string grau_de_escolaridade;
        int cod_municipio_tse;
        int nr_zona;
        int qtd_eletores_no_perfil;

        public PerfilEleitor(int id, int periodo, string uf, string municipio, string sexo, string faixa_etaria, string grau_de_escolaridade, int cod_municipio_tse, int nr_zona, int qtd_eletores_no_perfil)
        {
            Id = id;
            Periodo = periodo;
            Uf = uf;
            Municipio = municipio;
            Sexo = sexo;
            Faixa_etaria = faixa_etaria;
            Grau_de_escolaridade = grau_de_escolaridade;
            Cod_municipio_tse = cod_municipio_tse;
            Nr_zona = nr_zona;
            Qtd_eletores_no_perfil = qtd_eletores_no_perfil;
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

        public int Periodo
        {
            get
            {
                return periodo;
            }

            set
            {
                periodo = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }

        public string Municipio
        {
            get
            {
                return municipio;
            }

            set
            {
                municipio = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Faixa_etaria
        {
            get
            {
                return faixa_etaria;
            }

            set
            {
                faixa_etaria = value;
            }
        }

        public string Grau_de_escolaridade
        {
            get
            {
                return grau_de_escolaridade;
            }

            set
            {
                grau_de_escolaridade = value;
            }
        }

        public int Cod_municipio_tse
        {
            get
            {
                return cod_municipio_tse;
            }

            set
            {
                cod_municipio_tse = value;
            }
        }

        public int Nr_zona
        {
            get
            {
                return nr_zona;
            }

            set
            {
                nr_zona = value;
            }
        }

        public int Qtd_eletores_no_perfil
        {
            get
            {
                return qtd_eletores_no_perfil;
            }

            set
            {
                qtd_eletores_no_perfil = value;
            }
        }
    }
    

}