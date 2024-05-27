﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaaws.Models
{
    [Table("pelismysql")]
    public class Peli
    {
        [Key]
        [Column("IdPelicula")]
        public int IdPelicula { get; set; }

        [Column("Genero")]
        public string Genero { get; set; }

        [Column("Titulo")]
        public string Titulo { get; set; }


        [Column("Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Column("Argumento")]
        public string Argumento { get; set; }

        [Column("Actores")]
        public string Actores { get; set; }


        [Column("Duracion")]
        public int Duracion { get; set; }

        [Column("Precio")]
        public int Precio { get; set; }

        [Column("Youtube")]
        public string Youtube { get; set; }
    }
}
