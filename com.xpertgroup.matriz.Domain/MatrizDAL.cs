using com.xpertgroup.matriz.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.xpertgroup.matriz.Domain
{
    public static class MatrizDAL
    {


        /// <summary>
        /// Generamos la actualización de un vector en una matriz dada
        /// </summary>
        /// <param name="myMatriz"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int Update(Matriz myMatriz, RequestUpdateDTO obj)
        {
            myMatriz.List.SetValue(obj.Value, obj.X, obj.Y, obj.Z);
            return obj.Value;
        }


        /// <summary>
        /// Obtenemos la suma en un rango de vectores
        /// </summary>
        /// <param name="myMatriz"></param>
        /// <param name="obj"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GetResult(Matriz myMatriz, RequestQueryDTO obj, int n)
        {
            int value = 0, a = 0, b = 0, c = 0;

            try
            {

                for (a = obj.X1; a < n; a++)
                {
                    for (b = obj.Y1; b < n; b++)
                    {
                        for (c = obj.Z1; c < n; c++)
                        {
                            value += myMatriz.List[a, b, c];

                            if (a == obj.X2 && b == obj.Y2 && c == obj.Z2)
                                return value;

                            if (c == n - 1)
                            {
                                obj.Z1 = 0;
                                break;
                            }
                        }
                        if (b == n - 1)
                        {
                            obj.Y1 = 0;
                            break;
                        }
                    }
                    if (a == n - 1)
                        obj.X1 = 0;
                }

            } catch (Exception exeption)
            {
                throw exeption;
            }

            return value;
        }
    }
}
