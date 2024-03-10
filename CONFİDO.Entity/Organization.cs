using CONFİDO.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONFİDO.Entity
{
    public class Organization:IEntityBase
    {
        public Guid OrganizationId { get; set; }
        public string Name { get; set; }
        public int DonaterCount { get; set; }
        public bool isConfirim { get; set; }
        public string WalletId { get; set; }




    }
}
