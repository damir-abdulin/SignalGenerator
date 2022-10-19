using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Series;
using SignalGenerator;
using SignalGenerator.Waves;

namespace SignalGeneratorGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonGenerate_OnClick(object sender, RoutedEventArgs e)
        {
            var wave = GetWave();

            var sample = int.Parse(TextBoxSample.Text);
            var signal = wave.GenerateSignal(10, sample);
            ShowSignal(10, sample, signal);
        }

        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private IWave GetWave()
        {
            var magnitude = int.Parse(TextBoxMagnitude.Text);
            var frequency = int.Parse(TextBoxFrequency.Text);
            var phase = int.Parse(TextBoxPhase.Text);
            var forms = (WaveType)ComboBoxForm.SelectedIndex;

            IWave wave = forms switch
            {
                WaveType.Sine => new SineWave(magnitude, frequency, phase),
                WaveType.Square => new SquareWave(magnitude, frequency, phase),
                WaveType.Triangle => new SquareWave(magnitude, frequency, phase),
                WaveType.Sawtooth => new SquareWave(magnitude, frequency, phase),
                _ => new SineWave(magnitude, frequency, phase)
            };

            return wave;
        }

        private void ShowSignal(int frameSize, int sample, int[] signal)
        {
            var dataSeries = new LineSeries { Title = "Сигнал", MarkerType=MarkerType.Circle };
            for (var i = 0; i < signal.Length; i++)
            {
                dataSeries.Points.Add(new DataPoint((double)i / frameSize, 0));    
            }
            
            OxyPlotSignal.Model.Series.Clear();
            OxyPlotSignal.Model.Series.Add(dataSeries);
            OxyPlotSignal.InvalidatePlot();
        }
    }
}