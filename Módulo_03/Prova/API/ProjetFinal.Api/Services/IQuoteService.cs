using ProjetFinal.Api.Domain;
using ProjetFinal.Api.Models;

namespace ProjetFinal.Api.Services
{
    public interface IQuoteService
    {
        IEnumerable<Quote> GetAll();

        Quote? GetById(int id);

        Quote? Create(QuoteModel model);

        Quote? Update(QuoteUpdateModel model);

        void Delete(int id);
    }
}