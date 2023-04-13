using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Model
{
    internal class Folder : IStorageItem
    {
        private string _name;
        private List<IStorageItem> _childern;
        public Folder(string name)
        {
            _name = name;
            _childern = new List<IStorageItem>();
        }
        public void Display(int depth = 0)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("{0}", _name);
            foreach (var item in _childern)
            {
                int tem = depth;
                item.Display(++tem);
            }
        }
        public void AddChild(IStorageItem item)
        {
            _childern.Add(item);
        }
    }
}
