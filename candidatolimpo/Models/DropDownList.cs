using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace candidatolimpo.Models
{
    public class DropDownList
    {
        //classe com as siglas dos estados para preencher o dropdown 

        public class Uf
        {
            public int UfId { get; set; }
            public string Nome { get; set; }

            public static List<Uf> ListaUfs()
            {
                return new List<Uf>
            {
                new Uf { UfId = 1, Nome = "AC"},
                new Uf { UfId = 2, Nome = "AL"},
                new Uf { UfId = 3, Nome = "AP"},
                new Uf { UfId = 4, Nome = "AM"},
                new Uf { UfId = 5, Nome = "BA"},
                new Uf { UfId = 6, Nome = "CE"},
                new Uf { UfId = 7, Nome = "DF"},
                new Uf { UfId = 8, Nome = "ES"},
                new Uf { UfId = 9, Nome = "GO"},
                new Uf { UfId = 10, Nome = "MA"},
                new Uf { UfId = 11, Nome = "MT"},
                new Uf { UfId = 12, Nome = "MS"},
                new Uf { UfId = 13, Nome = "MG"},
                new Uf { UfId = 14, Nome = "PA"},
                new Uf { UfId = 15, Nome = "PB"},
                new Uf { UfId = 16, Nome = "PR"},
                new Uf { UfId = 17, Nome = "PE"},
                new Uf { UfId = 18, Nome = "PI"},
                new Uf { UfId = 19, Nome = "RJ"},
                new Uf { UfId = 20, Nome = "RN"},
                new Uf { UfId = 21, Nome = "RS"},
                new Uf { UfId = 22, Nome = "RO"},
                new Uf { UfId = 23, Nome = "RR"},
                new Uf { UfId = 24, Nome = "SC"},
                new Uf { UfId = 25, Nome = "SP"},
                new Uf { UfId = 26, Nome = "SE"},
                new Uf { UfId = 27, Nome = "TO"},
               
            };
            }


            
        }
    }
}