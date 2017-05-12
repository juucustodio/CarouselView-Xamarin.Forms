using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoCarouselView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /*//Exemplo 1 - CarouselView com Texto
            var listaTexto = new List<string>
            {
                "Texto 1",
                "Texto 2",
                "Texto 3"
            };

            TextoCarouselView.ItemsSource = listaTexto;*/

            //Exemplo 2 - CarouselView com Imagem da Web
            var listaLink = new List<string>
            {
                "http://migre.me/wB66p",
                "http://migre.me/wB67d",
                "http://migre.me/wB6gJ"
            };

            ImageCarouselView.ItemsSource = listaLink;

            /*//Exemplo 3 - CarouselView com Imagem Local
            var listaImagens = new List<string>
            {
                "foto1.jpg",
                "foto2.jpg",
                "foto3.jpg"
            };

            ImageCarouselView.ItemsSource = listaImagens;*/
        }
    }
}
