﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;

namespace app.ui.Areas.Identity.Service.Command.SendEmailVerification
{
    public class SendEmailVerificationResult
    {
        public Response Response { get; set; }
    }
}
