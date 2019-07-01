﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace WorkspaceServer.Kernel
{
    public class StandardOutputReceived : KernelEventBase
    {
        public string Content { get; }

        public StandardOutputReceived(string content) : base(Guid.NewGuid(), Guid.Empty)
        {
            Content = content;
        }
    }
}