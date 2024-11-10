using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace Agenda_13_e_14_Hotel
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
