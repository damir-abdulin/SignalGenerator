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
        throw new NotImplementedException();
    }
}