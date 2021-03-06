﻿using Microsoft.AspNetCore.Identity;

namespace GUIEX2PROJECT.Models
{
    public enum EmployeeEnum
    {
        Admin,
        Waiter,
        Receptionist,
        Chef
    }
    public class Employee : IdentityUser
    {
        public string EmployeeId { get; set; }
        public EmployeeEnum EmployeeType { get; set; }
    }
}
