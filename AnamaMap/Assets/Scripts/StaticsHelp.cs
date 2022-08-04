using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class StaticsHelp<T>
    {
        public List<T> items = new List<T>();

        public void ADD(T item)
        {
            items.Add(item);
        }



    }
}
