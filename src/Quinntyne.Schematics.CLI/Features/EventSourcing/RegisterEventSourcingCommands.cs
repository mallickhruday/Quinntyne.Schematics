﻿using MediatR;
using System;
using System.Collections.Generic;

namespace Quinntyne.Schematics.CLI.Features.EventSourcing
{
    public class RegisterEventSourcingCommands
    {
        public static void Register(Dictionary<string, Func<IOptions, IRequest>> dictionary)
        {
            dictionary.Add("dto", new Func<IOptions, IRequest>((options) => new GenerateApiModelCommand.Request(options)));
            dictionary.Add("model", new Func<IOptions, IRequest>((options) => new GenerateModelCommand.Request(options)));
            dictionary.Add("create", new Func<IOptions, IRequest>((options) => new GenerateCreateCommand.Request(options)));
            dictionary.Add("update", new Func<IOptions, IRequest>((options) => new GenerateUpdateCommand.Request(options)));
            dictionary.Add("saved", new Func<IOptions, IRequest>((options) => new GenerateSavedEventCommand.Request(options)));
            dictionary.Add("get", new Func<IOptions, IRequest>((options) => new GenerateGetQueryCommand.Request(options)));
            dictionary.Add("getbyid", new Func<IOptions, IRequest>((options) => new GenerateGetByIdQueryCommand.Request(options)));
            dictionary.Add("feature", new Func<IOptions, IRequest>((options) => new GenerateFeatureCommand.Request(options)));
            dictionary.Add("remove", new Func<IOptions, IRequest>((options) => new GenerateRemoveCommand.Request(options)));
            dictionary.Add("removed", new Func<IOptions, IRequest>((options) => new GenerateRemovedEventCommand.Request(options)));
            dictionary.Add("tests", new Func<IOptions, IRequest>((options) => new GenerateTestsCommand.Request(options)));
            dictionary.Add("controller", new Func<IOptions, IRequest>((options) => new GenerateControllerCommand.Request(options)));
            dictionary.Add("gateway", new Func<IOptions, IRequest>((options) => new GenerateGatewayControllerCommand.Request(options)));
            dictionary.Add("query", new Func<IOptions, IRequest>((options) => new GenerateQueryCommand.Request(options)));
            dictionary.Add("command", new Func<IOptions, IRequest>((options) => new GenerateCommand.Request(options)));
            dictionary.Add("startup", new Func<IOptions, IRequest>((options) => new GenerateStartUpCommand.Request(options)));
            dictionary.Add("appsettings", new Func<IOptions, IRequest>((options) => new GenerateAppSettingsCommand.Request(options)));
            dictionary.Add("program", new Func<IOptions, IRequest>((options) => new GenerateProgramCommand.Request(options)));
            dictionary.Add("root-program", new Func<IOptions, IRequest>((options) => new GenerateRootProgramCommand.Request(options)));
            dictionary.Add("seed", new Func<IOptions, IRequest>((options) => new GenerateSeedConfigurationCommand.Request(options)));
            dictionary.Add("client", new Func<IOptions, IRequest>((options) => new GenerateClientCommand.Request(options)));
            dictionary.Add("unittests", new Func<IOptions, IRequest>((options) => new GenerateUnitTestsCommand.Request(options)));
            dictionary.Add("event", new Func<IOptions, IRequest>((options) => new GenerateDomainEventCommand.Request(options)));
            dictionary.Add("handler", new Func<IOptions, IRequest>((options) => new GenerateDomainEventHandlerCommand.Request(options)));
            dictionary.Add("integration", new Func<IOptions, IRequest>((options) => new GenerateIntegrationEventCommand.Request(options)));
            dictionary.Add("saga", new Func<IOptions, IRequest>((options) => new GenerateSagaCommand.Request(options)));

        }
    }
}
