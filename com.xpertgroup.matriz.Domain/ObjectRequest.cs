using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.xpertgroup.matriz.Domain
{
    public class ObjectRequest
    {
        [Display(Name = "Valor de N")]
        public int N { get; set; }
        [Display(Name = "Valor de M")]
        public int M { get; set; }
        [Display(Name = "Valor de consulta")]
        public List<int> QueyValue { get; set; }
        [Display(Name = "Rango1")]
        public List<int> vector1 { get; set; }
        [Display(Name = "Rango2")]
        public List<int> vector2 { get; set; }
        [Display(Name = "Valor")]
        public int Value { get; set; }
        [Display(Name = "Tipo de Consulta")]
        public int TypeQuery { get; set; }
        [Display(Name = "Total Consultas")]
        public int TotalQuerys { get; set; }
    }
}
