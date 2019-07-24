using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebStoreAPI.Domain;
using WebStoreAPI.Services;
using WebStoreAPI.Services.Interfaces;

namespace WebStoreAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServices _produtoServices;
        private readonly ILogger<ProdutoController> _logger;
        public ProdutoController(IProdutoServices produtoServices, ILogger<ProdutoController> logger)
        {
            _produtoServices = produtoServices;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            try
            {
                _logger.LogInformation("Received get request");

                return Ok(_produtoServices.List());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] Produto produto)
        {
            try
            {
                _logger.LogInformation("Received post request");

                _produtoServices.Add(produto);

                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
           
        }
    }
}