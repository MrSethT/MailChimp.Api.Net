﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class Tracking
    {
        public bool opens { get; set; }
        public bool html_clicks { get; set; }
        public bool text_clicks { get; set; }
        public bool goal_tracking { get; set; }
        public bool ecomm360 { get; set; }
        public bool google_analytics { get; set; }
        public string clicktale { get; set; }
    }
}
