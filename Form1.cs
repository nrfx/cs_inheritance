namespace cs_inheritance
{
    public partial class Form1 : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.vehicles.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.vehicles.Add(Bicycle.Generate());
                        break;
                    case 1:
                        this.vehicles.Add(Car.Generate());
                        break;
                    case 2:
                        this.vehicles.Add(Airplane.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int bicycleCount = 0;
            int carCount = 0;
            int airplaneCount = 0;

            foreach (var vehicle in this.vehicles)
            {
                if (vehicle is Bicycle)
                {
                    bicycleCount++;
                }
                else if (vehicle is Car)
                {
                    carCount++;
                }
                else if (vehicle is Airplane)
                {
                    airplaneCount++;
                }
            }
            txtInfo.Text = "Велик\tМашина\tСамолет";
            txtInfo.Text += "\n";
            txtInfo.Text += $"{bicycleCount}\t{carCount}\t{airplaneCount}";
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.vehicles.Count ==  0)
            {
                txtOut.Text = "Пусто O_o"; 
                return;
            }
            
            var vehicle = this.vehicles[0];
            this.vehicles.RemoveAt(0);

            txtOut.Text = vehicle.GetInfo();
            ShowInfo();
        }
    }
}
