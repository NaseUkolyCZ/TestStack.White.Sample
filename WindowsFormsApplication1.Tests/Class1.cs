using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItems;

  
namespace WindowsFormsApplication1.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FirstSample()
        {
            //http://teststack.azurewebsites.net/White/GettingStarted.html#
            Application application = Application.Launch(@"C:\Users\david.podhola\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Window window = application.GetWindow("Form1", InitializeOption.NoCache);
            Button button = window.Get<Button>("save");
            button.Click();
        }
    }
}
