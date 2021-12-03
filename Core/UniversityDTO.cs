using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB.Core
{
    public record UniversityDetailsDTO(string Id, string Name, ICollection<int>? Educations);

    public record EducationDetailsDTO(int Id, string Name, string Grade, string UniversityId);
}
