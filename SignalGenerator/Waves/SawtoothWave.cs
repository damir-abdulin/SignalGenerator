namespace SignalGenerator.Waves;

public class SawtoothWave: IWave
{
    public int Amplitude { get; }
    public int Frequency { get; }
    public int Phase { get; }
    
    public SawtoothWave(int amplitude, int frequency, int phase)
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