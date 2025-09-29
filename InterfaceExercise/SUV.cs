namespace InterfaceExercise;

public class SUV : ICompany, IVehicle
{
    public string Motto { get; set; }
    public string Headquarters { get; set; }
    public int Year { get; set; }
    public string Model { get; set; }
    public string Make { get; set; }
    public string RideColor { get; set; }
    public string LicensePlate { get; set; }
    public int Mileage { get; set; }
}