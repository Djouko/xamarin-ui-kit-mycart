using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace MyCart.Views.Ecommerce
{
    /// <summary>
    /// Page to show the catalog list. 
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatalogListPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogListPage" /> class.
        /// </summary>
        public CatalogListPage()
        {
            this.InitializeComponent();
        }
    }
}