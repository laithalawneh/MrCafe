using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MrCafe.core.common;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using MrCafe.infra.common;
using MrCafe.Infra.Repository;
using MrCafe.Infra.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrCafe.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAdressService, AdressService>();
            services.AddScoped<IAdressRepository, AdressRepository>();

            services.AddScoped<ICafesService, CafesService>();
            services.AddScoped<ICafesRepository, CafesRepository>();

            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICartRepository, CartRepository>();

            services.AddScoped<ICartOrderService, CartOrderService>();
            services.AddScoped<ICartOrderRepository, CartorderRepository>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<ICountactUsService, CountactUsService>();
            services.AddScoped<ICountactUsRepository, CountactUsRepository>();

            services.AddScoped<IDeliveryService, DeliveryService>();
            services.AddScoped<IDeliveryRepository, DeliveryRepository>();

            services.AddScoped<IDeliveryOrderService, DeliveryOrderService>();
            services.AddScoped<IDeliveryOrderRepository, DeliveryOrderRepository>();

            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ILoginRepository, LoginRepository>();

            services.AddScoped<IOrdersService, OrdersService>();
            services.AddScoped<IOrdersRepository, OrdersRepository>();

            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IProductOrderService, ProductOrderService>();
            services.AddScoped<IProductOrderRepository, ProductOrderRepository>();

            services.AddScoped<IRollService, RollService>();
            services.AddScoped<IRollRepository, RollRepository>();

            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();

            services.AddScoped<ITransactionsService, TransactionsService>();
            services.AddScoped<ITransactionsRepository, TransactionsRepository>();

            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IUsersRepository, UsersRepository>();

            services.AddScoped<IWalletService, WalletService>();
            services.AddScoped<IWalletRepository, WalletRepository>();

            services.AddScoped<IWebsiteService, WebsiteService>();
            services.AddScoped<IWebsiteRepository, WebsiteRepository>();

            services.AddScoped<IdbContext, dbContext>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
