﻿namespace OnlineShop.Services.Models
{
    using OnlineShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public class AdViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public UserViewModel Owner { get; set; }

        public string Type { get; set; }

        public DateTime DateOfPost { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public static Expression<Func<Ad, AdViewModel>> Create
        {
            get
            {
                return a => new AdViewModel
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                    Price = a.Price,
                    Owner = new UserViewModel
                    {
                        Id = a.Owner.Id,
                        Username = a.Owner.UserName
                    },
                    Type = a.Type.Name,
                    DateOfPost = a.PostedOn,
                    Categories = a.Categories
                    .Select(c => new CategoryViewModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    })
                };
            }
        }
    }
}