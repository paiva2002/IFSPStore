using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext 
        {
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Cidade> Cidades { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Grupo> Grupos { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<Venda> Vendas { get; set; }
            public DbSet<VendaItem> VendaItens { get; set; }

            public MyDbContext() 
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "kjhg456bta";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";

                if (!optionsBuilder.IsConfigured) 
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertCidade() 
        {
            using (var context = new MyDbContext()) 
            {
                var cidade = new Cidade
                {
                    Nome = "Birigui",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                cidade = new Cidade 
                {
                    Nome = "Araçatuba",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListCidades() 
        {
            using (var context = new MyDbContext()) 
            { 
                foreach(var cidade in context.Cidades) 
                { 
                    Console.WriteLine(JsonSerializer.Serialize(cidade));
                }
            }
        }

        [TestMethod]
        public void TestInsertClientes() 
        {
            using (var context = new MyDbContext())
            {
                var cidade = context.Cidades.FirstOrDefault(c => c.Id == 1);
                var cliente = new Cliente
                {
                    Nome = "Lucas Paiva",
                    Cidade = cidade,
                    Documento = "447.845.198-23",
                    Endereco = "Rua Afonso Pena, 928",
                    Bairro = "Centro"
                };
                context.Clientes.Add(cliente);

                cidade = context.Cidades.FirstOrDefault(c => c.Id == 2);
                cliente = new Cliente
                {
                    Nome = "kiko tesouro",
                    Cidade = cidade,
                    Documento = "55.830.857-59",
                    Endereco = "Rua Da Gentalia, 69",
                    Bairro = "kikolândia"
                };
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListClientes() 
        {
            using (var context = new MyDbContext()) 
            { 
                foreach(var cliente in context.Clientes) 
                {
                    Console.WriteLine(JsonSerializer.Serialize(cliente));
                }
            }
        }

        [TestMethod]
        public void TestInsertGrupo() 
        {
            using (var context = new MyDbContext())
            {
                var grupo = new Grupo
                {
                    Nome = "Atacado"
                };
                context.Grupos.Add(grupo);

                grupo = new Grupo
                {
                    Nome = "Varejo"
                };
                context.Grupos.Add(grupo);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListGrupos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var grupo in context.Grupos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(grupo));
                }
            }
        }

        [TestMethod]
        public void TestInsertProduto()
        {
            using (var context = new MyDbContext())
            {
                var grupo = context.Grupos.FirstOrDefault(c => c.Id == 1);
                var produto = new Produto
                {
                    Nome = "Roupa",
                    Preco = (float)50.00,
                    Quantidade = 20,
                    Datacompra = DateTime.Parse("2024-12-10"),
                    UnidadeVenda = "Centro"
                };
                context.Produtos.Add(produto);

                grupo = context.Grupos.FirstOrDefault(c => c.Id == 2);
                produto = new Produto
                {
                    Nome = "Tenis",
                    Preco = (float)100.00,
                    Quantidade = 20,
                    Datacompra = DateTime.Parse("2024-12-10"),
                    UnidadeVenda = "Altas Hora"
                };
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListProduto() 
        {
            using (var context = new MyDbContext())
            {
                foreach (var produto in context.Produtos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(produto));
                }
            }
        }

        [TestMethod]
        public void TestInsertUsuario() 
        {
            using (var context = new MyDbContext())
            {
                var usuario = new Usuario
                {
                    Nome = "Lucas Paiva",
                    Senha = "senha123",
                    Login = "paiva2002",
                    Email = "lucaspaiva@gmail.com",
                    DataCadastro = new DateTime(),
                    DataLogin = new DateTime(),
                    Ativo = true 
                };
                context.Usuarios.Add(usuario);

                usuario = new Usuario
                {
                    Nome = "Irineu",
                    Senha = "senha123",
                    Login = "Irineu2024",
                    Email = "voceNaoSabeENemEu@gmail.com",
                    DataCadastro = new DateTime(),
                    DataLogin = new DateTime(),
                    Ativo = true
                };
                context.Usuarios.Add(usuario);

                context.SaveChanges();
            }
        }
    }
}
