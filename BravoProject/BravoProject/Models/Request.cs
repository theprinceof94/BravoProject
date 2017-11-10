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
        public int RequestID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public string UserID { get; set; }
        public DateTime RequestDate { get; set; }
        public int CurrentStage { get; set; }
        public string Comment { get; set; }
        public List<User> AssigneeList { get; set; }
        //public List<Attachment> Attachments { get; set; }


        public Request(string requesterUserID,string comment,List<User> assigneeList/*,List<Attachment> attachmentsList*/)
        {
            this.RequestDate = DateTime.Now;
            this.CurrentStage = 1;

            this.UserID = requesterUserID;
            this.Comment = comment;
            this.AssigneeList = assigneeList;
            //this.Attachments = attachmentsList;
        }

        public Request()
        {

        }

        public static List<Request> PopulateRequests()
        {
            List<Request> requestList = new List<Request>();
            ApplicationDbContext db = new ApplicationDbContext();
            List<User> userList = db.Users.ToList<User>();
            //Attachment attachment = new Attachment("\\Mac\\Home\\Desktop\\Client Permission Form.pdf");

            List<User> assigneeList = new List<User>();
            User assignee1 = userList[1];
            assigneeList.Add(assignee1);

            Request req = new Request(userList[0].UserID,"Test Comment",assigneeList);
            requestList.Add(req);

            return requestList;
        }

    }


}