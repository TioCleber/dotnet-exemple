namespace Utilities
{
  class Utils 
  {
    string? variable;
    
    public string SimplefyCreateCar(string value, bool isRequired = true)
    {
      Console.WriteLine($"\n{value}: ");
      variable = Console.ReadLine();

      while ((variable == "" || variable == null) && isRequired) {
        Console.WriteLine($"\nPor favor, preencha o valor de ({value}): ");
        variable = Console.ReadLine();
      };

      if (variable == null) {
        return "";
      }

      return variable;
    }
  }
}