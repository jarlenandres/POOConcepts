namespace POOConcepts.Core;

public class Date
{
    //Private atributes 
    private int _day;
    private int _month;
    private int _year;

    //Constructor method with overloading
    public Date()
    {
        Year = 1900;
        Month = 1;
        Day = 1;
    }

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    //Public properties
    public int Day
    {
        get => _day;
        set
        {
            _day = ValidateDay(value);
        }
    }
    public int Month
    {
        get => _month;
        set 
        {
            _month = ValidateMonth(value);
        }
    }
    public int Year 
    {
        get => _year;
        set 
        {
            _year = ValidateYear(value);
        }
    }

    //Sobreescribir el Méthod ToString
    public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}";
    }

    //Private method
    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
    }

    //Method to validate the year
    private int ValidateYear(int year)
    {
        if (year < 0)
        {
            throw new Exception("El año no puede ser negativo");
        }
        return year;
    }

    //Method to validate the month
    private int ValidateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new Exception($"El mes {month}, no es correcto");
        }
        return month;
    }

    //Method to validate the day
    private int ValidateDay(int day)
    {
        //Validate if the day is february 29
        if (day == 29 && IsLeapYear(Year))
        {
            return day;
        }

        // Validate if the day and month
        if ((day >= 1 && day <= 28 && Month == 2) ||
                (day >= 1 && day <= 30 && (Month == 4 || Month == 6 || Month == 9 || Month == 11)) ||
                (day >= 1 && day <= 31 && (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 9 || Month == 12)))
        {
            return day;
        }

            throw new Exception($"El día {day}, no es valido para el mes: {Month} y el año: {Year}");
    }

}
