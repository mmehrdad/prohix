using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.HomePage
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageLink { get; set; }
        public bool? IsSliderImage { get; set; }
    }
}
