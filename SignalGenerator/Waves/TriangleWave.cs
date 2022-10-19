﻿namespace SignalGenerator.Waves;

public class TriangleWave: IWave
{
    public int Amplitude { get; }
    public int Frequency { get; }
    public int Phase { get; }

    public int[] GenerateSignal(int frameSize, int sample)
    {
        throw new NotImplementedException();
    }
}