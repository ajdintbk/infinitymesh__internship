using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.ViewModel
{
    public class ColorDto
    {
        private Color color;

        public ColorDto()
        {

        }

        public ColorDto(Color color)
        {
            Id = color.Id;
            Name = color.Name;
        }


        public int Id { get; set; }
        public string Name { get; set; }
    }
}
