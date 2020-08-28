using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class ProfilePercentageFields : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int ProfilePercentageFieldsID { get; set; }
        public int Id { get; private set; }
        public string FieldsName { get; set; }
        public string TableName { get; set; }
        public string MappingField { get; set; }
        public int Status { get; private set; }

        public ProfilePercentageFields() { }

        public ProfilePercentageFields(string fieldsName,string tableName,string mappingField)
        {
            FieldsName = fieldsName;
            TableName = tableName;
            MappingField = mappingField;
        }

        public void UpdateProfilePercentageFields(string fieldsName, string tableName, string mappingField)
        {
            FieldsName = fieldsName;
            TableName = tableName;
            MappingField = mappingField;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}