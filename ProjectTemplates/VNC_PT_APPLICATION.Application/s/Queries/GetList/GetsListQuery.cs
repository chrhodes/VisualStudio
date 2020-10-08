using System.Collections.Generic;
using System.Linq;

using VNC_PT_APPLICATION.Application.Interfaces;

namespace VNC_PT_APPLICATION.Application..Queries.GetList
{
    public class GetsListQuery : IGetsListQuery
    {
        private readonly IDatabaseService _database;

        public GetsListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<Model> Execute()
        //public List<Customer> Execute()
        {
            //using (var context = new CustomPoolAndSpaDbContext())
            //{
            //    return context.CustomerSet.AsNoTracking()
            //        .OrderBy(c => c.Name)
            //        .ToList();
            //}

            //var customers = _database.Customers.ToList();
            //return customers;

            var items = _database.s
                .Select(p => new Model()
                {
                    Id = p.Id,
                    //Name = p.FirstName
                });

            return items.ToList();
        }
    }
}
