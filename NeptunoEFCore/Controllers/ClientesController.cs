using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeptunoEFCore.Servicio;

namespace NeptunoEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        readonly ClientesServices _services = null;
        public ClientesController(ClientesServices services)
        {
            this._services = services;
        }
        //http://localhost:1306/api/Clientes/Listapedidos
        [HttpGet("Listapedidos")]
        //[HttpGet]
        public ActionResult Listapedidos() {
           return Ok( this._services.GetAll());
        }

        //[HttpGet("{pais}" , Name = "ListaClientePais")]
        //http://localhost:1306/api/Clientes/Alemania
        [HttpGet("{pais}")]
        public ActionResult ListaClientePais(String pais)
        {
            if (pais == null) {
                return NotFound();
            }
            return Ok(this._services.GetFindPais(pais));
        }
        //http://localhost:1306/api/Clientes/ListaPaisCount
        [HttpGet("ListaPaisCount")]
        public ActionResult ListaPaisCount()
        {         
            return Ok(this._services.GetCountPais());
        }
    }
}
