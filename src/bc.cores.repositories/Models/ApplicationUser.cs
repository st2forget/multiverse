﻿using Microsoft.AspNetCore.Identity;
using System;

namespace bc.cores.repositories.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {
    }
}
