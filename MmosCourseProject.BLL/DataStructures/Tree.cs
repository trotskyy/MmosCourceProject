using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.DataStructures
{
    /// <summary>
    /// Use to represent Teams or Tasks tree hierarchy
    /// </summary>
    [DataContract]
    public class Tree<T>
    {
        [DataMember]
        public TreeNode<T> Root { get; set; }

        public Tree(T root)
        {
            Root = new TreeNode<T>(root);
        }
    }
}
