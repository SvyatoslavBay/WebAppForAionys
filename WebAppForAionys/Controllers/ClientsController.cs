using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAppForAionys.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppForAionys.Controllers
{
    [Route("api/[controller]")]
    public class ClientsController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Client> Get()
        {
            return DataService.clients;
        }

        // DELETE: api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Console.WriteLine("Try delete client task...");
            int count = 0;
            foreach (var client in DataService.clients)
            {
                count = client.ClientTasks.RemoveAll(x => x.Id == id);
                if (count == 1)
                {
                    Console.WriteLine("Client task was deleted, id = " + id);
                    return Ok(Json("Client task with id = " + id + " was deleted"));
                }
            }
            return NotFound();
        }
    }
}
