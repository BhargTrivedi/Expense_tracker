//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public Nullable<int> Cust_Id { get; set; }
        public Nullable<int> Expense { get; set; }
        public string Category { get; set; }
        public string Desc { get; set; }
        public string Title { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}