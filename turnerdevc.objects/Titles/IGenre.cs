using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnerdevc.objects.Titles
{
    public interface IGenre
    {
      int Id { get; set; }
      string Name { get; set; }
      int TitleId { get; set; }
    }
}
