namespace ManagedBass.DirectX8
{
    /// <summary>
    /// DX8 Gargle Effect.
    /// </summary>
    public sealed class DXGargleEffect : Effect<DXGargleParameters>
    {
        /// <summary>
        /// Rate of modulation, in Hertz. Must be in the range from 1 through 1000. Default 500 Hz.
        /// </summary>
        public int Rate
        {
            get { return Parameters.dwRateHz; }
            set
            {
                Parameters.dwRateHz = value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Shape of the modulation wave. Default = <see cref="DXWaveform.Sine"/>.
        /// </summary>
        public DXWaveform WaveShape
        {
            get { return Parameters.dwWaveShape; }
            set
            {
                Parameters.dwWaveShape = value;

                OnPropertyChanged();
            }
        }
    }
}