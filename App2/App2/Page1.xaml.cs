using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        void PickMusic_SelectIndexChange(object sender, EventArgs e)
        {
            var elementoSeleccionado = Controlador.SelectedItem.ToString();
            DisplayAlert("Genero de Musica", elementoSeleccionado, "aceptar");

        }
        void btnSimular_Clicked (object sender, System.EventArgs e)
        {
            var Progreso = progressNum.Progress;
            if (Progreso == 1)
            {
                progressNum.ProgressTo(.1, 250, Easing.SpringOut);
            }
            else
            {
                progressNum.ProgressTo(1, 300, Easing.Linear);
            }
        }

        void Handle_SearchButtonPressed( object sender , System.EventArgs e)
        {
            DisplayAlert("Buscando", "Buscando Resultados ", "Aceptar");
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            DisplayAlert("Cambiando", "Este texto esta cambiando  ", "Aceptar");
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            labCambio.Text = slider.Value.ToString();
        }

        void stepEvent(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            lbDisplay.Text = steeper.Value.ToString();
        }


        public Page1 ()
		{
			InitializeComponent ();
		}

        void Handle_toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var estado = this.swtEstado.IsToggled;
            if (this.swtEstado.IsToggled)
            {
                DisplayAlert("Switch","Estoy Encendido","Aceptar");
            }
            else
            {
                DisplayAlert("Switch", "Estoy Apagado", "Aceptar");
            }
        }
    }
}