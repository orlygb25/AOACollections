using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AOACollections.Models
{
    public class Movie
    {
            public int ID { get; set; }

            [DisplayName("Movie Name")]
            public string MovieName { get; set; }

            [DisplayName("Description")]
            public string Description { get; set; }

            [DisplayName("Category")]
            public Category Category { get; set; }

            public Movie()
            {
                
            }

    }
        public class MovieDBContext : DbContext
        {
            public DbSet<Movie> movie;
            public System.Data.Entity.DbSet<AOACollections.Models.Movie> Movies { get; set; }
        }

        public enum Category
        {
            Drama,
            Comedy,
            Action,
            Crime,
            Fantasy
        }
}