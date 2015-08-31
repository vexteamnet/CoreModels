using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VexTeamNetwork.Models
{
    public class Season
    {
        [Key, Required]
        public string Name { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
