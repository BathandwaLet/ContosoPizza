namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<List<Pizza>> Get(int id)
    {
        var pizza = PizzaService.Get(id);
    }
    
    // POST action

    // PUT action

    // DELETE action
}