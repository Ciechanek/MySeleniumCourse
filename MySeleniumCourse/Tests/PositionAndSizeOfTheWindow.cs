using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MySeleniumCourse.Tests
{
    public class PositionAndSizeOfTheWindow : BaseTest
    {
        System.Drawing.Size windowSize = new System.Drawing.Size(854, 480);
        System.Drawing.Point windowPosition = new System.Drawing.Point(445, 30);
        [Test]
        public void WindowSize()
        {
            webDriver.Manage().Window.Size = windowSize;
            Assert.AreEqual(windowSize, webDriver.Manage().Window.Size, "Window size should be 854x480, but is " + webDriver.Manage().Window.Size.ToString());
        }

        [Test]
        public void WindowPosition()
        {
            webDriver.Manage().Window.Position = windowPosition;
            Assert.AreEqual(windowPosition, webDriver.Manage().Window.Position, "Window position should be 445, 30, but is " + webDriver.Manage().Window.Position.ToString());
        }
    }
}
