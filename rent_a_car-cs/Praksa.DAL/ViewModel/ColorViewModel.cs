using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praksa.DAL.ViewModel
{
    public class ColorViewModel
    {
        public ColorViewModel(IReadOnlyCollection<Color> colors)
        {
            Collection = colors.Select(color => new ColorDto(color)).ToList();

        }

        public IReadOnlyCollection<ColorDto> Collection { get; set; }
    }
}
