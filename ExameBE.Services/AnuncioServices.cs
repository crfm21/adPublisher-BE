using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExameBE.Domain.Contract;
using ExameBE.Domain.Model;

namespace ExameBE.Services
{
    public class AnuncioServices : IAnuncioServices
    {
        #region Fields
        private readonly IAnuncioRepository _adRepo;
        #endregion


        #region Constructor
        public AnuncioServices(IAnuncioRepository adRepo)
        {
            _adRepo = adRepo;
        }
        #endregion

        #region Methods
        public Task CreateAd(Anuncio ad)
        {
            return _adRepo.CreateAd(ad);
        }

        public Task<Anuncio> GetAdById(int id)
        {
            return _adRepo.GetAdById(id);
        }

        public Task<IEnumerable<Anuncio>> GetAdByType(Anuncio.AdTypes adType)
        {
            return _adRepo.GetAdByType(adType);
        }

        public Task<IEnumerable<Anuncio>> GetAllAds()
        {
            return _adRepo.GetAllAds();
        }
        #endregion

    }
}
