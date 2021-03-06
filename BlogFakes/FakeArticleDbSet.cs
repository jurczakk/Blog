using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using BlogData.Entities;

namespace BlogFakes
{
    public class FakeArticleDbSet : FakeDbSet<Article>
    {
        public override Article Find(params object[] keyValues)
        {
            return data.FirstOrDefault(x => x.Id == (int)keyValues.First());
        }

        public override ValueTask<Article> FindAsync(params object[] keyValues)
        {
            var article = data.FirstOrDefault(x => x.Id == (int)keyValues.First());
            return new ValueTask<Article>(article);
        }

        public override EntityEntry<Article> Update(Article entity)
        {
            var item = data.FirstOrDefault(t => t.Id == entity.Id);
            var index = data.IndexOf(item);

            data[index] = entity;

            return null;
        }
    }
}