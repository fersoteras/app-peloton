using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    [Xamarin.Forms.ContentProperty("Content")]
    public partial class ChallengesPage : ContentPage
    {
        public ChallengesPage()
        {
            InitializeComponent();
        }
    }
}