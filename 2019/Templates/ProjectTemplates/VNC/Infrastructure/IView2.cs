using $safeprojectname$;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public interface IView2
    {
        // This is view first approach.  View knows about ViewModel
        IViewModel2 ViewModel { get; set; }
    }
}
