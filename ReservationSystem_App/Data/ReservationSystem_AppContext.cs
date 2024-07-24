using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservationSystemApp.Models;

namespace ReservationSystem_App.Data
{
    public class ReservationSystem_AppContext : DbContext
    {
        public ReservationSystem_AppContext (DbContextOptions<ReservationSystem_AppContext> options)
            : base(options)
        {
        }

        public DbSet<ReservationSystemApp.Models.Passenger> Passenger { get; set; } = default!;
        public DbSet<ReservationSystemApp.Models.Reservation> Reservation { get; set; } = default!;
    }
}
