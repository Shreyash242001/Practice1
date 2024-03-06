using MyApp.Models;
using Microsoft.AspNetCore.Mvc;
namespace MyApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index([FromServices] SiteDbContext site)
    {
        var selection = from cust in site.Employee
                        //where double.Parse(cust.Sal) > 20000
                        select new EmpList 
                        {
                            EId = cust.Id,
                            EName = cust.EmpName,
                            Ages = cust.Age,
                            Salary = cust.Sal
                        };
        return View(selection.ToList());
    }

    public IActionResult Register()
    {
        return View(new Emp());
    }


    [HttpPost]
    public IActionResult Register([FromServices] SiteDbContext site, Emp input)
    {
        if(ModelState.IsValid)
        {
            //var employee; //= site.Emp.Find(input.Id);
            // if(employee is null)
            // {
                var employee = input;
                site.Employee.Add(employee);
            // }
           // employee.Visits.Add(new Emp());
            site.SaveChanges();
            return RedirectToAction("Index");
        }
        return Register();
    }
}