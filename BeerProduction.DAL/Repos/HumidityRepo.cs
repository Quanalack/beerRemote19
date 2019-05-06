using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProduction.DAL.Repos
{
    public class HumidityRepo<T> : BaseRepository<T> where T : class
    {
        public HumidityRepo(Context context) : base(context)
        {

        }
    }
}


