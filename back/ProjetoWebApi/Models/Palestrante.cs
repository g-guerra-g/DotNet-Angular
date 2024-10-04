using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebApi.Models
{
    public class Palestrante
    {
        public int ID { get; set; }
        public string nomePalestrante { get; set; }
        public string temaPalestra { get; set; }
    }
}