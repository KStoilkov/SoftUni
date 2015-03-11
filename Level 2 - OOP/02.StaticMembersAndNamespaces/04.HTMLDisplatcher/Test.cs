namespace _04.HTMLDisplatcher
{
    using System;

    class Test
    {
        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");

            div.AddAtribute("class", "left-box");
            div.AddAtribute("id", "box");
            div.AddContent("<p>Hey</p>");
            div.AddContent("<p>AAA</p>");

            Console.WriteLine(div * 3);

            string linkToSoftUni = HTMLDispatcher.CreateURL(
                "https://softuni.bg", 
                "softuni", 
                "SoftUni");
            string picture = HTMLDispatcher.CreateImage(
                "D:\\myPics\\pic..jpg",
                "picture of me",
                "pic");
            string inputText = HTMLDispatcher.CreateInput(
                "text",
                "firstName",
                "Goshko");

            Console.WriteLine(linkToSoftUni);
            Console.WriteLine(picture);
            Console.WriteLine(inputText);
        }
    }
}
