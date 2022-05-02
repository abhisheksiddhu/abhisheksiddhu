using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.FeatureFilters;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
	ApplicationName = typeof(Program).Assembly.FullName,
	ContentRootPath = Path.GetFullPath(Directory.GetCurrentDirectory()),
	WebRootPath = "wwwroot",
	Args = args
});

//builder.WebHost.ConfigureAppConfiguration(config =>
//{
//	var connection = builder.Configuration.GetConnectionString("AppConfig");
//	config.AddAzureAppConfiguration(options =>
//		options.Connect(connection).UseFeatureFlags(featureFlagOptions =>
//		{
//			featureFlagOptions.CacheExpirationInterval = TimeSpan.FromSeconds(2);
//		}));
//});

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services
	.AddFeatureManagement(builder.Configuration.GetSection("FeatureManagement"))
	.AddFeatureFilter<PercentageFilter>()
	.AddFeatureFilter<TimeWindowFilter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
