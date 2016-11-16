using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class CarouselPageDemo : CarouselPage
    {
        public CarouselPageDemo()
        {
            var scrollView = new ScrollViewDemoPage();
            var stopWatch = new StopWatchApp();
            var sliderSwitch = new SliderSwitchApp();


            Children.Add(scrollView);
            Children.Add(stopWatch);
            Children.Add(sliderSwitch);


        }
    }
}
