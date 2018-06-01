using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.DataStructures
{
    [DataContract]
    public class TreeNode<T>
    {
        [DataMember]
        public T Value { get; set; }
        [DataMember]
        public List<TreeNode<T>> SubNodes { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            SubNodes = new List<TreeNode<T>>();
        }
    }
}
