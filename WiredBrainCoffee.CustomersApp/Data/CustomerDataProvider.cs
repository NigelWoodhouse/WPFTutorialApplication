using System.Collections.Generic;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.Data
{
  public interface ICustomerDataProvider
  {
    Task<IEnumerable<Customer>?> GetAllAsync();
  }

  public class CustomerDataProvider : ICustomerDataProvider
  {
    public async Task<IEnumerable<Customer>?> GetAllAsync()
    {
      await Task.Delay(100); // Simulate a bit of server work

      return new List<Customer>
      {
        new Customer{Id=1,FirstName="Rudy",LastName="Yang",IsDeveloper=true},
        new Customer{Id=2,FirstName="Angus",LastName="Burns"},
        new Customer{Id=3, FirstName="Nigel",LastName="Woodhouse",IsDeveloper=true},
        new Customer{Id=4,FirstName="Miles",LastName="Foster"},
        new Customer{Id=5,FirstName="Nirmal",LastName="Chaudhury",IsDeveloper=true},
        new Customer{Id=6,FirstName="Chen",LastName="Qian",IsDeveloper=true},
        new Customer{Id=7,FirstName="Michael",LastName="Thibeault",IsDeveloper=true},
        new Customer{Id=8,FirstName="Cyriac",LastName="Jinson",IsDeveloper=true},
        new Customer{Id=9,FirstName="Alyssa",LastName="Lee",IsDeveloper=true},
        new Customer{Id=10,FirstName="Mark",LastName="Li"},
        new Customer{Id=11,FirstName="Yiping",LastName="Zou",IsDeveloper=true},
      };
    }
  }
}
