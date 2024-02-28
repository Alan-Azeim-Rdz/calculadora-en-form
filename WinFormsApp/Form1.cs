namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double operador1;
        private string operacion;
        public Form1()
        {
            InitializeComponent();
            operador1 = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string TextoDelBoton = ((Button)sender).Text;
            txtPantalla.Text += TextoDelBoton;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            string TextoDelBoton = ((Button)sender).Text;
            operador1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
            operacion = TextoDelBoton;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = operador1 + double.Parse(txtPantalla.Text);
                    break;
                case "-":
                    resultado = operador1 - double.Parse(txtPantalla.Text);
                    break;
                case "/":
                    if (operador1 != 0)
                    {
                        resultado = operador1 / double.Parse(txtPantalla.Text);
                    }
                    else
                    {
                        resultado = 0;
                    }
                    break;
                case "x":
                    if (operador1 != 0)
                    {
                        resultado = operador1 * double.Parse(txtPantalla.Text);
                    }
                    else
                    {
                        resultado = 0;
                    }
                    break;
            }

            txtPantalla.Text = resultado.ToString();
        }
    }
}