using Microsoft.AspNetCore.Mvc;
using SunnySystem.Data.Models;
using SunnySystem.Repository;
using System.Linq; namespace SunnySystem.RestServer.Controllers
{
 [Route("api/[controller]")]
 [ApiController]
 public class CustomerController : ControllerBase
 {
private readonly ICustomerRepository repository;public CustomerController(ICustomerRepository repository)
{
this.repository = repository;
} [HttpGet("{id}")]
 public ActionResult<Customer> Get(int id)
    {
        var customer = repository.GetByID(id);
        if (customer == null)
        {
        return NotFound();
    } return customer;
} [HttpPost]
public ActionResult<Customer> Post(Customer customer)
{
repository.Add(customer);
repository.Commit(); return CreatedAtAction(nameof(Get), new { id = customer.customerid }, customer);
} [HttpPut("{id}")]
public IActionResult Put(int id, Customer customer)
{
    if (id != customer.customerid)
    {
        return BadRequest();
    } repository.Update(customer);
    repository.Commit(); return NoContent();
} [HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var customer = repository.GetByID(id);
    if (customer == null)
    {
        return NotFound();
    }repository.Delete(customer);
    repository.Commit();return NoContent();
} [HttpGet("search")]
public ActionResult<Customer[]> Search(string query)
{
    var customers = repository.Find(c => c.name.Contains(query)).ToArray();
    return customers;
} [HttpPost("authenticate")]
public ActionResult<Customer> Authenticate(AuthenticationRequest request)
{
    var customer = repository.Authenticate(request.Email, request.Password);
    if (customer == null)
    {
        return Unauthorized();
    }return customer;
}
}public class AuthenticationRequest
{
public string Email { get; set; }
public string Password { get; set; } }
}