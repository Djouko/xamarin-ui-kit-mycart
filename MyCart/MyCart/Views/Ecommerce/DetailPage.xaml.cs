using MyCart.ViewModels.Ecommerce;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace MyCart.Views.Ecommerce
{
    /// <summary>
    /// The Detail page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailPage" /> class.
        /// </summary>
        public DetailPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when view size is changed.
        /// </summary>
        /// <param name="width">The Width</param>
        /// <param name="height">The Height</param>
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width > height)
            {
                Rotator.ItemTemplate = (DataTemplate)this.Resources["LandscapeTemplate"];
            }
            else
            {
                Rotator.ItemTemplate = (DataTemplate)this.Resources["PortraitTemplate"];
            }
        }
    }
}