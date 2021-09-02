using System.Collections.ObjectModel;
using MvvmDemo.Config;
using MvvmDemo.Model;

namespace MvvmDemo.ViewModel
{
    public class SliderViewModel : PropertyChangeHandler
    {
        private ObservableCollection<Slider> _sliders;
        private Slider _sliderSelected;
        private double _doubleValue;

        public SliderViewModel()
        {
            _doubleValue = 0.5;
            Sliders = new ObservableCollection<Slider>(Slider.GetSliders());
            SliderSelected = Sliders[0];
        }

        public ObservableCollection<Slider> Sliders
        {
            get => _sliders;
            set => SetAndNotifyIfChanged("Sliders", ref _sliders, value);
        }

        public Slider SliderSelected
        {
            get => _sliderSelected;
            set => SetAndNotifyIfChanged("SliderSelected", ref _sliderSelected, value);
        }

        public double DoubleValue
        {
            get => _doubleValue;
            set
            {
                if (_doubleValue == value) return;
                _doubleValue = value;
                RaisePropertyChanged("DoubleValue");
            }
        }
    }
}