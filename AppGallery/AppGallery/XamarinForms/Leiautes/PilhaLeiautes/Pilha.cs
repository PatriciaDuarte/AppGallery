using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Leiautes.PilhaLeiautes
{
    public class Pilha : ContentPage
    {
        public Pilha()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}