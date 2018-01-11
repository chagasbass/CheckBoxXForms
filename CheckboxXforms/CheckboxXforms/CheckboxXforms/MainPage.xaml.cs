using System;
using Xamarin.Forms;

namespace CheckboxXforms
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public async void VerificarSelecao(object sender,EventArgs args)
        {
            var cb = (XLabs.Forms.Controls.CheckBox)sender;

            var selecionado = cb.DefaultText;

            await this.DisplayAlert("Atenção", "Opção selecionada: " + selecionado, "OK");
        }
    }
}