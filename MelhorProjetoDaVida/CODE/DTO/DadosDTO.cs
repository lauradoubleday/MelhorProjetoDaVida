using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorProjetoDaVida.CODE.DTO
{
    class DadosDTO
    {
        private int id;
        private string lhckd;
        private string l04;
        private string d05;

        public int Id { get => id; set => id = value; }
        public string Lhckd { get => lhckd; set => lhckd = value; }
        public string L04 { get => l04; set => l04 = value; }
        public string D05 { get => d05; set => d05 = value; }
    }
}