using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NewBoy.Views
{
    public partial class Profile : ContentPage
    {

		public ObservableCollection<sampleList> samples;
        public Profile()
        {
            InitializeComponent();

			samples = new ObservableCollection<sampleList>()
			{
				new sampleList()
				{
					location="Kheerganga",
					usersname="Anonymous",
					description="Best scenic beauty"
				},
				new sampleList()
				{
					location = "Kasol",
					usersname = "Mr.x",
					description = "Best hash in the world"
				},
				new sampleList()
				{
					location = "Kulu",
					usersname = "Ranger",
					description = "River rafting in Himachal Pradesh"
				}

			};
			ProfileListView.ItemsSource = samples;
        }

		public class sampleList
		{
			public string location { get; set; }
			public string usersname { get; set; }
			public string description { get; set; }
		}


    }
}
