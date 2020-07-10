using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sho.Entity
{
    public class UserDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AllianceId { get; set; }
        public int BattlePower { get; set; }
        public int HQLevel { get; set; }
        public DateTime UpdateTime { get; set; }

        public Alliance Alliance { get; set; }


    }
}
