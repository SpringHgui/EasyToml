using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using System;

namespace EasyToml.AspNetCore.Extensions
{
    public static class TomlConfigurationExtensions
    {
        public static IConfigurationBuilder AddTomlFile(this IConfigurationBuilder builder, string path, bool optional)
        {
            return builder.AddTomlFile(null, path, optional);
        }

        public static IConfigurationBuilder AddTomlFile(this IConfigurationBuilder builder, IFileProvider provider, string path, bool optional)
        {
            if (builder == null)
                throw new ArgumentNullException("builder");

            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("InvalidFilePath", "path");

            return builder.AddTomlFile(delegate (TomlConfigurationSource s)
            {
                s.FileProvider = provider;
                s.Path = path;
                s.Optional = optional;
                s.ReloadOnChange = false;
                s.ResolveFileProvider();
            });
        }

        public static IConfigurationBuilder AddTomlFile(this IConfigurationBuilder builder, Action<TomlConfigurationSource> configureSource)
        {
            return builder.Add(configureSource);
        }
    }
}
