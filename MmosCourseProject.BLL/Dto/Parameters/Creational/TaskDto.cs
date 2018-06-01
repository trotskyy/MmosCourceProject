﻿using MmosCourseProject.BLL.Dto.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Dto.Parameters.Creational
{
    [DataContract]
    public class TaskDto
    {
        [DataMember]
        [Range(0, 0, ErrorMessage = "Id must be NOT specified in case of creation")]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        [Required]
        public string Description { get; set; }

        [DataMember]
        public int CreatorId { get; set; }

        [DataMember]
        public DateTime CreationDateTime { get; set; }

        [DataMember]
        public int TeamId { get; set; }

        [DataMember]
        public TaskStateDto State { get; set; }

        [DataMember]
        public TaskPriorityDto Priority { get; set; }

        [DataMember]
        public bool IsUrgent { get; set; }

        [DataMember]
        public DateTime? LastChangeDateTime { get; set; }

        [DataMember]
        public int? ParentTaskId { get; set; }

        [DataMember]
        public int ResponsibleId { get; set; }
    }
}

