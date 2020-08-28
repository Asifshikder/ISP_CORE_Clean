using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
   public class AttendanceType : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int AttendanceTypeID { get; set; }
        public int Id { get; private set; }
        public string AttendanceTypeName { get; set; }

        public int Status { get; private set; }

        public AttendanceType() { }

        public AttendanceType(string attendanceTypeName)
        {
            AttendanceTypeName = attendanceTypeName;
        }

        public void UpdateAttendanceType(string attendanceTypeName)
        {
            AttendanceTypeName = attendanceTypeName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
