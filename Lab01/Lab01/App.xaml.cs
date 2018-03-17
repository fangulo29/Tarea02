using Lab01.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lab01
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new DetallePersonaView();
		}
	}
}
