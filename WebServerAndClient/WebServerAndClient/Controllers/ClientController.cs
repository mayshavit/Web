using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebServerAndClient;
using WebServerAndClient.Models;

namespace WebServerAndClient.Controllers
{
    [Route("api/Client")]
    public class ClientController : ApiController
    {
        private WebServerAndClientContext db = new WebServerAndClientContext();

        // GET: api/Client
        [HttpGet]
        public string /*IQueryable<ClientModel>*/ GetClientModels()
        {
            return "yossi is efes";
            //return db.Clients;
        }

        // GET: api/Client/5
        [ResponseType(typeof(ClientModel))]
        public IHttpActionResult GetClientModel(int id)
        {
            ClientModel clientModel = db.Clients.Find(id);
            if (clientModel == null)
            {
                return NotFound();
            }

            return Ok(clientModel);
        }

        // PUT: api/Client/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClientModel(int id, ClientModel clientModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientModel.ID)
            {
                return BadRequest();
            }

            db.Entry(clientModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Client
        [ResponseType(typeof(ClientModel))]
        public IHttpActionResult PostClientModel(ClientModel clientModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            db.Clients.Add(clientModel);
            db.SaveChanges();
            /*if (db.Clients.Count() == 1)
            {
                clientModel.ID = 0;
            }*/
            return CreatedAtRoute("DefaultApi", new { id = clientModel.ID }, clientModel);
        }

        // DELETE: api/Client/5
        [ResponseType(typeof(ClientModel))]
        public IHttpActionResult DeleteClientModel(int id)
        {
            ClientModel clientModel = db.Clients.Find(id);
            if (clientModel == null)
            {
                return NotFound();
            }

            db.Clients.Remove(clientModel);
            db.SaveChanges();

            return Ok(clientModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientModelExists(int id)
        {
            return db.Clients.Count(e => e.ID == id) > 0;
        }
    }
}