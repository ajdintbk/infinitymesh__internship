using Microsoft.EntityFrameworkCore.Metadata.Builders;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.Configuration
{
    class ColorConfiguration : BaseEntityConfiguration<Color>
    {
        public override void Configure(EntityTypeBuilder<Color> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(30);
            builder.HasMany(b => b.Cars).WithOne(b => b.Color).HasForeignKey(b => b.ColorId);
            builder.HasData(new List<Color>
            {
                new Color
                {
                    Id=1,
                    Name="Red",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="ajdintbk",

                },
                new Color
                {
                    Id=3,
                    Name="Green",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="ajdintbk",

                },
                new Color
                {
                    Id=4,
                    Name="Black",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="ajdintbk",

                },

            });
        }
    }
}
