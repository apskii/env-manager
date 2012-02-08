using System;
using System.Linq;
using System.Collections.Generic;
using EnvManager.Extensions;

namespace EnvManager.Domain
{
    class EnvVar
    {
        string varName;
        EnvironmentVariableTarget varTarget;

        public EnvVar(string varName, EnvironmentVariableTarget varTarget)
        {            
            this.varName = varName;
            this.varTarget = varTarget;
        }

        public IEnumerable<string> GetEntries()
        {
            var val = Environment.GetEnvironmentVariable(varName, varTarget);

            if (val == null)
                return null;

            return val.Split(';').OrderBy(s => s);
        }

        public void SetEntries(IEnumerable<string> entries)
        {
            Environment.SetEnvironmentVariable(
                varName,
                entries.Intercalate(";"),
                varTarget
            );
        }
    }
}
