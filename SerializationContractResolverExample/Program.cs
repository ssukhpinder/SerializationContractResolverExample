using Newtonsoft.Json;
using SerializationContractResolverExample.ContractResolver;
using System;

namespace SerializationContractResolverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerInfo customerInfo = new CustomerInfo()
            {
                FirstName = "Sukhpinder",
                LastName = "Singh",
                MobileNumbers = new System.Collections.Generic.List<string>() {
                 "33443434343"
                }
            };

            var responseDefaultResolver = JsonConvert.SerializeObject(customerInfo, Formatting.Indented);

            var responseUpperCase = JsonConvert.SerializeObject(customerInfo, Formatting.Indented, new JsonSerializerSettings()
            {
                ContractResolver = new UpperCaseResolver<CustomerInfo>()
            });


            var responseLowerCase = JsonConvert.SerializeObject(customerInfo, Formatting.Indented, new JsonSerializerSettings()
            {
                ContractResolver = new LowerCaseResolver<CustomerInfo>()
            });

            Console.WriteLine(responseLowerCase);

            Console.ReadLine();
        }
    }
}
