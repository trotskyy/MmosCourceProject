using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.Enum
{
    [DataContract]
    public enum UserLevelDto
    {
        [DataMember]
        Junior = 1,
        [DataMember]
        Middle = 2,
        [DataMember]
        Senior = 3
    }
}
