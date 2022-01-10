using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal class VideoMaterial : TrainingMaterial, IVersionable
    {
        private string uriOfVideoContent;
        private byte[] version = new byte[8];

        public VideoMaterial(string uriOfVideoContent, string uriOfSplashScreen, VideoFormat videoFormat, string description) : base(description)
        {
            ValidateAndSetUriOfVideoContent(uriOfVideoContent);
            UriOfSplashScreen = uriOfSplashScreen;
            VideoFormat = videoFormat;
        }

        public string UriOfSplashScreen { get; set; }
        public VideoFormat VideoFormat { get; set; }

        public string UriOfVideoContent
        {
            get
            {
                return uriOfVideoContent;
            }

            set
            {
                ValidateAndSetUriOfVideoContent(value);
            }
        }

        private void ValidateAndSetUriOfVideoContent(string uriOfVideoContent)
        {
            if (!String.IsNullOrEmpty(uriOfVideoContent))
            {
                this.uriOfVideoContent = uriOfVideoContent;
            }

            else
            {
                throw new Exception("URI of video content is empty");
            }
        }

        public override string? ToString()
        {
            return $"URI of video context: {uriOfVideoContent} \nURI of splash screen: {UriOfSplashScreen}\nVideo Format: {VideoFormat}";
        }

        public void SetVersion()
        {
            {
                Random rnd = new Random();
                rnd.NextBytes(version);
            }
        }

        public byte[] ReadVersion()
        {
            return version;
        }

        public override object Clone()
        {
            return new VideoMaterial(this.uriOfVideoContent, this.UriOfSplashScreen, this.VideoFormat, Description);
        }
    }
}
