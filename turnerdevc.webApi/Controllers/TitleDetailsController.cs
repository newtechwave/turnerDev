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
    public class TitleDetailsController : ApiController
    {
        [HttpGet]
        public IQueryable<objects.Titles.IParticpant> TitleParticipants(int titleId)
        {
            var data = new TitleRepsitory(new TitlesEntities()).GetTitleParticipants(titleId);
            return data;
        }

        [HttpGet]
        public IQueryable<objects.Titles.IGenre> TitleGenres(int titleId)
        {
            var data = new TitleRepsitory(new TitlesEntities()).GetTitleGenres(titleId);
            return data;
        }

        [HttpGet]
        public IQueryable<objects.Titles.IAward> TitleAwards(int titleId)
        {
            var data = new TitleRepsitory(new TitlesEntities()).GetTitleAwards(titleId);
            return data;
        }

        [HttpGet]
        public IQueryable<objects.Titles.IStoryLine> TitleStory(int titleId)
        {
            var data = new TitleRepsitory(new TitlesEntities()).GetTitleStory(titleId);
            return data;
        }
    }
}
