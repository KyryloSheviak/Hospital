using System;
using Microsoft.Extensions.Configuration;
using Hospital.DAL.Context;
using Hospital.DAL.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Hospital.DAL.Entities;
using Hospital.DAL.Interface;
using Hospital.DAL.UnitOfWork;
using Hospital.BL.Interface;
using Hospital.BL.Services;

namespace Hospital.Infrastructure
{
    public static class ServiceInitializer
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddTransient(typeof(Lazy<>), typeof(Lazier<>));

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IAdminService, AdminService>();

           // services.AddTransient<IRepository<ApplicationUser>, IRepository<ApplicationUser>>();

            /*
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IPlatformTypeService, PlatformTypeService>();
            services.AddTransient<IPublisherService, PublisherService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IBasketService, BasketService>();
            */

            /*            
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