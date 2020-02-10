using System;
using Microsoft.Extensions.Configuration;
using Hospital.DAL.Context;
using Hospital.DAL.Extensions;
using Hospital.DAL.Interface;
using Hospital.DAL.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Hospital.DAL.Entities;

namespace Hospital.Infrastructure
{
    public static class ServiceInitializer
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(Lazy<>), typeof(Lazier<>));

           // services.AddTransient<IUnitOfWork, UnitOfWork>();
            
            /*
            services.AddTransient<IGameService, GameService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IPlatformTypeService, PlatformTypeService>();
            services.AddTransient<IPublisherService, PublisherService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IBasketService, BasketService>();
            */
            
            /*
            services.AddTransient<IRepository<Doctor>, IRepository<Doctor>>();
            
            services.AddTransient<IRepository<Comment>, Repository<Comment>>();
            services.AddTransient<IRepository<PlatformType>, Repository<PlatformType>>();
            services.AddTransient<IRepository<Genre>, Repository<Genre>>();
            services.AddTransient<IRepository<Publisher>, Repository<Publisher>>();
            services.AddTransient<IRepository<Order>, Repository<Order>>();
            services.AddTransient<IRepository<OrderDetail>, Repository<OrderDetail>>();
            */

            var connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
        }
    }
}