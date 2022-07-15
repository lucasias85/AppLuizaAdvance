using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLuizaAdvance.Models
{
    public class TaxasModel
    {
        [PrimaryKey, AutoIncrement]
        public int IdPromotora { get; set; }
        public string NomePromotora { get; set; }
        public decimal Parcela01 { get; set; }
        public decimal Parcela02 { get; set; }
        public decimal Parcela03 { get; set; }
        public decimal Parcela04 { get; set; }
        public decimal Parcela05 { get; set; }
        public decimal Parcela06 { get; set; }
        public decimal Parcela07 { get; set; }
        public decimal Parcela08 { get; set; }
        public decimal Parcela09 { get; set; }
        public decimal Parcela10 { get; set; }
        public decimal Parcela11 { get; set; }
        public decimal Parcela12 { get; set; }
    }
}
