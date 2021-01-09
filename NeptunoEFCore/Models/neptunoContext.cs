using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NeptunoEFCore.Models
{
    public partial class neptunoContext : DbContext
    {
        public neptunoContext()
        {
        }

        public neptunoContext(DbContextOptions<neptunoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Compañiasdeenvio> Compañiasdeenvios { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Detallesdepedido> Detallesdepedidos { get; set; }
        public virtual DbSet<Distrito> Distritos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<Provincium> Provincia { get; set; }
        public virtual DbSet<Sucursale> Sucursales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("name = ConexionSQL");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Idcategoria)
                    .HasName("PK__categori__140587C79840CF4E");

                entity.ToTable("categorias");

                entity.Property(e => e.Idcategoria)
                    .ValueGeneratedNever()
                    .HasColumnName("idcategoria");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombrecategoria)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombrecategoria");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__clientes__885457EE8F4B0ADE");

                entity.ToTable("clientes");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("idCliente");

                entity.Property(e => e.CargoContacto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompañia)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreContacto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Compañiasdeenvio>(entity =>
            {
                entity.HasKey(e => e.IdCompañiaEnvios)
                    .HasName("PK__compañia__379610A1C90BBE58");

                entity.ToTable("compañiasdeenvios");

                entity.Property(e => e.IdCompañiaEnvios)
                    .ValueGeneratedNever()
                    .HasColumnName("idCompañiaEnvios");

                entity.Property(e => e.NombreCompañia)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombreCompañia");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("departamento");

                entity.Property(e => e.Id)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Detallesdepedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("detallesdepedidos");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("descuento");

                entity.Property(e => e.Idpedido).HasColumnName("idpedido");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Preciounidad)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("preciounidad");

                entity.HasOne(d => d.IdpedidoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idpedido)
                    .HasConstraintName("fk_1");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idproducto)
                    .HasConstraintName("fk_2");
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.ToTable("distrito");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.DepartmentId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("department_id")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ProvinceId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("province_id")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__Empleado__CE6D8B9EBFED7C05");

                entity.Property(e => e.IdEmpleado).ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codPostal");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Extension)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaContratacion).HasColumnType("date");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notas)
                    .HasColumnType("text")
                    .HasColumnName("notas");

                entity.Property(e => e.Pais)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.Property(e => e.SucursalId).HasColumnName("sucursalId");

                entity.Property(e => e.SueldoBasico)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("sueldoBasico");

                entity.Property(e => e.TelDomicilio)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.SucursalId)
                    .HasConstraintName("FK_Pedido_pedidos");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__Pedidos__9D335DC3CD495A7A");

                entity.Property(e => e.IdPedido).ValueGeneratedNever();

                entity.Property(e => e.Cargo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CiudadDestinatario)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CodPostalDestinatario)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Destinatario)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionDestinatario)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEntrega).HasColumnType("date");

                entity.Property(e => e.FechaEnvio).HasColumnType("date");

                entity.Property(e => e.FechaPedido).HasColumnType("date");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDestinatario)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RegionDestinatario)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SucursalId).HasColumnName("sucursalId");

                entity.HasOne(d => d.FormaEnvioNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.FormaEnvio)
                    .HasConstraintName("fk_4");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_5");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_6");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.SucursalId)
                    .HasConstraintName("FK_Pedido_sucursales");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("PK__producto__DC53BE3CCCFAB327");

                entity.ToTable("productos");

                entity.Property(e => e.Idproducto)
                    .ValueGeneratedNever()
                    .HasColumnName("idproducto");

                entity.Property(e => e.CantidadPorUnidad)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cantidadPorUnidad");

                entity.Property(e => e.CategoriaProducto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("categoriaProducto");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.NivelNuevoPedido).HasColumnName("nivelNuevoPedido");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombreProducto");

                entity.Property(e => e.PrecioUnidad)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precioUnidad");

                entity.Property(e => e.Suspendido).HasColumnName("suspendido");

                entity.Property(e => e.UnidadesEnExistencia).HasColumnName("unidadesEnExistencia");

                entity.Property(e => e.UnidadesEnPedido).HasColumnName("unidadesEnPedido");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("fk_7");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("fk_3");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK__proveedo__A3FA8E6B3CCF709F");

                entity.ToTable("proveedores");

                entity.Property(e => e.IdProveedor)
                    .ValueGeneratedNever()
                    .HasColumnName("idProveedor");

                entity.Property(e => e.Cargocontacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cargocontacto");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codPostal");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.NombreCompañia)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombreCompañia");

                entity.Property(e => e.Nombrecontacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombrecontacto");

                entity.Property(e => e.Paginaprincipal)
                    .HasColumnType("text")
                    .HasColumnName("paginaprincipal");

                entity.Property(e => e.Pais)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.ToTable("provincia");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.DepartmentId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("department_id")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Sucursale>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__sucursal__06370DAD5731AE4F");

                entity.ToTable("sucursales");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.DepartamentoId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DistritoId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinciaId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Sucursales)
                    .HasForeignKey(d => d.DepartamentoId)
                    .HasConstraintName("FK_SUCURSAL_DEPARTAMENTO");

                entity.HasOne(d => d.Distrito)
                    .WithMany(p => p.Sucursales)
                    .HasForeignKey(d => d.DistritoId)
                    .HasConstraintName("FK_SUCURSAL_DISTRITO");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Sucursales)
                    .HasForeignKey(d => d.ProvinciaId)
                    .HasConstraintName("FK_SUCURSAL_PROVINCIA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
