using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExameBE.Domain.Model;
using ExameBE.Services;
using Microsoft.AspNetCore.Mvc;
using static ExameBE.Domain.Model.Anuncio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExameBE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioController : Controller
    {
        #region Fields
        private readonly IAnuncioServices _adServices;
        #endregion

        #region Constructor
        public AnuncioController(IAnuncioServices adServices)
        {
            _adServices = adServices;
        }
        #endregion

        // GET: api/values
        [HttpGet]
        [Route("allAds")]
        public async Task<IActionResult> GetAll()
        {
            var ads = await _adServices.GetAllAds();
            if (ads == null) return BadRequest("There is no ad yet.");

            return Ok(ads);
        }

        // GET api/values/5
        [HttpGet]
        [Route("adId/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ad = await _adServices.GetAdById(id);
            if (ad == null) return BadRequest("No ad found with the requested id.");

            return Ok(ad);
        }

        [HttpGet]
        [Route("type/{type}")]
        public async Task<IActionResult> GetByType(AdTypes type)
        {
            var ads = await _adServices.GetAdByType(type);
            if (ads == null) return BadRequest($"No ad found with the requested type {type}.");

            return Ok(ads);
        }

        // POST api/values
        [HttpPost]
        [Route("newAd")]

        public async Task<IActionResult> CreateAnAd(Anuncio ad)
        {
            await _adServices.CreateAd(ad);
            return Ok(Json($"O seu anúncio (id: {ad.Id}) foi publicado com sucesso."));
        }
    }
}
