using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    public class UserController : ApiController
    {
        private User[] users = new User[]
        {
            new User{id = 11, name = "Carla", email = "example@gmail.com", role = "admin", phone = 72633257 },
            new User{id = 12, name = "Oscar", email = "example2@gmail.com", role = "admin", phone = 72633222 }
        };

        // GET: api/User
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
