using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triangulo
{
   public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            float baseDeTriángulo = float.Parse(BaseDeTriangulo.Text);
            float alturaDeTriángulo = float.Parse(Altura.Text);
            float areaDeTriángulo = ((baseDeTriángulo * alturaDeTriángulo) / 2);
            Area.Text = areaDeTriángulo.ToString();
            string tipo;

            float lado1 = float.Parse(Lado1.Text);
            float lado2 = float.Parse(Lado2.Text);

            if (lado1 == lado2 && lado1 == baseDeTriángulo )
            {

                DisplayAlert(title: "tipo", "Es un trinagulo Equilatero", "Quitar");
                ImgTrinaguloequilatero.IsVisible = true;
                ImgTrinaguloEscaleno.IsVisible = false;
                ImgTrinaguloIsoceles.IsVisible = false;
            }
            else if (lado1 == lado2 || lado1 == baseDeTriángulo || lado2 == baseDeTriángulo )
            {
                DisplayAlert(title: "tipo", "Es un trinagulo isoceles", "Quitar");
                ImgTrinaguloequilatero.IsVisible = false;
                ImgTrinaguloEscaleno.IsVisible = false;
                ImgTrinaguloIsoceles.IsVisible = true;

            }
            else if (lado1 != lado2 && lado1 != baseDeTriángulo && lado2 != baseDeTriángulo)
            {
                DisplayAlert(title:"tipo", "Es un trinagulo Escaleno", "Quitar");
                ImgTrinaguloequilatero.IsVisible = false;
                ImgTrinaguloEscaleno.IsVisible = true;
                ImgTrinaguloIsoceles.IsVisible = false;
            }
            else
            {
                DisplayAlert(title: "error", "No es un triangulo", "Quitar");
                ImgTrinaguloequilatero.IsVisible = false;
                ImgTrinaguloEscaleno.IsVisible = false;
                ImgTrinaguloIsoceles.IsVisible = false;
            }


        }

    }
}
