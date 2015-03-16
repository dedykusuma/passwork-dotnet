﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Passwork.Core.Models
{
    public class GroupReplyModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string passwordCrypted { get; set; }
        public List<PasswordReplyModel> passwords { get; set; }
        public List<FolderReplyModel> folders { get; set; }
    }
}
