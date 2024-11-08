using System;
using System.Collections.Generic;

namespace MyFitness.Models.Domain;

public partial class Attendance
{
    public int Id { get; set; }

    public int? MemberId { get; set; }

    public int? ClassId { get; set; }

    public DateTime? AttendanceDate { get; set; }

    public virtual Classes? Class { get; set; }

    public virtual Member? Member { get; set; }
}
