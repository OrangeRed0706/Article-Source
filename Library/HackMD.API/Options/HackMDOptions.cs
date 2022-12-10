using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackMD.API.Options
{
    internal class HackMDOptions
    {
        public const string HackMD = "HackMD";
        public Uri BaseUrl { get; set; }
        public string Token { get; set; }
    }
}
