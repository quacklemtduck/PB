using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB.Core
{
    public interface IUniversityRepository
    {
        Task<UniversityDetailsDTO> ReadByIDAsync(string universityId);
        Task<IReadOnlyCollection<UniversityDetailsDTO>> ReadAllAsync();

    }
}
