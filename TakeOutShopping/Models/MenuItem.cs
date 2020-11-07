﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spice.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Naam")]
        public string Name { get; set; }
        [Display(Name = "Omschrijving")]
        public string Description { get; set; }

        public string Spicyness { get; set; }
        public enum ESpicy { NA=0,NotSpicy=1, Spicy=2, VerySpicy=3}

        public string Image { get; set; }

        [Display(Name="Categorie")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "SubCategorie")]
        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; }

        [Range(1,int.MaxValue, ErrorMessage =" Prijs groter dan €{1}")]
        public double Price { get; set; }


    }
}
