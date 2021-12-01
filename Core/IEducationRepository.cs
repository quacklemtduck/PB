using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB.Core
{
    public interface IEducationRepository
    {
        Task<EducationDetailsDTO> ReadByIDAsync(int educationId);
        Task<IReadOnlyCollection<EducationDetailsDTO>> ReadAllByUniversityAsync(string universityId);

    }
}
