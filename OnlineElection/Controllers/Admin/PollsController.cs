﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineElection.Controllers.Admin
{
    public class PollsController : Controller
    {
        // GET: Polls
        public ActionResult Index()
        {
            return View("~/ViewsAdmin/Polls/Index.cshtml");
        }

        public ActionResult CreatePoll()
        {
            return View("~/ViewsAdmin/Polls/CreatePoll.cshtml");
        }
    }
}