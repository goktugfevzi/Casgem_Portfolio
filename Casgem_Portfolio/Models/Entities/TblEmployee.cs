//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Casgem_Portfolio.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblEmployee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurrname { get; set; }
        public string EmployeeCity { get; set; }
        public Nullable<decimal> EmployeeSalary { get; set; }
        public Nullable<int> EmployeeDepartment { get; set; }
    
        public virtual TblDepartment TblDepartment { get; set; }
    }
}
