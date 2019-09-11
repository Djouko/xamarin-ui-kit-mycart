﻿using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace MyCart.Views.Ecommerce
{
    /// <summary>
    /// Page to show the Checkout details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckoutPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutPage" /> class.
        /// </summary>
        public CheckoutPage()
        {
            this.InitializeComponent();
        }
    }
}