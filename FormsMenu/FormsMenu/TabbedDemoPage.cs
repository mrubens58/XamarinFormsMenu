using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class TabbedDemoPage : TabbedPage
    {
        public TabbedDemoPage()
        {

            var boxViewDemo = new NavigationPage(new BoxViewDemoPage());            
            boxViewDemo.Title = "Box View Demo";

            var frameViewDemo = new NavigationPage(new FrameDemoPage());
            frameViewDemo.Title = "Frame View Demo";

            var scrollViewDemo = new NavigationPage(new ScrollViewDemoPage());
            scrollViewDemo.Title = "Scroll View Demo";

            var stopWatchDemo = new NavigationPage(new StopWatchApp());
            stopWatchDemo.Title = "Stop Watch Demo";

            Children.Add(boxViewDemo);
            Children.Add(frameViewDemo);
            Children.Add(scrollViewDemo);
            Children.Add(stopWatchDemo);



        }
    }
}
