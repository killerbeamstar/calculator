using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekenmachine1.Interface
{
    public interface IView
    {
        /// <summary>
        /// sets up function the class using the //
        /// </summary>
        void empty();
        void toTextbox(string text);
        void response(string text);
    }
}
