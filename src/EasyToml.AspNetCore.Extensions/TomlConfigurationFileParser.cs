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
            var options = default(TomlDocumentOptions);
            using (StreamReader streamReader = new StreamReader(input))
            {
                using (TomlDocument tomlDocument = TomlDocument.Parse(streamReader.ReadToEnd(), options))
                {
 
                }
            }

            return null;
        }
    }
}
