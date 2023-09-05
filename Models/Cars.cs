using Utilities;

namespace Cars.Models
{
  public class Car
  {
    public string BrandName = "";
    public string VehicleName = "";
    public string VehicleYear = "";
    public string VehicleColor= "";
    public string VehicleDescription = "";
    public string VehicleExchange = "";
    public List<Car> cars = new List<Car>();

    public void CreateCar()
    {
      Console.WriteLine("Preencha os Seguintes Dados do Veículo: ");

      Utils utils = new();

      BrandName = utils.SimplefyCreateCar("Marca");
      VehicleName = utils.SimplefyCreateCar("Nome");
      VehicleColor = utils.SimplefyCreateCar("Cor");
      VehicleExchange =utils.SimplefyCreateCar("Câmbio");
      VehicleYear = utils.SimplefyCreateCar("Ano");
      VehicleDescription = utils.SimplefyCreateCar("Descrição", false);

      List<Car> car = new() {
         new Car {
          BrandName = BrandName, 
          VehicleName = VehicleName, 
          VehicleColor = VehicleColor,
          VehicleYear = VehicleYear,
          VehicleDescription = VehicleDescription,
          VehicleExchange = VehicleExchange,
        }
      };

      cars.AddRange(car);
    }

    public void GetCarById(int id = 0) {
      if (id >= cars.Count) {
        id = cars.Count - 1;
      }

      string CarValues = $"\nMarca: {cars[id].BrandName} \nNome: {cars[id].VehicleName} \nCor: {cars[id].VehicleColor} \nCâmbio: {cars[id].VehicleExchange} \nAno: {cars[id].VehicleYear} \nDescrição: {cars[id].VehicleDescription}";

      Console.WriteLine(CarValues);
    }

    public void GetAllCars() {
      int i = 0;

      int totalCars = cars.Count;

      if (totalCars >= 0) {
        foreach (Car car in cars) {
          Console.WriteLine($"\nID: {i} \nMarca: {car.BrandName} \nNome: {car.VehicleName} \nCor: {car.VehicleColor} \nCâmbio: {car.VehicleExchange} \nAno: {car.VehicleYear} \nDescrição: {car.VehicleDescription}\n");

          i++;
        }
      }
    }

    public int TotalCars() {
      int totalCars = cars.Count;

      return totalCars;
    }
  }
}