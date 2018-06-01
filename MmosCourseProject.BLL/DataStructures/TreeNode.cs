using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.DataStructures
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> SubNodes { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            SubNodes = new List<TreeNode<T>>();
        }
    }
}
