using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryEntity
{
    internal class DataService
    {
        public static void Load()
        {
            // Database context
            //
            try_entityEntities context = new try_entityEntities();
            var recordSet = from row in context.meals select row;
            if (recordSet != null)
            {
                foreach (var l in recordSet)
                {
                    var tuple = string.Format("{0}:{1}", l.course, l.item);
                    Console.WriteLine(tuple);
                }
            }
        }
    }
}
