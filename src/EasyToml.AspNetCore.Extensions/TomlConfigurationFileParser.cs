using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasyToml.AspNetCore.Extensions
{
    public class TomlConfigurationFileParser
    {
        public static IDictionary<string, string> Parse(Stream input)
        {
            return new TomlConfigurationFileParser().ParseStream(input);
        }

        private IDictionary<string, string> ParseStream(Stream input)
        {
            throw new NotImplementedException();
        }
    }
}
