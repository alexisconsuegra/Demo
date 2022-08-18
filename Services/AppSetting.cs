using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xPray.Services
{
    public class AppSetting
    {
        public MailSettings MailSettings { get; set; }

        public string SiteUrl { get; set; }

        public int MaxChemicals { get; set; }
    }
}
