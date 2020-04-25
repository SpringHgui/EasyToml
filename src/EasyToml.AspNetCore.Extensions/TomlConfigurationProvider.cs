using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasyToml.AspNetCore.Extensions
{
    public class TomlConfigurationProvider : FileConfigurationProvider
    {
        public TomlConfigurationProvider(TomlConfigurationSource source)
            : base(source)
        {
        }

        public override void Load(Stream stream)
        {
            try
            {
                base.Data = TomlConfigurationFileParser.Parse(stream);
            }
            catch (Exception innerException)
            {
                throw new FormatException(innerException.Message, innerException);
            }
        }
    }
}
