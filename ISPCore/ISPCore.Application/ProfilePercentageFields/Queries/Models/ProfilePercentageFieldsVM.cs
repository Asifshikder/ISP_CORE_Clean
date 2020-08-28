using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ProfilePercentageFields.Queries.Models
{
    public class ProfilePercentageFieldsVM
    {
        public int Id { get; set; }
        public string FieldsName { get; set; }
        public string TableName { get; set; }
        public string MappingField { get; set; }
    }
}
