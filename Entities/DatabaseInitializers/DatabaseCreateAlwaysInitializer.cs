using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace ARQ.Maqueta.Entities
{
    public class DatabaseCreateAlwaysInitializer : DropCreateDatabaseAlways<EntitiesDB>
    {
        protected override void Seed(EntitiesDB context)
        {
        }
    }
}
