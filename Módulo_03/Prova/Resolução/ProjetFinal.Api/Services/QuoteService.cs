using ProjetFinal.Api.Domain;
using ProjetFinal.Api.Models;
using ProjetFinal.Api.Persistence;

namespace ProjetFinal.Api.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly IAppDbContext dbContext;

        public QuoteService(IAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        IEnumerable<Quote> IQuoteService.GetAll()
            => dbContext.Quotes;

        Quote? IQuoteService.GetById(int id)
            => dbContext.Quotes.Find(id);

        public Quote? Create(QuoteModel model)
        {
            var entity = new Quote
            {
                Text = model.Text,
                Author = model.Author
            };

            dbContext.Quotes.Add(entity);
            dbContext.SaveChanges();

            return entity;
        }

        public Quote? Update(QuoteUpdateModel model)
        {
            var entity = dbContext.Quotes.Find(model.Id);

            if (entity == null)
                return null;

            entity.Author = model.Author;
            entity.Text = model.Text;

            dbContext.Quotes.Update(entity);
            dbContext.SaveChanges();

            return entity;
        }

        public void Delete(int id)
        {
            var entity = dbContext.Quotes.Find(id);

            if (entity == null)
                return;

            dbContext.Quotes.Remove(entity);
            dbContext.SaveChanges();
        }
    }
}
