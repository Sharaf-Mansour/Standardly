﻿// ---------------------------------------------------------------
// Copyright (c) Christo du Toit. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Xeptions;

namespace Standardly.Core.Models.FileServices.Exceptions
{
    public class FileServiceValidationException : Xeption
    {
        public FileServiceValidationException(Xeption innerException)
            : base(message: "File validation error occurred, fix the errors and try again.",
                  innerException)
        { }
    }
}
