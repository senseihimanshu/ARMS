﻿using System;
using System.Collections.Generic;
using System.Text;
using Arms.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Arms.Infrastructure.EntityTypeConfigurations
{
    internal class JobDescriptionEntityTypeConfiguration : IEntityTypeConfiguration<JobDescription>
    {
        public void Configure(EntityTypeBuilder<JobDescription> builder)
        {
            builder.ToTable("JobDescription", "ARMS");

            builder.HasIndex(e => e.jobTitle)
                .HasName("UQ__JobDescr__151D087A2951D1F8")
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.closingDate).HasColumnName("closingDate");

            builder.Property(e => e.code)
                .HasColumnName("code")
                .HasMaxLength(106)
                .IsUnicode(false)
                .HasComputedColumnSql("('CYGJID'+CONVERT([varchar](100),[id]))");

            builder.Property(e => e.createdAt)
                .HasColumnName("createdAt")
                .HasDefaultValueSql("(sysdatetime())");

            builder.Property(e => e.createdBy)
                .HasColumnName("createdBy")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.description)
                .IsRequired()
                .HasColumnName("description");

            builder.Property(e => e.jobTitle)
                .IsRequired()
                .HasColumnName("jobTitle")
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.locationId)
                .IsRequired()
                .HasColumnName("location")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.modifiedAt)
                .HasColumnName("modifiedAt")
                .HasDefaultValueSql("(sysdatetime())");

            builder.Property(e => e.modifiedBy)
                .HasColumnName("modifiedBy")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.openingDate).HasColumnName("openingDate");

            builder.Property(e => e.pdfBlobData).HasColumnName("pdfBlobData");

            builder.Property(e => e.salary).HasColumnName("salary");

            builder.Property(e => e.vacancies).HasColumnName("vacancies");
        }
    }
}
