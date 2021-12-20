using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal class LinkToNetworkResource : TrainingMaterial
    {
        private string uriContent;
        public LinkType LinkType { get; set; }

        public LinkToNetworkResource(string uriContent, LinkType linkType, string description) : base(description)
        {
            LinkType = linkType;
            ValidateAndSetUriContext(uriContent);
        }

        public string UriContent
        {
            get
            {
                return uriContent;
            }

            set
            {
                ValidateAndSetUriContext(value);
            }
        }

        private void ValidateAndSetUriContext (string uriContent)
        {
            if (!String.IsNullOrEmpty(uriContent))
            {
                this.uriContent = uriContent;
            }
            else
            {
                throw new Exception("URI of content is empty");
            }
        }

        public override string? ToString()
        {
            return "URI of Content:  " + uriContent + "\nLink type: " + LinkType;
        }
    }
}
