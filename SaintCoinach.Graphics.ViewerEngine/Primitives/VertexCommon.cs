﻿using System;
using System.Collections.Generic;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace SaintCoinach.Graphics.Primitives {
    [StructLayout(LayoutKind.Sequential)]
    public struct VertexCommon {
        public Vector4 Position;
        public Vector3 Normal;
        public Vector3 Tangent;
        public Vector3 Binormal;
        public Vector2 TextureCoordinates;

        public static InputElement[] InputElements {
            get {
                return new[]{
                    new InputElement("SV_Position",0, Format.R32G32B32A32_Float, 0, 0),
                    new InputElement("NORMAL", 0, Format.R32G32B32_Float, 16, 0),
                    new InputElement("TANGENT", 0, Format.R32G32B32_Float, 28, 0),
                    new InputElement("BINORMAL", 0, Format.R32G32B32_Float, 40, 0),
                    new InputElement("TEXCOORD", 0, Format.R32G32_Float, 52, 0),
                    new InputElement("TEXCOORD", 1, Format.R32G32_Float, 52, 0),
                    new InputElement("TEXCOORD", 2, Format.R32G32B32A32_Float, 44, 0),
                };
            }
        }
    }
}
