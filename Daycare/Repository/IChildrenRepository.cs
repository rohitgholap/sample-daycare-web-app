using System;
using Daycare.Repository.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Daycare.Repository
{
    public interface IChildrenRepository
    {
        public Task<List<Children>> GetChildren();
    }
}

