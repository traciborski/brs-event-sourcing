using Microsoft.Extensions.DependencyInjection;
using WaterHeating.BrsXXX;

namespace WaterHeating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            services.AddBrsXXX();
        }
    }
}
