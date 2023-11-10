namespace Práctica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)   //Se declara que la variable "i" en el ciclo "for" haga que cuente desde 1 hasta que el 4.
            {


                listBox1.Items.Add(i); //Se declara que cada vez que ocurra el ciclo se  muestre en la list box el resultado de i.


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}