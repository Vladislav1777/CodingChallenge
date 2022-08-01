using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Repository
{
    public class DbInitializer
    {
        public static void Initialize(CodingChallengeDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
