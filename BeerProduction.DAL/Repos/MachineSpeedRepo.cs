using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProduction.DAL.Repos
{
    public class MachineSpeedRepo<T> : BaseRepository<T> where T : class
    {
        public MachineSpeedRepo(Context context) : base(context)
        {

        }
    }
}
