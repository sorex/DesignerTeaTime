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
    
    public partial class Address
    {
        public string GUID { get; set; }
        public string UserID { get; set; }
        public string Consignee { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public bool IsDefault { get; set; }
    
        public virtual User User { get; set; }
    }
}
