//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace J.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Addresses = new HashSet<Address>();
            this.DesignWorks = new HashSet<DesignWork>();
            this.Orders = new HashSet<Order>();
            this.SingleLogins = new HashSet<SingleLogin>();
        }
    
        public string GUID { get; set; }
        public string LoginName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string StageName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int State { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<DesignWork> DesignWorks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SingleLogin> SingleLogins { get; set; }
    }
}
