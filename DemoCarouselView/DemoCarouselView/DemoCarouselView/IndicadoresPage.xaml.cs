using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace DemoCarouselView
{
    public partial class IndicadoresPage : ContentPage, INotifyPropertyChanged
    {
        public IndicadoresPage()
        {
            InitializeComponent();

            
            ListaImagens = new List<string>
            {
                "foto1.jpg",
                "foto2.jpg",
                "foto3.jpg"
            };

            BindingContext = this;

        }

        public List<string> ListaImagens { get; set; }
        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }
    }
}