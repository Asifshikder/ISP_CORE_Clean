using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Employee.Command
{
    public static class Commands
    {
        public static class Employee
        {
            public class Create : IRequest<EmployeeCommandVM>
            {
                public string Name { get; set; }
                public string LoginName { get; set; }
                public string Password { get; set; }
                public string Phone { get; set; }
                public string Address { get; set; }
                public string Email { get; set; }
                public int? DepartmentID { get; set; }
                public int? RoleID { get; set; }
                public int? UserRightPermissionID { get; set; }
                public DateTime DOB { get; set; }
                public int DeviceID { get; set; }
                public int DutyShiftID { get; set; }
                public int Salary { get; set; }
                public int? EmployeeID { get; set; }
                public int BreakHour { get; set; }
                public int BreakMinute { get; set; }
                public string DutyShiftCombined { get; set; }
                public byte[] EmployeeOwnImageBytes { get; set; }
                public string EmployeeOwnImageBytesPaths { get; set; }
                public byte[] EmployeeNIDImageBytes { get; set; }
                public string EmployeeNIDImageBytesPaths { get; set; }
                public int? ResellerID { get; set; }
            }

            public class Update : IRequest<EmployeeCommandVM>
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string LoginName { get; set; }
                public string Password { get; set; }
                public string Phone { get; set; }
                public string Address { get; set; }
                public string Email { get; set; }
                public int? DepartmentID { get; set; }
                public int? RoleID { get; set; }
                public int? UserRightPermissionID { get; set; }
                public DateTime DOB { get; set; }
                public int DeviceID { get; set; }
                public int DutyShiftID { get; set; }
                public int Salary { get; set; }
                public int? EmployeeID { get; set; }
                public int BreakHour { get; set; }
                public int BreakMinute { get; set; }
                public string DutyShiftCombined { get; set; }
                public byte[] EmployeeOwnImageBytes { get; set; }
                public string EmployeeOwnImageBytesPaths { get; set; }
                public byte[] EmployeeNIDImageBytes { get; set; }
                public string EmployeeNIDImageBytesPaths { get; set; }
                public int? ResellerID { get; set; }
            }

            public class MarkAsDelete : IRequest<EmployeeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
