using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ExameBE.Domain.Contract;
using ExameBE.Domain.Model;
using ExameBE.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using static ExameBE.Domain.Model.Anuncio;

namespace ExameBE.Infrastructure.Repository
{
    public class AnuncioRepository : IAnuncioRepository
    {
        #region Fields
        private readonly MainContext _context;
        private readonly DbSet<Anuncio> _ads;
        #endregion

        #region Constructor
        public AnuncioRepository(MainContext context)
        {
            _context = context;
            _ads = _context.Set<Anuncio>();
        }
        #endregion

        #region Methods
        public async Task CreateAd(Anuncio ad)
        {
            if (ad == null) throw new ArgumentNullException("Insert method - repository");

            var subject = await _context.Ads.FirstOrDefaultAsync(a => a.Subject == ad.Subject);
            if (subject != null) throw new Exception("Subject already exists.");

            await _context.AddAsync(ad);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Anuncio>> GetAdByType(AdTypes adType)
        {
            return await GetWhere(a => a.AdType == adType) ;
        }

        public async Task<Anuncio> GetAdById(int id)
        {
            return await _ads.FindAsync(id);
        }

        public async Task<IEnumerable<Anuncio>> GetAllAds()
        {
            return await _ads.ToListAsync();
        }

        public async Task<IEnumerable<Anuncio>> GetWhere(Expression<Func<Anuncio, bool>> predicate)
        {
            return await _ads.Where(predicate).ToListAsync();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
