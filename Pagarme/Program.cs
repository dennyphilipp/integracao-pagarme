using PagarMe;
using System;

namespace Pagarme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pagar Me");
            GerarBoleto();
            Console.ReadLine();
        }

        private static void GerarBoleto()
        {
            PagarMeService.DefaultApiKey = "ak_test_5Dqy14RUaChp63GxCrRZ8ZM5Sdwb6C";
            PagarMeService.DefaultEncryptionKey = "ek_test_fKmFOVJviO55L78nvs0zRBSaqj2xTd";

            Transaction transaction = new Transaction();

            transaction.Amount = 2100;
            transaction.Card = new Card
            {
                Id = "card_cj95mc28g0038cy6ewbwtwwx2",
                
            };

            transaction.Customer = new Customer
            {
                ExternalId = "#3311",
                Name = "Rick",
                Type = CustomerType.Individual,
                Country = "br",
                Email = "rick@morty.com",
                Documents = new[]
              {
    new Document{
      Type = DocumentType.Cpf,
      Number = "30621143049"
    },
    new Document{
      Type = DocumentType.Cnpj,
      Number = "83134932000154"
    }
  },
                PhoneNumbers = new string[]
              {
    "+5511982738291",
    "+5511829378291"
              },
                Birthday = new DateTime(1991, 12, 12).ToString("yyyy-MM-dd")
            };

            transaction.Billing = new Billing
            {
                Name = "Morty",
                Address = new Address()
                {
                    Country = "br",
                    State = "sp",
                    City = "Cotia",
                    Neighborhood = "Rio Cotia",
                    Street = "Rua Matrix",
                    StreetNumber = "213",
                    Zipcode = "04250000"
                }
            };

            var Today = DateTime.Now;

            transaction.Shipping = new Shipping
            {
                Name = "Rick",
                Fee = 100,
                DeliveryDate = Today.AddDays(4).ToString("yyyy-MM-dd"),
                Expedited = false,
                Address = new Address()
                {
                    Country = "br",
                    State = "sp",
                    City = "Cotia",
                    Neighborhood = "Rio Cotia",
                    Street = "Rua Matrix",
                    StreetNumber = "213",
                    Zipcode = "04250000"
                }
            };

            transaction.Item = new[]
            {
  new Item()
  {
    Id = "1",
    Title = "Little Car",
    Quantity = 1,
    Tangible = true,
    UnitPrice = 1000
  },
  new Item()
  {
    Id = "2",
    Title = "Baby Crib",
    Quantity = 1,
    Tangible = true,
    UnitPrice = 1000
  }
};

            transaction.Save();

        }
    }
}
