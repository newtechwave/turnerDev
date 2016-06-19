using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnerdevc.objects.Titles
{
    public interface IParticpant
    {
       int Id { get; set; }
       string Name { get; set; }
       string ParticipantType { get; set; }
       string RoleType { get; set; }
       bool IsKey { get; set; }
       bool IsOnScreen { get; set; }
               
    }
}
