﻿using System;
using System.Collections.Generic;
using Movie_App.Data;

namespace Movie_App.Models
{
    public class Movie
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema

        public Cinema Cinema { get; set; }
    }
}
