﻿using MediatR;
using Quinntyne.Schematics.CLI.Features.FullStackSolution.Section1;
using System;
using System.Collections.Generic;

namespace Quinntyne.Schematics.CLI.Features.FullStackSolution
{
    public class RegisterFullStackSolutionCommands
    {
        public static void Register(Dictionary<string, Func<IOptions, IRequest>> dictionary)
        {
            dictionary.Add("sln", new Func<IOptions, IRequest>((options) => new GenerateSolutionCommand.Request(options)));
            dictionary.Add("class", new Func<IOptions, IRequest>((options) => new GenerateClassCommand.Request(options)));
            dictionary.Add("file", new Func<IOptions, IRequest>((options) => new GenerateFileCommand.Request(options)));
            dictionary.Add("add-identity", new Func<IOptions, IRequest>((options) => new AddIdentityCommand.Request(options)));
            dictionary.Add("add-core", new Func<IOptions, IRequest>((options) => new AddClientCoreCommand.Request(options)));
            dictionary.Add("add-shared", new Func<IOptions, IRequest>((options) => new AddClientSharedCommand.Request(options)));
            dictionary.Add("add-dashboard", new Func<IOptions, IRequest>((options) => new AddDashboardCommand.Request(options)));
            dictionary.Add("add-event-store", new Func<IOptions, IRequest>((options) => new AddEventStoreCommand.Request(options)));
            dictionary.Add("add-digital-assets", new Func<IOptions, IRequest>((options) => new AddDigitialAssetsCommand.Request(options)));
            dictionary.Add("add-extensions", new Func<IOptions, IRequest>((options) => new AddExtensionsCommand.Request(options)));

            RegisterSection1Commands.Register(dictionary);
        }
    }
}
