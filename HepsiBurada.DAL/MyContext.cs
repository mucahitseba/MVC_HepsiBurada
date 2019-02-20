using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HepsiBurada.MODELS.IdentityModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HepsiBurada.DAL
{
    public class MyContext:IdentityDbContext<User>
    {
        public MyContext() : base("name=MyCon")
        {

        }
    }
}
