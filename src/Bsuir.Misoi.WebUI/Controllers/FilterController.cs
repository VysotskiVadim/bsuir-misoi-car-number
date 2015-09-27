﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Bsuir.Misoi.WebUI.Controllers
{
    [Route("api/[controller]")]
    public class FilterController : Controller
    {
		[HttpGet]
        public string[] Names()
		{
			return new string[] { "name1", "name2" };
		}
    }
}