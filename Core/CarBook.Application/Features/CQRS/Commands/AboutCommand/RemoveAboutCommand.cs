using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.AboutCommand
{
    public class RemoveAboutCommand
    {
        public int id { get; set; }
        public RemoveAboutCommand(int id)
        {
            this.id = id;
        }
    }
}
