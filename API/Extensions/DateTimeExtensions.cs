using System;

namespace API.Extensions;

public static class DateTimeExtensions
{
    public static int CalculateAge(this DateOnly dob)
    {
        var today = DateOnly.FromDateTime(DateTime.UtcNow);
        int age = today.Year - dob.Year;

        // Check if the birthday has not occurred yet this year
        if (today < dob.AddYears(age))
        {
            age--;
        }

        return age;
    }
}
