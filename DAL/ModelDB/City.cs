using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ModelDB
{
    public class City
    {
        /// <summary>
        /// Id city
        /// </summary>
        [Key]
        public int CityId { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        public string? Name { get; set; }
    }
}
