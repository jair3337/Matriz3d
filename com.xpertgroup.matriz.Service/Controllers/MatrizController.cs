using com.xpertgroup.matriz.Domain;
using com.xpertgroup.matriz.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace com.xpertgroup.matriz.Service.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MatrizController : AppServiceController
    {


        public static Matriz Matriz;

        public static int N;

        /// <summary>
        /// Inicializar la matriz
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [Route("Matriz/Init")]
        [HttpGet]
        public void InitMatriz(int n)
        {
            N = n;
            Matriz = new Matriz(n);
        }


        /// <summary>
        /// Actualizar un vector específico de la matriz a través del request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("Matriz/Update")]
        [HttpPost]
        public HttpResponseMessage Update([FromBody] RequestUpdateDTO request)
        {
            var res = MatrizDAL.Update(Matriz, request);
            return SetResult(res);
        }


        /// <summary>
        /// Consultar un rango de vectores específico a través del request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("Matriz/Query")]
        [HttpPost]
        public HttpResponseMessage Query([FromBody] RequestQueryDTO request)
        {
            var res = MatrizDAL.GetResult(Matriz, request, N);
            return SetResult(res);

        }






    }
}