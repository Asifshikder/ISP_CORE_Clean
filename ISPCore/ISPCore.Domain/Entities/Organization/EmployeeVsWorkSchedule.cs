using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class EmployeeVsWorkSchedule : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int EmployeeVsWorkScheduleID { get; set; }
        public int Id { get; private set; }
        public int DayID { get; set; }
        public virtual Day Day { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int RunHour { get; set; }

        public int RunMinute { get; set; }
        public int BreakStartHour { get; set; }
        public int BreakStartMinute { get; set; }
        public int BreakEndHour { get; set; }
        public int BreakEndMinute { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employees { get; set; }
        public int Status { get; private set; }

        public EmployeeVsWorkSchedule() { }

        public EmployeeVsWorkSchedule(int dayID,int startHour , int startMinute ,int runHour,int runMinute, int breakStartHour ,
            int breakStartMinute ,int breakEndHour, int breakEndMinute ,int employeeID )
        {
            DayID= dayID;
            StartHour = startHour;
            StartMinute = startMinute;
            RunHour = runHour;
            RunMinute = runMinute;
            BreakStartHour = breakStartHour;
            BreakStartMinute = breakStartMinute;
            BreakEndMinute = breakEndMinute;
            BreakEndHour = breakEndHour;
            EmployeeID = employeeID;
        }

        public void UpdateEmployeeVsWorkSchedule(int dayID, int startHour, int startMinute, int runHour, int runMinute, int breakStartHour,
            int breakStartMinute, int breakEndHour, int breakEndMinute, int employeeID)
        {
            DayID = dayID;
            StartHour = startHour;
            StartMinute = startMinute;
            RunHour = runHour;
            RunMinute = runMinute;
            BreakStartHour = breakStartHour;
            BreakStartMinute = breakStartMinute;
            BreakEndMinute = breakEndMinute;
            BreakEndHour = breakEndHour;
            EmployeeID = employeeID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}