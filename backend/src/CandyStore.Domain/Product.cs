using CandyStore.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyStore.Domain
{
    public class Product : Entity, IAggregateRoot
    {
        public Product(string name, string description, decimal price, string urlImage)
        {
            Name = name;
            Description = description;
            Price = price;
            UrlImage = urlImage;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public string UrlImage { get; private set; }
    }
}
