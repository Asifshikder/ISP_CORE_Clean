using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ActionNameAuthentication.Queries.Models
{
    public class ActionNameAuthenticationVM
    {
        public int Id { get; set; }
        public string ActionName { get; set; }
        public bool IsGranted { get; set; }
        public string ID { get; set; }
        public string Text { get; set; }
        public bool @Checked { get; set; }
        public int Status { get; private set; }
    }
}
