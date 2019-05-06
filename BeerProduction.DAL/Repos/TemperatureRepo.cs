using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProduction.DAL.Repos
{
    public class TemperatureRepo<T> : BaseRepository<T> where T : class
    {
        public TemperatureRepo(Context context) : base(context)
        {

        }
    }
    
}
