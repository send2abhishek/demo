using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FirstApp.Models;

namespace FirstApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewDemo : ContentPage
	{
		public ListViewDemo ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<ListItems>
            {

                 new ListItems { name="Abhishek Aryan", ImageUrl="http://lorempixel.com/100/100/sports/1/"},
                 new ListItems {  name="Aryan", ImageUrl="http://lorempixel.com/100/100/sports/2/", staus="Hey"},
                 new ListItems {  name="Aryan", ImageUrl="http://lorempixel.com/100/100/sports/3/", staus="Hey item"},
                 new ListItems {  name="Aryan", ImageUrl="http://lorempixel.com/100/100/sports/4/", staus="demo item"}

                 };
                 
                
            
		}
	}
}