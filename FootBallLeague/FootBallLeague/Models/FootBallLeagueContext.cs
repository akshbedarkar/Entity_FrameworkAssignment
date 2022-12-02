using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FootBallLeague.Models
{
    public class FootBallLeagueContext:DbContext
    {
        public DbSet<FootBallLeague> FootBallLeague { get;set; }

    }
}