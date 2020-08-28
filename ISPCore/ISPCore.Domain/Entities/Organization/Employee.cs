using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class Employee : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int EmployeeID { get; set; }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int? DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public int? RoleID { get; set; }
        public virtual Role Role { get; set; }
     
        public int? UserRightPermissionID { get; set; }
        public virtual UserRightPermission UserRightPermission { get; set; }
        public DateTime DOB { get; set; }
        public int DeviceID { get; set; }
        public int DutyShiftID { get; set; }
        public virtual DutyShift DutyShift { get; set; }
        public int Salary { get; set; }
        public int? EmployeeID { get; set; }
        public virtual Employee Employees { get; set; }
        public int BreakHour { get; set; }
        public int BreakMinute { get; set; }
        public string DutyShiftCombined { get; set; }
        public byte[] EmployeeOwnImageBytes { get; set; }
        public string EmployeeOwnImageBytesPaths { get; set; }
        public byte[] EmployeeNIDImageBytes { get; set; }
        public string EmployeeNIDImageBytesPaths { get; set; }
        public int? ResellerID { get; set; }
        public Reseller Reseller { get; set; }

        public int Status { get; private set; }

        public Employee() { }

        public Employee(string name,string loginName,string password,string phone, string address, string email,int? departmentID,int? roleID, int? userRightPermissionID,DateTime dOB, int deviceID, int dutyShiftID, 
            int salary, int? employeeID,int breakHour, int breakMinute, string dutyShiftCombind, byte[] employeeOwnImageBytes, string employeeOwnImageBytesPaths,byte[] employeeNIDImageBytes, string employeeNIDImageBytesPaths,
            int? resellerID
            )
        {
            Name = name;
            LoginName = loginName;
            Password = password;
            Phone = phone;
            Address = address;
            Email = email;
            DepartmentID = departmentID;
            RoleID = roleID;
            UserRightPermissionID = userRightPermissionID;
            DOB = dOB;
            DeviceID = deviceID;
            DutyShiftID = dutyShiftID;
            Salary = salary;
            EmployeeID = employeeID;
            BreakHour = breakHour;
            BreakMinute = breakMinute;
            DutyShiftCombined = dutyShiftCombind;
            EmployeeOwnImageBytes = employeeOwnImageBytes;
            EmployeeOwnImageBytesPaths = employeeOwnImageBytesPaths;
            EmployeeNIDImageBytes = employeeNIDImageBytes;
            EmployeeNIDImageBytesPaths = employeeNIDImageBytesPaths;
            ResellerID = resellerID;
        }

        public void UpdateEmployee(string name, string loginName, string password, string phone, string address, string email, int? departmentID, int? roleID, int? userRightPermissionID, DateTime dOB, int deviceID, int dutyShiftID,
            int salary, int? employeeID, int breakHour, int breakMinute, string dutyShiftCombind, byte[] employeeOwnImageBytes, string employeeOwnImageBytesPaths, byte[] employeeNIDImageBytes, string employeeNIDImageBytesPaths,
            int? resellerID
            )
        {
            Name = name;
            LoginName = loginName;
            Password = password;
            Phone = phone;
            Address = address;
            Email = email;
            DepartmentID = departmentID;
            RoleID = roleID;
            UserRightPermissionID = userRightPermissionID;
            DOB = dOB;
            DeviceID = deviceID;
            DutyShiftID = dutyShiftID;
            Salary = salary;
            EmployeeID = employeeID;
            BreakHour = breakHour;
            BreakMinute = breakMinute;
            DutyShiftCombined = dutyShiftCombind;
            EmployeeOwnImageBytes = employeeOwnImageBytes;
            EmployeeOwnImageBytesPaths = employeeOwnImageBytesPaths;
            EmployeeNIDImageBytes = employeeNIDImageBytes;
            EmployeeNIDImageBytesPaths = employeeNIDImageBytesPaths;
            ResellerID = resellerID;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}