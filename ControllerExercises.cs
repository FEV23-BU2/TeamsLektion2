namespace TeamsLektion2;



/*

# Övning 1

using Microsoft.AspNetCore.Mvc;

[ApiController]
public class TestController : ControllerBase { }

*/

/*

# Övning 2

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string HelloWorld()
    {
        return "Hello World!";
    }
}

*/

/*

# Övning 3

using Microsoft.AspNetCore.Mvc;

public class HelloWorldMessage
{
    public string Message { get; set; } = "";
}

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    [HttpGet]
    public HelloWorldMessage HelloWorld()
    {
        HelloWorldMessage message = new HelloWorldMessage();
        message.Message = "Hello World!";
        return message;
    }
}

*/

/*

# Övning 4

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string HelloWorld()
    {
        Response.Headers.Add("Content-Type", "text/html");
        return "<!doctype html><html><head></head><body><h1>Welcome!</h1><script>console.log('Hello World!');</script></body></html>";
    }
}

*/

/*

# Övning 5
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    [HttpGet("{name}")]
    public string Greeting(string name)
    {
        return "Hello, " + name;
    }
}

*/

/*

# Övning 6
using Microsoft.AspNetCore.Mvc;

public class ResponseMessage
{
    public string Message { get; set; } = "";
}

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    [HttpGet("{name}")]
    public ResponseMessage Greeting(string name)
    {
        ResponseMessage message = new ResponseMessage();
        message.Message = "Hello, " + name;
        return message;
    }
}

*/

/*

# Övning 7

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    [HttpGet]
    public int Add([FromQuery] int a, [FromQuery] int b)
    {
        return a + b;
    }
}

*/

/*

# Övning 8

using Microsoft.AspNetCore.Mvc;

public class MathResult
{
    public string Operation { get; set; } = "";
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public int Result { get; set; }
}

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult DoMath([FromQuery] int a, [FromQuery] int b, [FromQuery] string operation)
    {
        MathResult result = new MathResult();
        result.Operation = operation;
        result.FirstNumber = a;
        result.SecondNumber = b;

        if (operation == "addition")
        {
            result.Result = a + b;
        }
        else if (operation == "subtraction")
        {
            result.Result = a - b;
        }
        else if (operation == "multiplication")
        {
            result.Result = a * b;
        }
        else if (operation == "division")
        {
            result.Result = a / b;
        }
        else
        {
            return BadRequest();
        }

        return Ok(result);
    }
}

*/

/*

# Övning 9

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    private CounterService service;

    public TestController(CounterService service)
    {
        this.service = service;
    }

    [HttpGet]
    public int Count()
    {
        return service.counter++;
    }
}

public class CounterService
{
    public int counter = 0;
}

*/

/*

# Övning 10

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    private HistoryService service;

    public TestController(HistoryService service)
    {
        this.service = service;
    }

    [HttpPost("{text}")]
    public List<string> Remember(string text)
    {
        service.history.Add(text);
        return service.history;
    }
}

public class HistoryService
{
    public List<string> history = new List<string>();
}

*/
