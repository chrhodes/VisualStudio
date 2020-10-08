using System.Collections.Generic;

namespace VNC_PT_APPLICATION.Application..Queries.GetList
{
    public interface IGetsListQuery
    {
        List<Model> Execute();
        //List<Customer> Execute();
    }
}
