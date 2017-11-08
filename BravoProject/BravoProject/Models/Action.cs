using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations.Schema;

namespace BravoProject.Models
{
    public class Action
    {
        [Key]
        public string ActionID { get; set; }
        [ForeignKey("RequestID")]
        public string RequesterID { get; set; }

        //AssigneeID isn't a thing yet.
        [ForeignKey("AssigneeID")]
        public string AssigneeID { get; set; }

        //StageID isn't a thing yet.
        /*[ForeignKey("StageID")]
         * public string StageID { get; set; }
         */
        public DateTime ActionDate { get; set; }
        public List<ActionType> ActionType { get; set; }
    }

    public Action()
    {
        this.ActionDate = DateTime.Now;
    }

    public Action()
    {
    }
}