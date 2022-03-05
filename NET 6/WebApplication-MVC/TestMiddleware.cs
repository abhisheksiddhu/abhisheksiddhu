namespace WebApplication_MVC;

public class TestMiddleware
{
	private readonly RequestDelegate next;

	public TestMiddleware(RequestDelegate next)
	{
		this.next = next;
	}

	public async Task InvokeAsync(HttpContext context)
	{
		Console.WriteLine("Before request");
		await next(context);
		Console.WriteLine("After request");
	}
}
