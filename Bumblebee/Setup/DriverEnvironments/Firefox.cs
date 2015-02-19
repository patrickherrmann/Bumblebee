﻿using System;
using OpenQA.Selenium.Firefox;

namespace Bumblebee.Setup.DriverEnvironments
{
    public class Firefox : SimpleDriverEnvironment<FirefoxDriver>
    {
        public Firefox(TimeSpan timeToWait) 
            : base(timeToWait)
        { }

        public Firefox()
        { }
    }
}
