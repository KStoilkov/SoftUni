namespace OnlineShop.Services.Controllers
{
    using Microsoft.AspNet.Identity;
    using Models;
    using OnlineShop.Models;
    using System;
    using System.Linq;
    using System.Web.Http;

    [Authorize]
    [RoutePrefix("api/ads")]
    public class AdsController : BaseApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetAds()
        {
            var ads = this.Data.Ads
                .Where(a => a.Status == AdStatus.Open)
                .OrderByDescending(a => a.Type.Id)
                .ThenBy(a => a.PostedOn)
                .Select(AdViewModel.Create);
                
            return this.Ok(ads);
        }

        [HttpPost]
        public IHttpActionResult CreateAd([FromUri]CreateAdBindingModel model)
        {
            var ad = new Ad
            { 
                Name = model.Name,
                Description = model.Description,
                TypeId = model.TypeId,
                Price = model.Price,
                PostedOn = DateTime.Now,
                OwnerId = this.User.Identity.GetUserId()
            };

            foreach (var categoryId in model.Categories)
            {
                var category = this.Data.Categories.Find(categoryId);
                ad.Categories.Add(category);
            }

            this.Data.Ads.Add(ad);
            this.Data.SaveChanges();

            var newAd = this.Data.Ads
                .Where(a => a.Id == ad.Id)
                .Select(AdViewModel.Create)
                .FirstOrDefault();
                
            return this.Ok(newAd);
        }

        [HttpPut]
        [Route("{id}/close")]
        public IHttpActionResult CloseAd(int id)
        {
            var ad = this.Data.Ads.Find(id);
            if (ad == null)
            {
                return this.BadRequest("Ad with Id " + id + " doesn't exist.");
            }

            string userId = this.User.Identity.GetUserId();
            if (ad.OwnerId != userId)
            {
                return this.Unauthorized();
            }

            ad.Status = AdStatus.Closed;
            ad.ClosedOn = DateTime.Now;
            this.Data.SaveChanges();

            return this.Ok();
        }
    }
}
