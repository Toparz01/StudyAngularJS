﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TypeScriptHTMLApp1.Controllers
{
    public class Value
    {
        public string Text { get; set; }
    }

    public class ValuesController : ApiController
    {

        private static Value _Value { get; set; }

        public Value Get()
        {
            return _Value;
        }

        public HttpResponseMessage Post(Value value)
        {
            _Value = value;
            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}
