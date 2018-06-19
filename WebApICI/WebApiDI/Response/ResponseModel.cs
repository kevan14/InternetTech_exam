using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDI.Response
{
    public class ResponseModel
    {
        public string Status { get; set; }
        public object Data { get; set; }
    }
}
