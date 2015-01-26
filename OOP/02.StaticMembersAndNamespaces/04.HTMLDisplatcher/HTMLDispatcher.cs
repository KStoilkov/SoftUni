namespace _04.HTMLDisplatcher
{
    public static class HTMLDispatcher
    {
        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img");
            img.AddAtribute("src", imageSource);
            img.AddAtribute("alt", alt);
            img.AddAtribute("title", title);

            return img.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder a = new ElementBuilder("a");
            a.AddAtribute("href", url);
            a.AddAtribute("title", title);
            a.AddContent(text);

            return a.ToString();
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAtribute("type", inputType);
            input.AddAtribute("name", name);
            input.AddAtribute("value", value);

            return input.ToString();
        }
    }
}
