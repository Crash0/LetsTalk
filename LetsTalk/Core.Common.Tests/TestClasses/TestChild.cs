﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Common.Core;

namespace Core.Common.Tests.TestClasses
{
    internal class TestChild : ObjectBase
    {
        string _ChildName = string.Empty;

        public string ChildName
        {
            get { return _ChildName; }
            set
            {
                if (_ChildName == value)
                    return;

                _ChildName = value;
                OnPropertyChanged(() => ChildName);
            }
        }
    }
}
