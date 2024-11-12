using AutoMapper;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Services;
using IFSPStore.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices() 
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(Options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "kjhg456bta";
                var strCon = $"Server={server}; Port={port}; Database={database};" +
                $"Uid={username}; Pwd={password}";
                
                Options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt => 
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, Usuario>();
            }).CreateMapper());
            return services.BuildServiceProvider();
        }
        [TestMethod]
        public void TestInsertUsuario() 
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();

            var usuario = new Usuario 
            { 
                Nome = "Lucas",
                Login = "Paiva",
                Email = "lucaspaiva@gmail.com",
                Senha = "123Paiv@",
                DataCadastro = DateTime.Now
            };

            var result = usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelecUsuario() 
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();

            var result = usuarioService.Get<Usuario>();
            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}
