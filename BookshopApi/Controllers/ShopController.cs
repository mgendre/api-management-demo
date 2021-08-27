using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace BookshopApi.Controllers
{
    
    [ApiController]
    [Route("/shop/items")]
    public class ShopController
    {
        private static readonly IReadOnlyCollection<ShopItem> Items = new[]
        {
            new ShopItem
            {
                Summary = "Angular c'est bien",
                Price = 30.30f
            },
            new ShopItem
            {
                Summary = "Api Management pour les nuls",
                Price = 99.99f
            }
        };

        public ShopController()
        {
        }

        [HttpGet]
        public IEnumerable<ShopItem> ListAll()
        {
            return Items;
        }
        
        [HttpGet("{id:guid}")]
        public ShopItem Get(Guid id)
        {
            return Items.First(i => i.Id == id);
        }
        
        [HttpPost]
        public ShopItem Create(ShopItem toCreate)
        {
            return toCreate;
        }
        
        [HttpPut("{id:guid}")]
        public ShopItem Update(Guid id, ShopItem toCreate)
        {
            return toCreate;
        }
        
        [HttpDelete("{id:guid}")]
        public void Delete(Guid id)
        {
            // Demo
        }
    }
}