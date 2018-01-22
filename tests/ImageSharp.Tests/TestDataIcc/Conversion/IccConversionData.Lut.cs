﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.Tests.Colorspaces.Icc
{
    public class IccConversionDataLut
    {
        private static float[] LutEven = { 0, 0.5f, 1 };
        private static float[] LutUneven = { 0, 0.7f, 1 };

        public static object[][] LutConversionTestData =
        {
            new object[] { LutEven, false,  0.5f, 0.5f },
            new object[] { LutEven, false,  0.25f, 0.25f },
            new object[] { LutEven, false,  0.75f, 0.75f },

            new object[] { LutEven, true,  0.5f, 0.5f },
            new object[] { LutEven, true,  0.25f, 0.25f },
            new object[] { LutEven, true,  0.75f, 0.75f },

            new object[] { LutUneven, false, 0.1, 0.14 },
            new object[] { LutUneven, false, 0.5, 0.7 },
            new object[] { LutUneven, false, 0.75, 0.85 },

            new object[] { LutUneven, true, 0.14, 0.1 },
            new object[] { LutUneven, true, 0.7, 0.5 },
            new object[] { LutUneven, true, 0.85, 0.75 },
        };
    }
}
