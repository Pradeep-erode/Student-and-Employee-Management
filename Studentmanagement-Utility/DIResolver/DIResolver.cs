using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Studentmanagement.Core.IRepository;
using Studentmanagement.Core.Iservices;
using Studentmanagement.Repository.Repositories;
using Studentmanagement.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Studentmanagement_Utility.DIResolver
{
    public class DIResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<StudentIService, StudentinfoServices> ();
            services.AddScoped <StudentIRepository, StudentinfoRepository > ();
        }
    }
}
