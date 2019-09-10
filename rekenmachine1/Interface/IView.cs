using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekenmachine1.Interface
{
    public interface IView
    {
        void empty();
        void toTextbox(string text);
        void response(string text);
    }
}
