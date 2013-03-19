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
    
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public string GUID { get; set; }
        public string UserID { get; set; }
        public string DesignWorkID { get; set; }
        public int State { get; set; }
        public Nullable<int> RefundState { get; set; }
        public Nullable<System.DateTime> WaitBuyerPayTime { get; set; }
        public Nullable<System.DateTime> WaitSellerSendGoodsTime { get; set; }
        public Nullable<System.DateTime> WaitBuyerConfirmGoodsTime { get; set; }
        public Nullable<System.DateTime> TradeFinishedTime { get; set; }
        public Nullable<System.DateTime> TradeClosedTime { get; set; }
        public Nullable<System.DateTime> RefundWaitSellerAgreeTime { get; set; }
        public Nullable<System.DateTime> RefundSellerFefuseBuyerTime { get; set; }
        public Nullable<System.DateTime> RefundSuccessTime { get; set; }
        public Nullable<System.DateTime> RefundClosedTime { get; set; }
        public string Subject { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Body { get; set; }
        public string Consignee { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public Nullable<int> PayType { get; set; }
        public string PayOrderNo { get; set; }
    
        public virtual DesignWork DesignWork { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual User User { get; set; }
    }
}
