using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnerdevc.objects.Titles
{
    public interface IStoryLine
    {
       int TitleId { get; set; }
       string Type { get; set; }
       string Language { get; set; }
       string Description { get; set; }
       int Id { get; set; }
    }
}
