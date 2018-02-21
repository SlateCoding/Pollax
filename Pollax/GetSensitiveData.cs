using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollax.Server.Data
{
    internal static class GetSensitiveData
    {
        internal static string GetDSN()
        {
            return "https://cf14a7b5161d4111b665f6938f8502d7:922f311564ed406e8154c72a3f6de4fc@sentry.io/287903";
        }

        internal static string GetGPGKeyPassword()
        {
            return "L4d3ws9cTfh{no}baD{bAbg}";
        }

        internal static string GetGPGKeyFingerprint()
        {
            return "8A44DDFCA462B1F919B28D9A6608B22849289C4C";
        }

        internal static string GetGPGKeyID()
        {
            return "49289C4C";
        }
    }
}
