﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using VacationRental.Api.Models;
using VacationRental.Data;

namespace VacationRental.Api
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
            services.AddDbContext<VacationRentalContext>(opt => opt.UseInMemoryDatabase());
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(opts => opts.SwaggerDoc("v1", new Info { Title = "Vacation rental information", Version = "v1" }));

            services.AddSingleton<IDictionary<int, RentalViewModel>>(new Dictionary<int, RentalViewModel>());
            services.AddSingleton<IDictionary<int, BookingViewModel>>(new Dictionary<int, BookingViewModel>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var context = app.ApplicationServices.GetService<VacationRentalContext>();
            AddTestData(context);

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(opts => opts.SwaggerEndpoint("/swagger/v1/swagger.json", "VacationRental v1"));
        }

        private static void AddTestData(VacationRentalContext context)
        {
            var testUnit1 = new Domain.Entities.Unit();
            var testUnit2 = new Domain.Entities.Unit();
            var testUnit3 = new Domain.Entities.Unit();

            var testRental1 = new Domain.Entities.Rental()
            {
                Units = new List<Domain.Entities.Unit>()
                {
                    testUnit1,
                    testUnit2,
                    testUnit3
                }
            };

            var testBooking1 = new Domain.Entities.Booking()
            {
                BookingDates = new List<System.DateTime>()
                {
                    new System.DateTime(2022, 02, 20),
                    new System.DateTime(2022, 02, 21),
                    new System.DateTime(2022, 02, 22),
                    new System.DateTime(2022, 02, 23),
                    new System.DateTime(2022, 02, 24)
                },
                PreparationTimeDates = new List<System.DateTime>()
                {
                    new System.DateTime(2022, 02, 25),
                    new System.DateTime(2022, 02, 26)
                },
                Unit = testUnit2
            };
        }
    }
}
