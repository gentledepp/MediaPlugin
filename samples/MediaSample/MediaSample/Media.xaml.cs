using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MediaSample
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Media : MasterDetailPage
    {
        public Media()
        {
            InitializeComponent();
        }
        
    }
}
