using POOConcepts.Core;

try
{
    var date1 = new Date(2025, 9, 2);
    var date2 = new Date(2028, 2, 29);

    Console.WriteLine(date1.ToString());
    Console.WriteLine(date2.ToString());
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
