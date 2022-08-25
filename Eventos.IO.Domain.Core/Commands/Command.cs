using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventos.IO.Domain.Core.Events;

namespace Eventos.IO.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime Timestamp { get; private set; }
        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
