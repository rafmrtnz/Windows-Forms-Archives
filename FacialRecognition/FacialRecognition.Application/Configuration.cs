using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacialRecognition.Application
{
    public static class Application
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
