﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Database.Models;

namespace Persistence.Database.Configuration
{
    public class AuthorConfiguration
    {
        public AuthorConfiguration(EntityTypeBuilder<Author> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            entityBuilder.Property(x => x.AboutMe).HasMaxLength(500);
        }
    }
}