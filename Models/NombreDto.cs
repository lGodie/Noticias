﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Noticias.Data.Entities
{
    public class NombreDto
    {
 
            [Key]
            public int NombreID { get; set; }
            public string Nombre { get; set; }

    }
}
