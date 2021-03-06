﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Form.Queries.Models
{
    public class FormVM
    {
        public int Id { get; set; }
        public int ControllerNameID { get; set; }
        public string FormName { get; set; }
        public string FormValue { get; set; }
        public string FormDescription { get; set; }
        public string FormLocation { get; set; }
    }
}
