using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Clinic
{
    public int ClinicId { get; set; }

    public string Name { get; set; } = null!;

    public IList<Booking> Bookings { get; set; } = null!;
}
