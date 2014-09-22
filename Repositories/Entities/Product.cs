using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Booker.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            Active = true;
        }

        [HiddenInput]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public double Cost { get; set; }

        public bool Active { get; set; }
    }
}