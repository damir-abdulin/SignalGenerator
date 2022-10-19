namespace SignalGenerator.Waves;

public class SquareWave : IWave
{
    public int Amplitude { get; }
    public int Frequency { get; }
    public int Phase { get; }
    
    public SquareWave(int amplitude, int frequency, int phase)
    {
        Amplitude = amplitude;
        Frequency = frequency;
        Phase = phase;
    }

    public int[] GenerateSignal(int frameSize, int sample)
    {
        var signal = new int[frameSize * sample];

        for (var i = 0; i < signal.Length; i++)
        {
            var time = (double)i / sample;

            signal[i] = Amplitude * Math.Sign(Math.Sin(2 * Math.PI * time * Frequency));
        }

        return signal;
    }
}