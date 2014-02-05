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
using System.IO;
  
namespace WindowsFormsApplication1.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FirstSample()
        {
            //http://teststack.azurewebsites.net/White/GettingStarted.html#
            string path = Path.GetFullPath(
                    @"..\..\..\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe"
            );
            Application application = Application.Launch(path);
            Window window = application.GetWindow("Form1", InitializeOption.NoCache);
            Button button = window.Get<Button>("save");
            button.Click();
        }
    }
}
