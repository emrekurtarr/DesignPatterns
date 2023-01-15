using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method1
{
    public class EndpointBuilder
    {
        private readonly string _baseUrl = "";
        private readonly StringBuilder sbUrl;
        private readonly StringBuilder sbParams;
        private const char defaultUrlDelimiter = '/';
        private const char defaultParamsDelimiter = '&';

        public EndpointBuilder(string baseUrl)
        {
            _baseUrl = baseUrl;
            sbUrl = new StringBuilder();
            sbParams = new StringBuilder();
        }

        public EndpointBuilder Append(string routh)
        {
            sbUrl.Append(routh);
            sbUrl.Append(defaultUrlDelimiter);

            return this;    
        }

        public EndpointBuilder AppendParams(string name,string value)
        {
            sbParams.Append($"{name}={value}");
            sbParams.Append(defaultParamsDelimiter);

            return this;
        }

        public string Build()
        {
            StringBuilder finalUrl = new StringBuilder(_baseUrl);
            

            if (sbUrl.ToString().EndsWith(defaultUrlDelimiter))
            {
                finalUrl.Append(sbUrl.ToString().TrimEnd(defaultUrlDelimiter));
            }

            if(sbParams.Length > 0)
            {
                finalUrl.Append('?');
                if (sbParams.ToString().EndsWith(defaultParamsDelimiter))
                    finalUrl.Append(sbParams.ToString().TrimEnd(defaultParamsDelimiter));
            }

            return finalUrl.ToString();
        }
    }
}
