using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.xpertgroup.matriz.Domain.DTO
{
    public class RequestUpdateDTO
    {


        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int Value { get; set; }

    }


    public class RequestQueryDTO
    {

        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Z1 { get; set; }
        public int X2 { get; set; }
        public int Y2{ get; set; }
        public int Z2 { get; set; }

    }


}
