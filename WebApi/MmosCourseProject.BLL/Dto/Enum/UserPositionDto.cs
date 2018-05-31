using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.Enum
{
    [DataContract]
    public enum UserPositionDto
    {
        [DataMember]
        Developer = 1,
        [DataMember]
        Designer = 2,
        [DataMember]
        ProjectManager = 3,
        [DataMember]
        DatabaseAdministrator = 4,
        [DataMember]
        DevOps = 5
    }
}
