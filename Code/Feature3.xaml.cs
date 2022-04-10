using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Air
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Feature3 : ContentPage
    {
        public Feature3()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            Navigation.PushAsync(new User());
        }
    }
}
