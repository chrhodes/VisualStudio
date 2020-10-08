using Infrastructure1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure1
{
    public interface IView2
    {
        // This is view first approach.  View knows about ViewModel
        IViewModel2 ViewModel { get; set; }
    }
}
