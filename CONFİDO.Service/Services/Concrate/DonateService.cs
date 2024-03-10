using CONFİDO.Data.UnitOfWorks;
using CONFİDO.Entity;
using CONFİDO.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONFİDO.Service.Services.Concrate
{
    public class DonateService:IDonateService
    {
        private readonly IUnitOfWork unitOfWork;

        public DonateService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public async Task<List<Organization>> GetAllOrganizationAsync()
        {
            var organization = await unitOfWork.GetRepository<Organization>().GetAllAsync();
           
            return organization;
        }
    }
}
