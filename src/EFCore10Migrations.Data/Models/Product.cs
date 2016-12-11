using System.ComponentModel.DataAnnotations;

namespace EFCore10Migrations.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [StringLength(200)]
        public string ProductName { get; set; }
    }
}
