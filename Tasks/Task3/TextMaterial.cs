using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal class TextMaterial : TrainingMaterial
    {
        private string text;

        public TextMaterial(string text, string description) : base (description)
        {
            ValidateAndSetText(text);
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                ValidateAndSetText(value);
            }
        }

        private void ValidateAndSetText(string text)
        {
            if (text.Length <= 10000 && !String.IsNullOrEmpty(text))
            {
                this.text = text;
            }
            else
            {
                throw new Exception("Text is empty or text length exceeds 10000 symbols");
            }
        }

        public override string ToString()
        {
            return $"Text: {text}";
        }

        public override object Clone()
        {
            return new TextMaterial(this.text, Description);
        }
    }
}
