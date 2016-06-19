using System;
using System.Linq;

namespace turnerdevc.data.Repository
{
    public class TitleRepsitory
    {
        private readonly TitlesEntities _context;

        public TitleRepsitory(TitlesEntities context)
        {
            if (context == null)
            {
                throw new ArgumentException();
            }
            _context = context;
        }

        public IQueryable<objects.Titles.IGenre> GetTitleGenres(int titleId)
        {
            IQueryable<objects.Titles.IGenre> result;
            try
            {
                result = (from tg in _context.TitleGenres
                          join g in _context.Genres on tg.GenreId equals g.Id
                          orderby g.Name
                          where (tg.TitleId == titleId)
                          select new objects.Titles.Genre
                          {
                              Id = g.Id,
                              Name = g.Name,
                         }
                   );
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        public IQueryable<objects.Titles.IParticpant> GetTitleParticipants(int titleId)
        {
            IQueryable<objects.Titles.IParticpant> result;
            try
            {
                result = (from tp in _context.TitleParticipants
                           join p in _context.Participants on tp.ParticipantId equals p.Id
                           orderby p.Name
                          where (tp.TitleId == titleId)
                          select new objects.Titles.Particpant
                          {
                              Id = p.Id,
                              Name = p.Name,
                              ParticipantType = p.ParticipantType,
                              IsKey = tp.IsKey,
                              RoleType = tp.RoleType,
                              IsOnScreen = tp.IsOnScreen
                              
                          }
                   );
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        public IQueryable<objects.Titles.IAward> GetTitleAwards(int titleId)
        {
            IQueryable<objects.Titles.IAward> result;
            try
            {
                result = (from a in _context.Awards
                          orderby a.Award1
                          where (a.TitleId == titleId && a.AwardWon == true)
                          select new objects.Titles.Award()
                          {
                              Id = a.Id,
                              AwardWon = a.AwardWon,
                              AwardYear = a.AwardYear,
                              AwardName= a.Award1,
                              AwardCompany= a.AwardCompany,
                          }
                   );
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        public IQueryable<objects.Titles.IStoryLine> GetTitleStory(int titleId)
        {
            IQueryable<objects.Titles.IStoryLine> result;
            try
            {
                result = (from s in _context.StoryLines
                          orderby s.Type, s.Language
                          where (s.TitleId == titleId)
                          select new objects.Titles.Storyline()
                          {
                              Id = s.Id,
                              Type = s.Type,
                              Language = s.Language,
                              Description= s.Description
                              
                          }
                   );
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        public IQueryable<objects.Titles.ITitle> SearchTitles(string searchCriteria)
        {
            IQueryable<objects.Titles.ITitle> result;
            try
            {
                 result = (from t in _context.Titles
                    
                    orderby t.TitleNameSortable
                           where (t.TitleName.Contains(searchCriteria) )
                    select new objects.Titles.Title
                    {
                        TitleId = t.TitleId,
                        TitleName = t.TitleName,
                        ReleaseYear = t.ReleaseYear,
                    }
                    );
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }
    }
}