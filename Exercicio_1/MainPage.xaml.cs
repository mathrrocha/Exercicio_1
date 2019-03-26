using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            // desabilitar mensagens
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            // verificar se período e semestre foram selecionados
            if(Entry2.Text != null && Entry2.Text.Lenght > 0 && Picker.SelectedIndex >= 0)
            {
                // criar variáveis
                int periodo = int.Parse(Entry2.Text);
                int semestre = Picker.SelectedIndex + 1;
                // verificar se os valores são iguais
                if(periodo == semestre)
                {
                    // habilitar mensagem de sucesso
                    Label1 = IsVisible = true;
                }else
                {
                    // habilitar mensagem de erro
                    Label2 = IsVisible = true;
                }
            }
            else
            {
                // habilitar mensagem de erro
                Label2.IsVisible = true;
            }
        }
	}
}
