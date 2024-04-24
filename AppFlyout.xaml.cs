namespace tdmpw_2p_ej04;

public partial class AppFlyout : FlyoutPage
{
	public AppFlyout()
	{
		InitializeComponent();

                this.flyoutPage.CollectionView.SelectionChanged += OnSelectionChanged;
	}

        void OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;

            if (item != null) {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                IsPresented = true;
            }
        }
}
