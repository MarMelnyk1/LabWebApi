﻿using Microsoft.AspNetCore.Identity;

namespace LabWebAPI.Contracts.Data.Entities
{
    public class User : IdentityUser, IBaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string ImageAvatarUrl { get; set; }
    }
}