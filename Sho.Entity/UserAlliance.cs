using System;
using System.Collections.Generic;
using System.Text;

namespace Sho.Entity
{
    public class UserAlliance
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int AllianceId { get; set; }
        public DateTime DateRegistered { get; set; }

        public User User { get; set; }
        public Alliance Alliance { get; set; }
    }
}
