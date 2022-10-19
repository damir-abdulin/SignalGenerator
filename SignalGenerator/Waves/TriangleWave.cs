namespace SignalGenerator.Waves;

public class TriangleWave: IWave
{
    public int Amplitude { get; }
    public int Frequency { get; }
    public int Phase { get; }
    
    public TriangleWave(int amplitude, int frequency, int phase)
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

            signal[i] = (int)((2 * Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * time * Frequency + Phase)));

        }

        return signal;
    }
}