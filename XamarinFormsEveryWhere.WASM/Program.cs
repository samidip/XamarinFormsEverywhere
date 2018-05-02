using System;
using Ooui;
using Xamarin.Forms;

namespace XamarinFormsEveryWhere.WASM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Xamarin.Forms
            Forms.Init();

            // Create the Xamarin.Forms UI
            var page = new ContentPage();
            var stack = new StackLayout();
            var button = new Xamarin.Forms.Button
            {
                Text = "Click me!"
            };
            stack.Children.Add(button);
            page.Content = stack;

            // Add some logic
            var count = 0;
            button.Clicked += (s, e) => {
                count++;
                button.Text = $"Clicked {count} times";
            };

            // Publish an Ooui root element to browser
            UI.Publish("/", page.GetOouiElement());
        }
    }
}
