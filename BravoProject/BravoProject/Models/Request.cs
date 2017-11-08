using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations.Schema;

namespace BravoProject.Models
{
    public class Request
    {
        [Key]
        public string RequestID { get; set; }
        [ForeignKey("RequesterUserID")]
        public string RequesterUserID { get; set; }
        public DateTime RequestDate { get; set; }
        public int CurrentStage { get; set; }
        public string Comment { get; set; }
        public List<User> AssigneeList { get; set; }
        public List<Attachment> Attachments { get; set; }


        public Request()
        {
            this.RequestDate = DateTime.Now;
            this.CurrentStage = 1;
        }

        public Request()
        {

        }

        public static List<Request> PopulateRequests()
        {
            List<Request> requestList = new List<Request>();
            Attachment attachment = new Attachment("\\Mac\\Home\\Desktop\\Client Permission Form.pdf");

            Request req = new Request();
            requestList.Add(req);
        }

    }


}