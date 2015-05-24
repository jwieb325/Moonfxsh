﻿using System;
using System.Diagnostics;
using System.Text;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Moonfish.Graphics
{
    public static class OpenGL
    {
        private static Program activeProgram { get; set; }

        /// <summary>
        /// Enables the OpenGL capability for the lifespan of this object then disables the capability again
        /// </summary>
        /// <param name="state">Specifies a symbolic constant indicating a GL capability.</param>
        /// <returns>Resource Handle for this capability</returns>
        public static IDisposable Enable(EnableCap state)
        {
            return new Handle(state);
        }

        /// <summary>
        /// Disables the OpenGL capability for the lifespan of this object then enables the capability again
        /// </summary>
        /// <param name="state">Specifies a symbolic constant indicating a GL capability.</param>
        /// <returns>Resource Handle for this capability</returns>
        public static IDisposable Disable(EnableCap state)
        {
            return new Handle(state, false);
        }

        public class Handle : IDisposable
        {
            private EnableCap state;
            private bool stateWasEnabled;

            public Handle(EnableCap state, bool enable = true)
            {
                var stateIsEnabled = GL.IsEnabled(state);
                //  is not enabled and we want to enable it
                if (!stateIsEnabled && enable) GL.Enable(state);
                // is enabled and we want to disable it
                else if (stateIsEnabled && !enable) GL.Disable(state);

                // store previous state
                this.state = state;
                this.stateWasEnabled = stateIsEnabled;
            }

            void IDisposable.Dispose()
            {
                // return state to previous setting
                if (stateWasEnabled) GL.Enable(state);
                else GL.Disable(state);
            }
        }
        [Conditional("DEBUG")]
        internal static void ReportError()
        {
            GL.Arb.DebugMessageCallback(Callback, IntPtr.Zero);
            var error = GL.GetError();
            if (error != ErrorCode.NoError)
                throw new GraphicsException(error.ToString());
        }

        private static void Callback(DebugSource source, DebugType type, int id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam)
        {
            throw new NotImplementedException();
        }
    }
}