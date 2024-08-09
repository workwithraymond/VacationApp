namespace LoginPage
{
    public partial class SellBuyCar : Form
    {
        public SellBuyCar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Open Hotel
            Hotel hotel = new Hotel();
            hotel.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Open Flight
            Flight flight = new Flight();
            flight.Show();
        }
    }
}
