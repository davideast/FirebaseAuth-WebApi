﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirebaseAuth.Web.Controllers.Api
{
    public class AuthController : ApiController
    {
        // GET api/auth
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/auth/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/auth
        public void Post([FromBody]string value)
        {
            var s = "";
        }

        // PUT api/auth/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/auth/5
        public void Delete(int id)
        {
        }
    }
}
