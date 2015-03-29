﻿using System;
using System.Diagnostics;
using System.Linq;

namespace Moonfish.Graphics
{
    public class Performance
    {
        struct FrameInfo
        {
            public float RenderTime;
        }

        public float FramesPerSecond { get; private set; }
        public float FrameTime { get; private set; }

        readonly Stopwatch _timer;
        readonly FrameInfo[] _frameHistory;
        private int _index;

        const int Size = 25;

        TimeSpan _frameStart, _frameEnd;

        public Performance( )
        {
            _timer = new Stopwatch();
            _frameHistory = new FrameInfo[ Size ];
            _timer.Start();
        }

        public void BeginFrame( )
        {
            _frameStart = _timer.Elapsed;
        }

        public void EndFrame( )
        {
            _frameEnd = _timer.Elapsed;

            var elapsed = ( _frameEnd - _frameStart ).Ticks;
            _frameHistory[ ++_index >= Size ? _index = 0 : _index ] = new FrameInfo() { RenderTime = elapsed };
            var sum = _frameHistory.Sum(value => value.RenderTime);
            FramesPerSecond = Stopwatch.Frequency / ( sum / _frameHistory.Length );
            FrameTime = sum / _frameHistory.Length;
        }

        public float Delta { get { return ( _timer.Elapsed - _frameEnd ).Milliseconds; } }
    }
}
