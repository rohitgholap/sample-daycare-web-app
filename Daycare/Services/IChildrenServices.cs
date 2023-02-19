using System;
using System.Collections.Generic;
using Daycare.Repository.Entities;
using System.Threading.Tasks;

namespace Daycare.Services
{
    public interface IChildrenServices
    {
        public Task<List<Children>> GetChildrens_Data();
    }
}

