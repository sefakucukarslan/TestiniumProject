﻿using TestiniumProject.WebDriver;
using TechTalk.SpecFlow;

namespace TestiniumProject.Steps.BaseSteps
{
    public class BaseStep
    {
        [Before]        
        public void DriverStart()
        {
            Driver.DriverStart();
        }

        [After]        
        public void DriverQuit()
        {
            Driver.DriverQuit();
        }       

    }
}
