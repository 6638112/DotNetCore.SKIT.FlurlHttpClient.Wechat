using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // ע��������
            services.AddOptions();
            services.Configure<Options.WechatOptions>(Configuration.GetSection(nameof(Options.WechatOptions)));

            // ע��ֲ�ʽ��
            services.AddSingleton<Services.DistributedLock.IDistributedLockFactory, Services.DistributedLock.Implements.DistributedLockFactory>();

            // ע��ִ���
            services.AddSingleton<Services.Repositories.IWechatAccessTokenEntityRepository, Services.Repositories.Implements.WechatAccessTokenEntityRepository>();

            // ע�빤�� HTTP �ͻ���
            services.AddHttpClient();
            services.AddSingleton<Services.HttpClients.IWechatApiHttpClientFactory, Services.HttpClients.Implements.WechatApiHttpClientFactory>();

            // ע���̨����
            services.AddHostedService<Services.BackgroundServices.WechatAccessTokenRefreshingBackgroundService>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
