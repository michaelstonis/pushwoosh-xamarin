﻿using System;
using System.Collections.Generic;

namespace Pushwoosh.Forms.Inbox
{
    public abstract class InboxManager
    {
        public static InboxManager Instance { get; set; }

        public abstract void PresentInboxUI(PushwooshInboxStyle style);
    }
}
