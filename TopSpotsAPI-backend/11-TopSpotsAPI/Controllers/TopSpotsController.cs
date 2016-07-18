using _11_TopSpotsAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace _11_TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<topspot> Get()
        {
            string topSpotString = File.ReadAllText(@"C:\Users\Ali\Documents\dev\11-TopSpotsAPI\app\topspots.json");
            topspot[] TopSpot = JsonConvert.DeserializeObject<topspot[]>(topSpotString);
            return TopSpot;
        }

        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TopSpots
        public void Post(HotSpot topSpot)
        {

        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
