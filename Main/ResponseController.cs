using Erguc.AutoResponse.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Erguc.AutoResponse.Main
{
    public class ResponseController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// It is a method that automates the status and error codes, returns them by creating a certain layout and template, and does this without the need to create a new object. All you have to do is pass the relevant parameters to the method. | Æ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
