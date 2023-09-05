using Cars.Models;

namespace Painels.Models
{
  class Menu
  {
    public string? option;
    public int id = 0;
    public string? input;

    Car car = new();

    public void Init() {
      Options();

      Choice();

      if (option != null) {
        Choices(option);
      }
    }

    public void Choices(string choice) {
      switch (choice) {
        case "1": 
          Console.Clear();

          car.CreateCar();

          Console.WriteLine("\nCadastro realizado com sucesso!");

          InitGoBack();

          break;
        case "2":
          if (car.cars.Count == 0) {
            Console.Clear();

            Console.WriteLine("Desculpe não temos veículos cadastrados no Momento ç.ç.");

            InitGoBack();

            break;
          }

          Console.Clear();

          car.GetAllCars();

          InitGoBack();

          break;
        case "3":
          if (car.cars.Count == 0) {
            Console.Clear();

            Console.WriteLine("Desculpe não temos veículos cadastrados no Momento ç.ç.");

            InitGoBack();

            break;
          }

          Console.Clear();

          Console.WriteLine("Digite o ID do veículo: ");

          input = Console.ReadLine();

          if (int.TryParse(input, out id))
          {
            car.GetCarById(id);

            InitGoBack();

            break;
          }

          Console.Clear();

          Console.WriteLine("Não encontrado!");

          InitGoBack();
         
          break;
        case "5":
          Console.Clear();

          break;
        case "": 
          Console.Clear();

          car.CreateCar();

          Console.WriteLine("\nCadastro realizado com sucesso!");

          InitGoBack();

          break;
        default:
          Console.Clear();

          break;
      }
    }

    public void Options() {
      Console.WriteLine("Olá, seja Bem vindo ao Veículus!");

      Console.WriteLine("\nEscolha uma das Seguintes opções que deseja em nosso Painel:");

      Console.WriteLine("\n1. Cadastro de Veiculos.");
      
      Console.WriteLine($"\n2. Carros cadastrados. {car.TotalCars()}");

      Console.WriteLine("\n3. Escolha um carro de nosso Estoque.");

      Console.WriteLine("\n5. Sair.");
    }

    public void InitGoBack() {
      GoBackMessages();

      Choice();
      
      if (option != null) 
      {
        GoBack(option);
      }
    }

    public void GoBackMessages() {
      Console.WriteLine("\n4. Voltar.");

      Console.WriteLine("\n5. Sair.");
    }

    public void GoBack(string choice) {
      switch (choice) 
      {
        case "4":
          Console.Clear();

          Options();

          Choice();

          if (option != null) 
          {
            Choices(option);
          }

          break;
        case "5":
          Console.Clear();

          break;
        case "":
          Console.Clear();

          Options();

          Choice();

          if (option != null) 
          {
            Choices(option);
          }

          break;
        default:
          Console.Clear();

          break;
      }
    }

    public string Choice() {
      option = Console.ReadLine();

      if (option == null) {
        return "";
      }

      return option;
    }
  }
}