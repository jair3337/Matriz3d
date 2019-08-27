using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace com.xpertgroup.matriz.Service.Controllers
{
    public class AppServiceController : ApiController
    {
        public HttpResponseMessage Result = new HttpResponseMessage();


        /// <summary>
        /// Establecemos una respuesta única y generica en el Controlador padre
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public HttpResponseMessage SetResult(object response)
        {

            try
            {
                // Podríamos validar los diferentes estado de respuesta aquí
                Result = Request.CreateResponse(
                    HttpStatusCode.OK, response
                );

            } catch(Exception exception)
            {
                Result.Headers.Add("Exception", exception.Message);
                Result = Request.CreateResponse(
                    HttpStatusCode.InternalServerError, 
                    response
                );
            }

            return Result;
        }

    }
}