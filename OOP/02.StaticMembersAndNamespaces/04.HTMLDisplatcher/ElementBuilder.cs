namespace _04.HTMLDisplatcher
{
    using System;

    public class ElementBuilder
    {
        private string elementName;
        private int attributesLength = 0;
        private int contentLength = 0;
        private string htmlTag;

        public string ElementName 
        {
            get
            {
                return this.elementName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Element name cannot be empty.");
                }
                this.elementName = value;
            }
        }

        public int AttributesLength 
        {
            get
            {
                return this.attributesLength;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attributes Length cannot be less than 0.");
                }
                this.attributesLength = value;
            }
        }

        public string HtmlTag 
        {
            get
            {
                return this.htmlTag;
            }
            private set
            {
                this.htmlTag = value;
            }
        }

        public int ContentLength 
        {
            get
            {
                return this.contentLength;
            }
            private set
            {
                this.contentLength = value;
            }
        }

        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
            this.HtmlTag = "<" + elementName + ">" + "</" + elementName + ">";
        }

        public void AddAtribute(string attribute, string value) 
        {
            string attributeToAdd = " " + attribute + "=\"" + value + "\"";

            string htmlTagCreator = this.HtmlTag.Substring(
                0, 1 + this.ElementName.Length + 
                this.AttributesLength);

            string htmlHolder = this.HtmlTag.Substring(htmlTagCreator.Length,
                this.HtmlTag.Length - htmlTagCreator.Length);

            htmlTagCreator += attributeToAdd;

            htmlTagCreator += htmlHolder;

            this.AttributesLength += attributeToAdd.Length;

            this.HtmlTag = htmlTagCreator;
        }

        public void AddContent(string content)
        {
            string contentCreator = this.HtmlTag.Substring(
                0, 2 + this.AttributesLength + this.ElementName.Length + 
                this.ContentLength);

            this.ContentLength += content.Length;

            contentCreator += content + "</" + this.ElementName + ">";

            this.HtmlTag = contentCreator;
        }

        public static string operator *(ElementBuilder element, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += element;
            }
            return result;
        }

        public override string ToString()
        {
            return string.Format(this.HtmlTag);
        }
    }
}
