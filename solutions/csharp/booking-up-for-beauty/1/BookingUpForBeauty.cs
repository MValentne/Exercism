using System;

static class Appointment
{
    
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if(appointmentDate < DateTime.Now){
            return true;
        } else {
            return false;
        }
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if ((appointmentDate.Hour >= 12) && (appointmentDate.Hour < 18)){
            return true;
        } else {
            return false;
        }
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.Month}/{appointmentDate.Day}/{appointmentDate.Year}"
        + $" {appointmentDate.ToString("h:mm:ss tt")}.";
    }

    public static DateTime AnniversaryDate()
    {
        DateTime existingDate = DateTime.Now;
        DateTime anniversary = new DateTime(existingDate.Year, 9, 15, 0, 0, 0);
        return anniversary;
    }
}
