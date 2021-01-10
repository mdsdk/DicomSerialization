﻿// Copyright (c) Robin Boerdijk - All rights reserved - See LICENSE file for license terms

namespace MDSDK.Dicom.Serialization.ValueRepresentations
{
    public class UnlimitedText : SpecificCharsetEncodedSingleValue, IHas32BitExplicitVRLength
    {
        public UnlimitedText() : base("UT") { }
    }
}
