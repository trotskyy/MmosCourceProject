using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.Enum
{
    [DataContract]
    public enum TaskStateDto
    {
        [DataMember]
        Created = 1,
        [DataMember]
        InProgress = 2,
        [DataMember]
        Done = 3,
        [DataMember]
        Approved = 4,
        [DataMember]
        Bug = 5,
        [DataMember]
        Debugging = 6
    }
}
