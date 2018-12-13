using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AquaApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AquaApi.Controllers
{
    [Route("api/[controller]")]
    public class RybkaController : Controller
    {
        private IRybkaRepository repository;
        public RybkaController(IRybkaRepository repo) => repository = repo;
        [HttpGet]
        public IEnumerable<Rybki> Get() => repository.Rybki;

        [HttpGet("{id}")]
        public Rybki Get(int id) => repository[id];
    }
}
