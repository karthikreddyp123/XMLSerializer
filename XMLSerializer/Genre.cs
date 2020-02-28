using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializer
{
    public enum Genre
    {
        Computer,
        Fantasy,
        Romance,
        Horror,
        [Display(Name = "Science Fiction")]
        ScienceFiction
    }
}
