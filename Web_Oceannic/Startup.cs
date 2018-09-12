using Application.Implementation;
using Application.Interface;
using Data.Repositories;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Domain.Models;
using Microsoft.AspNetCore.Http.Features;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;
using Microsoft.AspNet.OData.Extensions;

namespace Web_Oceannic
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //AutoMapperConfig.RegisterMapping();
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Bank>("Bank");
            builder.EntitySet<Currency>("Coin");
            builder.EntitySet<Deposit>("Deposit");
            //builder.EntitySet<DepositWalletCurrency>("DepositWalletCurrency");
            builder.EntitySet<EntitieBase>("EntitieBase");
            builder.EntitySet<ImgUser>("ImgUser");
            builder.EntitySet<User>("User");
            builder.EntitySet<Wallet>("Wallet");
            builder.EntitySet<Transfer>("Transfer");

            var function = builder.Function("TotalCurrency");

            function.Parameter<int>("userId");
            function.Parameter<int>("currencyId");

            function.Returns<double>();

                

            return builder.GetEdmModel(); ;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //Application
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IBankAppService, BankAppService>();
            services.AddScoped<ICurrencyAppService, CurrencyAppService>();
            services.AddScoped<IDepositAppService, DepositAppService>();
            services.AddScoped<IWalletAppService, WalletAppService>();
            services.AddScoped<ITransferAppService, TransferAppService>();
            services.AddScoped<ITransactionAppService, TransactionAppService>();

            //Repository
            services.AddScoped<IUserRepository, UsersRepository>();
            services.AddScoped<IBankRepository, BankRepository>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<IDepositRepository, DepositRepository>();
            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddScoped<ITransferRepository, TransferRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();

            //Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBankService, BankService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<IDepositService, DepositService>();
            services.AddScoped<IWalletService, WalletService>();
            services.AddScoped<ITransferService, TransferService>();
            services.AddScoped<ITransactionService, TransactionService>();

             var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapper.AutoMapperConfig());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => options.LoginPath= "/Account/Login");

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSession(s => s.IdleTimeout = TimeSpan.FromMinutes(1200));

            services.Configure<FormOptions>(x =>
            {
                x.BufferBodyLengthLimit = long.MaxValue;
                x.KeyLengthLimit = int.MaxValue;
                x.MemoryBufferThreshold = int.MaxValue;
                x.MultipartBodyLengthLimit = long.MaxValue;
                x.MultipartBoundaryLengthLimit = int.MaxValue;
                x.MultipartHeadersCountLimit = int.MaxValue;
                x.MultipartHeadersLengthLimit = int.MaxValue;
                x.ValueCountLimit = int.MaxValue;
                x.ValueLengthLimit = int.MaxValue;
            });

            services.AddOData();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(b =>
            {
                b.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
                b.MapODataServiceRoute("v2", "v2", GetEdmModel());
                b.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
