using CityInfo.API.Context;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/testdatabase")]
    public class DummyController : ControllerBase
    {
        private readonly CityInfoContext _ctx;

        public DummyController(CityInfoContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        [HttpGet]
        public ActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
