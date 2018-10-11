using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace simple
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnChangeLabel_Clicked(object sender, EventArgs e)
        {
            lblMessage.Text = "Hello World " +
                              entryUsername.Text +
                              " !!!!";
            entryUsername.Text = "";
            btnChangeLabel.Text = "Dont do that again";
        }
    }
}
