using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Daycare.Repository;
using Daycare.Repository.Entities;

namespace Daycare.Services
{
    public class ChildrenServices : IChildrenServices
    {
        private readonly IChildrenRepository ChildrenRepository;
        
        public ChildrenServices(IChildrenRepository childrenRepository)
        {
            ChildrenRepository = childrenRepository;
        }


        public async Task<List<Children>> GetChildrens_Data()
        {
            var childrens = await ChildrenRepository.GetChildren();
            return childrens;

        }
    }
}

