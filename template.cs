using System;
using System.Drawing;
using OpenTK;

namespace Template
{
    public class OpenTKApp : GameWindow
    {
        protected override void OnLoad(EventArgs e)
        {
            // Console.WriteLine(Width.ToString() + " " + Height.ToString());
            // ClientSize = new Size(1200, 800);
            Console.WriteLine(Width.ToString() + " " + Height.ToString());
            Height = 800;
            Width = 1200;
            Console.WriteLine(Width.ToString() + " " + Height.ToString());
        }

        public static void Main(string[] args)
        {
            // entry point
            using (OpenTKApp app = new OpenTKApp()) { app.Run(30.0, 0.0); }
        }
    }
}