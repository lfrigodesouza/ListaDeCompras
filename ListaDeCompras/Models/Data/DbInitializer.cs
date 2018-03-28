using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Models.Data
{
    public class DbInitializer
    {
        public static void Init(ListaDeComprasContext ctx)
        {
            ctx.Database.EnsureCreated();
            ctx.SaveChanges();
        }
    }
}
