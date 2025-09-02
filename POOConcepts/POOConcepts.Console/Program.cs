using POOConcepts.Core;

try
{
    var date1 = new Date();
    var date2 = new Date(2025, 2, 29);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
