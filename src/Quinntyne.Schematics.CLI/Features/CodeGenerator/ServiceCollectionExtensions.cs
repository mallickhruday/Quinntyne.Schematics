﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Quinntyne.Schematics.CLI.Features.CodeGenerator
{
    public static class ServiceCollectionExtensions
    {
        public static void UseCodeGeneratorFeature(this IServiceCollection services)
        {
            services.AddTransient<IValidator<GenerateCodeGeneratorCommand.Request>, GenerateCodeGeneratorCommand.Validator>();
        }
    }
}
