using CBS.EmailAPI.Messaging;

namespace CBS.EmailAPI.Extension
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseAzureServiceBusConsumer(this IApplicationBuilder app)
        {
            var hostApplicationLife = app.ApplicationServices.GetService<IHostApplicationLifetime>();

            hostApplicationLife.ApplicationStarted.Register(() =>
            {
                var scope = app.ApplicationServices.CreateScope();
                var serviceBusConsumer = scope.ServiceProvider.GetRequiredService<IAzureServiceBusConsumer>();
                serviceBusConsumer.Start();
            });

            hostApplicationLife.ApplicationStopping.Register(() =>
            {
                var scope = app.ApplicationServices.CreateScope();
                var serviceBusConsumer = scope.ServiceProvider.GetRequiredService<IAzureServiceBusConsumer>();
                serviceBusConsumer.Stop();
            });

            return app;
        }
    }
}
