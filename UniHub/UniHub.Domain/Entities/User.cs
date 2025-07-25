﻿using UniHub.Domain.Enums;

namespace UniHub.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? ClerkId { get; set; }

        public string? Name { get; set; }

        public UserRole Role { get; set; }
    }
}
