﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Joe Audette
// Created:					2016-01-18
// Last Modified:			2016-06-14
// 

using System;
using System.ComponentModel.DataAnnotations;

namespace cloudscribe.Core.Web.ViewModels.SiteSettings
{
    public class MailSettingsViewModel
    {
        public Guid SiteId { get; set; } = Guid.Empty;

        [EmailAddress]
        [StringLength(100, ErrorMessage = "Email has a maximum length of 100 characters")]
        public string DefaultEmailFromAddress { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Email alias has a maximum length of 100 characters")]
        public string DefaultEmailFromAlias { get; set; } = string.Empty;
        [StringLength(500, ErrorMessage = "Smtp User has a maximum length of 500 characters")]
        public string SmtpUser { get; set; } = string.Empty;
        
        public string SmtpPassword { get; set; } = string.Empty;
        [StringLength(200, ErrorMessage = "Smtp Server has a maximum length of 200 characters")]
        public string SmtpServer { get; set; } = string.Empty;

        public int SmtpPort { get; set; } = 25;
        
        public bool SmtpRequiresAuth { get; set; } = false;
        
        public bool SmtpUseSsl { get; set; } = false;
        [StringLength(20, ErrorMessage = "Smtp Preferred Encoding has a maximum length of 20 characters")]
        public string SmtpPreferredEncoding { get; set; } = string.Empty;

    }
}
