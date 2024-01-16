namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIncr_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            result++;
            UpdateResultLabel();
        }

        private void buttonDecr_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            result--;
            UpdateResultLabel();
        }

         private void buttonPosition_Click(object sender, EventArgs e)
        {
            MoveFormToRandomPosition();
        }

        private void MoveFormToRandomPosition()
        {
            Random rand = new Random();
            int maxX = Screen.PrimaryScreen.Bounds.Width - Width;
            int maxY = Screen.PrimaryScreen.Bounds.Height - Height;

            Location = new Point(rand.Next(maxX), rand.Next(maxY));
        }

        private void UpdateResultLabel()
        {
            labelResult.Text = $"{result}";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           // this.ClientSize = new Size(50, 50);
            MinimumSize = new Size(40, 220);
            MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        }
    }
}