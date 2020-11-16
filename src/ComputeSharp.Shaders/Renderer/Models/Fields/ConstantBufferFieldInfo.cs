﻿using System;
using ComputeSharp.Shaders.Renderer.Models.Fields.Abstract;

namespace ComputeSharp.Shaders.Renderer.Models.Fields
{
    /// <summary>
    /// A <see langword="class"/> that contains info on a constant buffer field.
    /// </summary>
    internal sealed class ConstantBufferFieldInfo : HlslBufferInfo
    {
        /// <summary>
        /// Creates a new <see cref="ConstantBufferFieldInfo"/> instance with the specified parameters.
        /// </summary>
        /// <param name="fieldCsharpType">The type of the current field in the C# source.</param>
        /// <param name="fieldHlslType">The type of the current field in the HLSL shader.</param>
        /// <param name="fieldName">The name of the current field.</param>
        /// <param name="bufferIndex">The index of the current constant buffer field.</param>
        public ConstantBufferFieldInfo(Type fieldCsharpType, string fieldHlslType, string fieldName, int bufferIndex)
            : base(fieldCsharpType, fieldHlslType, fieldName, bufferIndex)
        {
        }

        /// <summary>
        /// Gets whether or not the current <see cref="CapturedFieldInfo"/> instance represents a constant buffer (always <see langword="true"/>).
        /// </summary>
        public bool IsConstantBuffer { get; } = true;
    }
}
