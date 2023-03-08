using LiteDB;
using Vulcanova.Features.Shared;

namespace Vulcanova.Features.Attendance.Report;

public class AttendanceReport
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public Subject Subject { get; set; }
    public int Presence { get; set; }
    public int Absence { get; set; }
    public int Late { get; set; }

    [BsonIgnore]
    public float PresencePercentage => (float) Presence / (Presence + Absence + Late) * 100;
}