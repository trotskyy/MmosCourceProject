using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MmosCourseProject.BLL.Dto.Enum
{
    [DataContract]
    public enum TaskPriorityDto
    {
        [DataMember]
        Highest = 1,
        [DataMember]
        High = 2,
        [DataMember]
        Medium = 3,
        [DataMember]
        Low = 4,
        [DataMember]
        Lowest = 5
    }
}
