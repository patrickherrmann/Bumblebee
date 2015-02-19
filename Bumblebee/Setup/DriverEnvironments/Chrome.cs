﻿using System;
using OpenQA.Selenium.Chrome;

namespace Bumblebee.Setup.DriverEnvironments
{
    public class Chrome : SimpleDriverEnvironment<ChromeDriver>
    {
        public Chrome(TimeSpan timeToWait) 
            : base(timeToWait)
        { }

        public Chrome()
        { }
    }
}
