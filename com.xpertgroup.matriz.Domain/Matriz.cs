using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.xpertgroup.matriz.Domain
{
    public class Matriz
    {
        public int[,,] List { get; set; }

        public Matriz()
        {
            
        }

        public Matriz(int N)
        {
            List = new int[N, N, N];
        }


    }
}
