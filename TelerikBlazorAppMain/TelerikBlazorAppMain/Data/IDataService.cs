using System.Collections.Generic;
using TelerikBlazorAppMain.Models.Employee;
using TelerikBlazorAppMain.Models.Sales;

namespace TelerikBlazorAppMain.Data;
public interface IDataService
{
    List<Employee> GetEmployees();
    IEnumerable<Sale> GetSales();
    List<Team> GetTeams();
}
