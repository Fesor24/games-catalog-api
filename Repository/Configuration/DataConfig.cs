﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class DataConfig: IEntityTypeConfiguration<Game>
    {

        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
        }
    }
    
}
