﻿using PCL.Interfaces.IoC;

namespace PCL.ViewModel.IoC
{
    public class ParameterOverride : IParameterOverride
    {
        public string Name
        {
            get;
            private set;
        }
        public object Value
        {
            get;
            private set;
        }

        public ParameterOverride(string paramName, object setValue)
        {
            this.Name = paramName;
            this.Value = setValue;
        }
    }
}
