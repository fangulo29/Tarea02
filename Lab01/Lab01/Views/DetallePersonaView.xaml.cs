using Lab01.Models;
using Lab01.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab01.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetallePersonaView : ContentPage
	{
        public ObservableCollection<Person> vloListaPersonas { get; set; }

        public DetallePersonaView ()
		{
			InitializeComponent ();
            BindingContext = new PersonViewModel();
        }
	}
}