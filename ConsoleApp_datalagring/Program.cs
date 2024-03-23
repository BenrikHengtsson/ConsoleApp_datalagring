using ConsoleApp_datalagring.Data;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
var builder = Host.CreateDefaultBuilder().ConfigureServices(services => 
{

    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C_Sharp_Projects\ConsoleApp_datalagring\ConsoleApp_datalagring\Data\database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));

}).Build(); 