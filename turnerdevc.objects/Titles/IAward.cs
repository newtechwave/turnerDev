using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnerdevc.objects.Titles
{
    public interface IAward
    {
       int TitleId { get; set; }
       bool? AwardWon { get; set; }
       int? AwardYear { get; set; }
       string AwardName { get; set; }
       string AwardCompany { get; set; }
       int Id { get; set; }
    }
}
