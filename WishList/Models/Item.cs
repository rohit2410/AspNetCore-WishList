using System;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public String Description { get; set; }
    }
}
