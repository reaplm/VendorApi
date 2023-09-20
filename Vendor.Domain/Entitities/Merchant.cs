using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendor.Domain.Entitities
{
    [Table(name: "merchant")]
    public class Merchant
    {
        [Key]
        [Column(name: "pk_merchant_id")]
        public int ID { set; get; }

        [Column(name: "image_url")]
        public string? ImageUrl { set; get; }

        [Column(name: "overview")]
        public string? Overview { set; get; }

        [Column(name: "uid")]
        public string? Uid { set; get; }

        [Column(name: "category")]
        public string? Category { set; get; }

        [Column(name: "location")]
        public string? Location { set; get; }

        [Column(name: "name")]
        public string? Name { set; get; }


    }
}

