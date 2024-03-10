using CONFİDO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONFİDO.Service.Services.Abstract
{
    public interface IDonateService
    {
       Task<List<Organization>> GetAllOrganizationAsync();
    }
}
