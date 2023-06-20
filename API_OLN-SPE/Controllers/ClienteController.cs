using API_OLN_SPE.Data;
using API_OLN_SPE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace API_OLN_SPE.Controllers
{
  
    [ApiController]
    [Route("OLN_SPE")]
    public class ClienteController : ControllerBase
    {
       [HttpGet("Listar/{rut}")]
        //[Route("ListarNNA")]
       //public ClienteModel Get(string rut)
       // {
       //     return NNA.Getnna(rut);
       // }
        public List<nnaModel> Get(string rut)
        {
            return NnaData.ListNNA(rut);

        }
       
    }
    
}
 