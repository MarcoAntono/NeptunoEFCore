using Microsoft.AspNetCore.Mvc;
using NeptunoEFCore.Models;
using NeptunoEFCore.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeptunoEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallePedidoController : ControllerBase
    {
         readonly DetallePedidoServices _servicesdetPedido = null;
        public DetallePedidoController(DetallePedidoServices servicesdetPedido)
        {
            this._servicesdetPedido = servicesdetPedido;
        }

        [HttpGet]
        public  async Task< ActionResult> Detallesdepedido() {             
            return Ok( await this._servicesdetPedido.GetAll());
        }

    }
}
