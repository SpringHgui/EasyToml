using System;
using System.Collections.Generic;
using System.Text;

namespace EasyToml
{
    public class TomlDocument : IDisposable
    {
        public TomlElement RootElement
        {
            get
            {
                throw null;
            }
        }

        public static TomlDocument Parse(string toml, TomlDocumentOptions options)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}
