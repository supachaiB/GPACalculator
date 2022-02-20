namespace GPAxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
            //create object
            GPACalculator oGPACal = new GPACalculator();
        private void button1_Click(object sender, EventArgs e)
        {
            
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;
            

            double dInput = Convert.ToDouble(input);
            oGPACal.addGPA(dInput, name);

            double gpax = oGPACal.getGPAx();//
            textBoxGPAx.Text = gpax.ToString();//

            
            double max = oGPACal.getMax();
            textBoxMaxGPA.Text = max.ToString();
            textMaxName.Text = oGPACal.getMaxName().ToString();

            double min = oGPACal.getMin();
            textBoxMinGPA.Text = min.ToString();
            textMinName.Text = oGPACal.getMinName().ToString();



            textBoxGPA_input.Text = "";
            textBoxName_input.Text = String.Empty;
            textBoxAllData.Text = oGPACal.getAllData();



        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxGPA_input.Text = "";
            textBoxName_input.Text = "";
            textBoxMinGPA.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxGPAx.Text = "";
            textMaxName.Text = "";
            textMinName.Text = "";
            textBoxAllData.Text = "";

            
        }
    }
}