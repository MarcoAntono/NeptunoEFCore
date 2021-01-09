# NeptunoEFCore
.NET Core -  C# - Entity Framework

## Add-Migration name
*realiza la migracion *

## Update-Database 
*genera la bd en SQL Server*

## Scaffold-DbContext "Data Source=DESKTOP-QSUD1UP;Initial Catalog=neptuno;User ID=sa;Password=123;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
*mapea las tablas creadas de SQL Server a modelos c#*

## Scaffold-DbContext "Data Source=DESKTOP-QSUD1UP;Initial Catalog=neptuno;User ID=sa;Password=123;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force
*fuerza el mapeo las tablas creadas a modelos c# si es que esta ya existen*

## AddNewtonsoftJson para .NET Core 3.1
**./Startup/ConfigureServices(IServiceCollection services)**
```
public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<DetallePedidoServices>();
            services.AddTransient<ClientesServices>();


            //services.AddMvc(option => option.EnableEndpointRouting = false)
            //   .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
            //   .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddDbContext<neptunoContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("ConexionSQL")));
            //services.AddDbContext<neptunoContext>(options =>
            //       options.UseSqlServer(Configuration.GetConnectionString("ConexionSQL")));

            services.AddControllers()
             .AddNewtonsoftJson(options =>
             options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

        }
```
