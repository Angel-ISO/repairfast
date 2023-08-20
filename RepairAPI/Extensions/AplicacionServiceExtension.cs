//using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Aplicacion.Repository;

namespace RepairAPI.Extensions;
public static  class AplicationServiceExtension
{ public static void ConfigureCors(this IServiceCollection services)=>
  services.AddCors(options =>
  {
    options.AddPolicy("CorsPolicy", Builder => 
      Builder.AllowAnyOrigin()
      .AllowAnyMethod()
      .AllowAnyHeader());
  });
}

    /* public static void AddAplicationService(this IServiceCollection services)
     {
        // services.AddScoped<IMoviesInterface, MovieRepository>();
        // services.AddScoped<IGenreInterface, GenreRepository>();
        // services.AddScoped<IDirectorInterface, DirectorRepository>();
         services.AddScoped<IUnitOfWork, UnitOfWork>();
     } */
     


   