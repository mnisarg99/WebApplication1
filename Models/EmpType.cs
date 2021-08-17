using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmpType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BatchId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class HRRepresentative
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ActualRecruiter
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class WorkingLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}