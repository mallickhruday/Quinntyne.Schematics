﻿using EventSourcing.CodeGenerator.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EventSourcing.CodeGenerator.Infrastructure.Services
{
    public interface ITemplateRepository
    {
        string[] Get(string filename);
    }

    public class TemplateRepository : ITemplateRepository
    {
        protected readonly INamingConventionConverter _namingConventionConverter;

        public TemplateRepository(INamingConventionConverter namingConventionConverter)
        {
            _namingConventionConverter = namingConventionConverter;
        }

        public string[] Get(string name)
        {
            var lines = new List<string>();
            var fullName = default(string);
            var assembly = default(Assembly);

            foreach(var assemblyName in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
            {
                foreach(Assembly _assembly in AppDomain.CurrentDomain.GetAssemblies())
                {                    
                    var embededResourceNames = _assembly.GetManifestResourceNames();
                    
                    if (embededResourceNames.Length > 0 && _assembly.GetManifestResourceNames().SingleOrDefault(x => x.Contains(name)) != null)
                    {
                        fullName = _assembly.GetManifestResourceNames().Single(x => x.Contains(name));
                        assembly = _assembly;
                    }
                }                
            }
           
            try
            {
                using (var stream = assembly.GetManifestResourceStream(fullName))
                {
                    using (var streamReader = new StreamReader(stream))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }
                    return lines.ToArray();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error:" + fullName);

                throw exception;

            }
        }
    }
}