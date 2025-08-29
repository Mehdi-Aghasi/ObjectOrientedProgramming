using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiTrack_
{
    class RoomFullException: Exception
    {
        public RoomFullException(string message) : base(message) { }
    }
}
