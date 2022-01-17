﻿using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Display(Name = "Movie name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }
        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImageURL { get; set; }
        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Movie category")]
        [Required(ErrorMessage = "Movie category is required")]
        public MovieCategory MovieCategory { get; set; }
        //Relationships
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Actor is required")]
        public List<int> ActorIds { get; set; }
        [Display(Name = "Select cinema")]
        [Required(ErrorMessage = "Movie ciname is required")]
        public int CinemaId { get; set; }
        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = "Producer is required")]
        public int ProducerId { get; set; }
    }
}