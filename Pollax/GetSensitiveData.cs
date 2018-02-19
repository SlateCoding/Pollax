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
            return "https://29430e9b627d461f910632fa2b7eded3:45296cf0199848f9bf33841ad398ecdf@sentry.io/287903";
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
