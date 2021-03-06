﻿using System.Collections.Generic;

namespace HelpScout.Conversations.Models.Create
{
    public class ThreadCreateRequest
    {
        public string CreatedAt { get; set; }
        public bool? Imported { get; set; }
        public IList<int> Cc { get; set; }
        public IList<int> Bcc { get; set; }
        public IList<int> Attachments { get; set; }
        public CreateConservationThreadCustomer Customer { get; set; }
        public int? User { get; set; }
        public ThreadType Type { get; set; }
        public string Text { get; set; }
    }
}