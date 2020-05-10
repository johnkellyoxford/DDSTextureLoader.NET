﻿using System;

namespace DDSTextureLoader.NET.TextureParsing
{
    [Flags]
    internal enum Caps2Flags : uint
    {
        DDS_CUBEMAP_POSITIVEX = 0x00000600, // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEX
        DDS_CUBEMAP_NEGATIVEX = 0x00000a00, // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEX
        DDS_CUBEMAP_POSITIVEY = 0x00001200, // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEY
        DDS_CUBEMAP_NEGATIVEY = 0x00002200, // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEY
        DDS_CUBEMAP_POSITIVEZ = 0x00004200, // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_POSITIVEZ
        DDS_CUBEMAP_NEGATIVEZ = 0x00008200, // DDSCAPS2_CUBEMAP | DDSCAPS2_CUBEMAP_NEGATIVEZ

        DDS_CUBEMAP_ALLFACES = DDS_CUBEMAP_POSITIVEX | DDS_CUBEMAP_NEGATIVEX |
                               DDS_CUBEMAP_POSITIVEY | DDS_CUBEMAP_NEGATIVEY |
                               DDS_CUBEMAP_POSITIVEZ | DDS_CUBEMAP_NEGATIVEZ,
        DDS_CUBEMAP = 0x00000200
    }
}