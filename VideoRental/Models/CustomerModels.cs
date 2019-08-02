using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class CustomerModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}