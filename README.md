# NeptunoEFCore
.NET Core -  C# - Entity Framework

realiza la migracion
Add-Migration name("value") 

genera la bd en SQL Server
Update-Database 

//mapea las tablas creadas de SQL Server a modelos c#
Scaffold-DbContext "Data Source=DESKTOP-QSUD1UP;Initial Catalog=neptuno;User ID=sa;Password=123;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

//fuerza el mapeo las tablas creadas a modelos c# si es que esta ya existen
Scaffold-DbContext "Data Source=DESKTOP-QSUD1UP;Initial Catalog=neptuno;User ID=sa;Password=123;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force

// AddNewtonsoftJson para .NET Core 3.1
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
