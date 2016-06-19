using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnerdevc.objects.Titles
{
    public interface ITitle
    {
       int TitleId { get; set; }
       string TitleName { get; set; }
       string OtherName { get; set; }
       string OtherNameLanguage { get; set; }
       string TitleNameSortable { get; set; }
       int? TitleTypeId { get; set; }
       int? ReleaseYear { get; set; }
       DateTime ProcessedDate { get; set; }
    }
}
