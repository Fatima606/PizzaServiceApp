using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace W2_D2_01.Areas.Identity.Data;

// Add profile data for application users by adding properties to the PizzaServiceUser class
public class PizzaServiceUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

