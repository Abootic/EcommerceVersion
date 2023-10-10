
using AutoMapper.Extensions.ExpressionMapping;
using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Common;
using Microsoft.Extensions.DependencyInjection;

//hhhh

namespace EcommereceWeb.Application.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection ApplicationServices(this IServiceCollection services)
        {
            //services.AddAutoMapper(AppDomain.CurrentDomain.Load("EcommereceWeb.Application"));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(ex => { ex.AddExpressionMapping(); }, AppDomain.CurrentDomain.Load("EcommereceWeb.Application"));
             services.AddScoped<ICustomConventer, CustomConventer>();
            return services;
        }
    }
}
