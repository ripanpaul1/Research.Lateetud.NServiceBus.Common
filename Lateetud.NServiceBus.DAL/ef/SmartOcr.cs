//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lateetud.NServiceBus.DAL.ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class SmartOcr
    {
        public long SmartOcrID { get; set; }
        public string ServiceName { get; set; }
        public string MessageId { get; set; }
        public string RequestId { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
    }
}