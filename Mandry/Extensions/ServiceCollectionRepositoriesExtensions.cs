﻿using Mandry.Data.Repositories;
using Mandry.Interfaces.Repositories;

namespace Mandry.Extensions
{
    public static class ServiceCollectionRepositoriesExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepo, UsersRepository>();
        }
    }
}
