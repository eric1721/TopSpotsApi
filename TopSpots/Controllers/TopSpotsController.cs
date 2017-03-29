using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using TopSpots.Models;
using Newtonsoft.Json;

namespace TopSpots.Controllers
{
    public class TopSpotsController : ApiController
    { 
        [HttpGet, Route("api/topspots")]
        public IHttpActionResult GetTopSpots()
        {
            string topSpots = File.ReadAllText("C:\\dev\\TopSpots\\topspots.json");

            TopSpot[] topSpotsArray = JsonConvert.DeserializeObject<TopSpot[]>(topSpots);

            return Ok(topSpotsArray);
        }
    }
}
