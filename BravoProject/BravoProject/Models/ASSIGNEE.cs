using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace BravoProject.Models
{
    public class ASSIGNEE:ApplicationUser
    {
        [Key]
        public string ASSIGNEE_ID { get; set; }

        public string FullName { get; set; }

        public ASSIGNEE(string fullname):base(fullname)
        {
        }

        public ASSIGNEE()
        {
        }

        public static List<ASSIGNEE> PopulateAssignees()
        {
            List<ASSIGNEE> assigneeList = new List<ASSIGNEE>();
            ASSIGNEE Assignee = new ASSIGNEE("Liv Sartoris");
            assigneeList.Add(Assignee);

            Assignee = new ASSIGNEE("Erick Williams");
            assigneeList.Add(Assignee);

            Assignee = new ASSIGNEE("Cam Morris");
            assigneeList.Add(Assignee);

            Assignee = new ASSIGNEE("Jacob Spitale");
            assigneeList.Add(Assignee);

            return assigneeList;
        }

    }
}