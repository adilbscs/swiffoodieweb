using SwiftFoodiee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwiftFoodiee.Controllers
{
    public class RiderProfileController : ApiController
    {

        public DBContext db = new DBContext();

        [HttpPost]
        public IHttpActionResult AddUsers(RiderProfile ObjUsers)
        {
            if (ObjUsers != null)
            {
                db.Rider.Add(ObjUsers);
                if (db.SaveChanges() == 1)
                {
                    return Ok("Saved");
                }
                else return Ok("Not Saved");
            }
            return Ok(" Not Saved");
        }

        [HttpGet]
        public IHttpActionResult GetUsers()
        {


            return Ok(db.Rider.ToList());

        }
    }
}
