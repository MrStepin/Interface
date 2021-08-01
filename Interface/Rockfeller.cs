using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Rockfeller
    {
    
        public void InstallHeart(IHeart _heart)
        {
            _heart.Connect();
        }
    }
}
