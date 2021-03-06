﻿using System;
using Bedrock.Views;

namespace Bedrock.Tests.Mocks
{
    public class MockView : IView
    {
        private string _name;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = Guid.NewGuid().ToString();
                }

                return _name;
            }
            set { _name = value; }
        }
        public object DataContext { get; set; }
        public void RegisterRegion(string regionName, object control)
        {
            throw new NotImplementedException();
        }
    }
}
