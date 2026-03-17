using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromServices] IRegisterExpenseUseCase useCase, [FromBody] RequestExpenseJson request)
    {
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    /*
    [HttpPut]
    public IActionResult Update([FromBody] RequestExpenseJson request)
    {

        return Created();
    }
    [HttpGet]
    public IActionResult Get([FromBody] RequestExpenseJson request)
    {

        return Created();
    }
    [HttpDelete]
    public IActionResult Delete([FromBody] RequestExpenseJson request)
    {

        return Created();
    }
    */
}
