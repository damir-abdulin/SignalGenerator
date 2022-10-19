using OxyPlot;
using OxyPlot.Axes;

namespace SignalGeneratorGui;

public class MainViewModel
{
    public PlotModel Signal { get; }
    
    public MainViewModel()
    {
        Signal = new PlotModel { Title = "Сигнал"};
        
        var xAxis = new LinearAxis
        {
            Position = AxisPosition.Bottom, 
            Title = "Время, с",
            IsZoomEnabled = false, 
            IsPanEnabled = false
        };
        var yAxis = new LinearAxis
        {
            Position = AxisPosition.Left,
            Title = "Амплитуда",
            IsZoomEnabled = false,
            IsPanEnabled = false
        };
            
        Signal.Axes.Add(xAxis);
        Signal.Axes.Add(yAxis);
    }
}