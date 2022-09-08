using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExameBE.Domain.Model;
using static ExameBE.Domain.Model.Anuncio;

namespace ExameBE.Domain.Contract
{
    public interface IAnuncioRepository
    {
        Task<IEnumerable<Anuncio>> GetAllAds();
        Task<Anuncio> GetAdById(int id);
        Task<IEnumerable<Anuncio>> GetAdByType(AdTypes adType);
        Task CreateAd(Anuncio ad);
        Task SaveChanges();
    }
}
