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
    public class EmployeeDIResolver
    {

        public static void ConfigureServices(IServiceCollection service)
        {
            service.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            service.AddScoped<EmployeeIService, EmployeeServices>();
            service.AddScoped<EmployeeIRepository, EmployeeRepository>();
        }
    }
}
