using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace candidatolimpo.Models
{
    public class PerfilEleitor
    {
        int? id;
        string sexo;
        string faixa_etaria;
        string grau_de_escolaridade;

        int? qtd_eletores_no_perfil;



        public int? Id
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


        public int? Qtd_eletores_no_perfil
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