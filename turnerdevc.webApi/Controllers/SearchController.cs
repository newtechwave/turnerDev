using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using turnerdevc.data;
using turnerdevc.data.Repository;

namespace turnerdevc.webApi.Controllers
{
    public class SearchController : ApiController
    {
        [HttpGet]
        public IQueryable<objects.Titles.ITitle> SearchForTitle(string searchInfo)
        {
            var data = new TitleRepsitory(new TitlesEntities()).SearchTitles(searchInfo);
            return data;
            
        }

    }
}
