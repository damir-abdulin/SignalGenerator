namespace SignalGenerator;

public interface IWave
{
    int Amplitude { get; }
    int Frequency { get; }
    int Phase { get; }

    int[] GenerateSignal(int frameSize, int sample);
}