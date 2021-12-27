using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesApi.Data
{
    public class Cliente    
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Razao { get; set; }
        public DateTime Inclusao { get; set; }
        public int Ativo { get; set; }

    }
}
