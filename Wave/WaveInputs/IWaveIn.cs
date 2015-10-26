using System;
using NAJAudio.Wave.MmeInterop;
using NAJAudio.Wave.WaveFormats;
using NAJAudio.Wave.WaveOutputs;

namespace NAJAudio.Wave.WaveInputs
{
    /// <summary>
    /// Generic interface for wave recording
    /// </summary>
    public interface IWaveIn : IDisposable
    {
        /// <summary>
        /// Recording WaveFormat
        /// </summary>
        WaveFormat WaveFormat { get; set; }

        /// <summary>
        /// Start Recording
        /// </summary>
        void StartRecording();

        /// <summary>
        /// Stop Recording
        /// </summary>
        void StopRecording();

        /// <summary>
        /// Indicates recorded data is available 
        /// </summary>
        event EventHandler<WaveInEventArgs> DataAvailable;

        /// <summary>
        /// Indicates that all recorded data has now been received.
        /// </summary>
        event EventHandler<StoppedEventArgs> RecordingStopped;
    }
}
