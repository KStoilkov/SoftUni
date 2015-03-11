namespace _04.HTMLDisplatcher
{
    using System;

    public class ElementBuilder
    {
        private string elementName;
        private string attributes;
        private string content;

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

        public string Attributes
        {
            get
            {
                return this.attributes;
            }
            private set
            {
                this.attributes = value;
            }
        }

        public string Content
        {
            get
            {
                return this.content;
            }
            private set
            {
                this.content = value;
            }
        }

        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
        }

        public void AddAtribute(string attribute, string value) 
        {
            this.Attributes += " " + attribute + "=\"" + value + "\""; 
        }

        public void AddContent(string content)
        {
            this.content += content;
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
            return string.Format(
                "<" + this.ElementName + this.Attributes + ">" + 
                this.Content + "</" + this.ElementName + ">");
        }
    }
}
