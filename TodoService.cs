namespace TeamsLektion2;



/*

# Övning 1

public interface ITodoService
{
    void AddTodo();
}

public class TodoService : ITodoService
{
    public void AddTodo()
    {
        throw new NotImplementedException();
    }
}

*/

/*

# Övning 2

public interface ITodoService
{
    void AddTodo();
}

public class TodoService : ITodoService
{
    public void AddTodo()
    {
        throw new NotImplementedException();
    }
}

*/

/*

# Övning 3

using Microsoft.AspNetCore.Mvc;

public interface ITodoService
{
    int AddTodo(string description);

    Dictionary<int, string> GetTodos();
}

public class TodoService : ITodoService
{
    private int idCounter = 0;
    private Dictionary<int, string> todos = new Dictionary<int, string>();

    public int AddTodo(string description)
    {
        int id = idCounter++;
        todos[id] = description;
        return id;
    }

    public Dictionary<int, string> GetTodos()
    {
        return todos;
    }
}

[ApiController]
[Route("todo")]
public class TodoController : ControllerBase
{
    ITodoService todoService;

    public TodoController(ITodoService todoService)
    {
        this.todoService = todoService;
    }

    [HttpPost]
    public IActionResult CreateTodo([FromBody] string description)
    {
        int id = todoService.AddTodo(description);
        return Ok(id);
    }

    [HttpGet]
    public Dictionary<int, string> GetTodos()
    {
        return todoService.GetTodos();
    }
}

*/
