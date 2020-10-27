using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhonnyGuilcapiexamen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Vista_dos : ContentPage
{
    public Vista_dos(string user,string pass)
    {
        InitializeComponent();
            string usuario = IblUser.Text;
            IblUser.Text = usuario + user;
    }
}
}