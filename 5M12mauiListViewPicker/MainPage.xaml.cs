namespace _5M12mauiListViewPicker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            pckTlo.SelectedIndex = 0;
        }

        private void itemSelect(object sender, EventArgs e)
        {
            string kolor = lvKolory.SelectedItem.ToString();
            if (kolor == "zielony")
            {
                lblNapis.TextColor = Colors.Green;
            }
            if (kolor == "czerwony")
            {
                lblNapis.TextColor = Colors.Red;
            }
            if (kolor == "niebieski")
            {
                lblNapis.TextColor = Colors.Blue;
            }
            if (kolor == "różowy")
            {
                lblNapis.TextColor = Colors.Pink;
            }
        }
        private void selTlo(object sender, EventArgs e)
        {
            int kolor = pckTlo.SelectedIndex;
            if (kolor == 0)
            {
                Tlo.BackgroundColor = Colors.White;
            }
            if (kolor == 2)
            {
                Tlo.BackgroundColor = Colors.Yellow;
            }
            if (kolor == 1)
            {
                Tlo.BackgroundColor = Colors.LightBlue;
            }
            if (kolor == 3)
            {
                Tlo.BackgroundColor = Colors.Orange;
            }
        }
    }

}
