﻿namespace library_automation_back_end.Configurations.Models
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                [
                    new() { Id = 1, Name = "Yönetici" },
                    new() { Id = 2, Name = "Kullanıcı" }
                ]);
        }
    }
}
