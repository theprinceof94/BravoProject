using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BravoProject.Models
{
    public class Request
    {
        [Key]
        public string RequestID { get; set; }
        public DateTime RequestDate { get; set; }
        public int CurrentStage { get; set; }
        public string Comment { get; set; }

    }

    public Request(DateTime requestdate, int currentstate)
    {
        this.RequestDate = requestdate;
        this.CurrentStage = currentstate;
    }

    public Request()
    {

    }

    public static List<Request> AddNewRequest()
    {
        Request request = new Request();

    }

}