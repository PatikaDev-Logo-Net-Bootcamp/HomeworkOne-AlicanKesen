using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOne.Models
{
    public class ResponseViewModel
    {
        public bool Success { get; set; }

        public String Error { get; set; }

        public String Data { get; set; }
    }
}
