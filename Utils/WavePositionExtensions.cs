﻿using System;
using System.Linq;
using NAJAudio.Wave.WaveOutputs;
using NAJAudio.Wave;

namespace NAJAudio.Utils
{
    /// <summary>
    /// WavePosition extension methods
    /// </summary>
    public static class WavePositionExtensions
    {
        /// <summary>
        /// Get Position as timespan
        /// </summary>
        public static TimeSpan GetPositionTimeSpan(this IWavePosition @this)
        {
            var pos = @this.GetPosition() / (@this.OutputWaveFormat.Channels * @this.OutputWaveFormat.BitsPerSample / 8);
            return TimeSpan.FromMilliseconds(pos * 1000.0 / @this.OutputWaveFormat.SampleRate);
        }
    }
}
