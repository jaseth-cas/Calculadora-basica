namespace Calculadora_basica
{
    public partial class Form1 : Form
    {
        double op1 = 0, op2 = 0;
        string opera = "";
        bool n_entrada = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Text_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;

            // Si es una nueva entrada o el texto contiene operador, limpiar
            if (n_entrada || TxtBx_res.Text.Contains("×") || TxtBx_res.Text.Contains("÷") || TxtBx_res.Text.Contains("+") || TxtBx_res.Text.Contains("-"))
            {
                TxtBx_res.Text = "0";
                n_entrada = false;
            }

            // Límite de 12 caracteres
            if (TxtBx_res.Text.Length >= 12)
                return;

            // Reemplazar el 0 o concatenar
            if (TxtBx_res.Text == "0")
                TxtBx_res.Text = numero;
            else
                TxtBx_res.Text += numero;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Evita operadores seguidos
            if (n_entrada)
                return;

            // Intenta guardar el primer número respetando decimales
            string texto = TxtBx_res.Text;

            // Si el texto termina en un operador, quítalo (evita duplicados)
            if (texto.EndsWith("+") || texto.EndsWith("-") || texto.EndsWith("*") || texto.EndsWith("÷") || texto.EndsWith("×"))
                texto = texto.Substring(0, texto.Length - 1);

            if (double.TryParse(texto, System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture, out op1))
            {
                opera = btn.Text; // Guarda el operador seleccionado

                // Muestra el número con decimales + operador en la barra
                TxtBx_res.Text = op1.ToString("0.###", System.Globalization.CultureInfo.InvariantCulture) + opera;
                n_entrada = true;
            }
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            double resultado = 0;

            // Evita intentar leer texto con operador
            string texto = TxtBx_res.Text;
            // Quita el operador visual si está al final
            if (texto.EndsWith("+") || texto.EndsWith("-") || texto.EndsWith("*") || texto.EndsWith("÷") || texto.EndsWith("×"))
                texto = texto.Substring(0, texto.Length - 1);

            if (!double.TryParse(texto, System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.InvariantCulture, out op2))
                return;

            try
            {
                switch (opera)
                {
                    case "*":
                    case "×":
                        resultado = op1 * op2;
                        break;
                    case "÷":
                        if (op2 == 0)
                        {
                            TxtBx_res.Text = "Error";
                            return;
                        }
                        resultado = op1 / op2;
                        break;
                    case "+": // Suma
                        resultado = op1 + op2;
                        break;
                    case "-": // Resta
                        resultado = op1 - op2;
                        break;
                }

                // Mostrar resultado con máximo 10 decimales
                TxtBx_res.Text = resultado.ToString("0.###", System.Globalization.CultureInfo.InvariantCulture);
                op1 = resultado;
                n_entrada = true;
            }
            catch
            {
                TxtBx_res.Text = "Error";
            }
        }

        private void Btn_Limp_Click(object sender, EventArgs e)
        {
            TxtBx_res.Text = "0";   // Reinicia el display
            op1 = 0;
            op2 = 0;
            opera = "";
            n_entrada = false;
        }

        private void Btn_borr_Click(object sender, EventArgs e)
        {
            if (TxtBx_res.Text.Length > 1)
                TxtBx_res.Text = TxtBx_res.Text.Substring(0, TxtBx_res.Text.Length - 1);
            else
                TxtBx_res.Text = "0";
        }

        private void Btn_punto_Click(object sender, EventArgs e)
        {
            if (n_entrada || TxtBx_res.Text.Contains("*") || TxtBx_res.Text.Contains("÷") || TxtBx_res.Text.Contains("+") || TxtBx_res.Text.Contains("-"))
            {
                TxtBx_res.Text = "0";
                n_entrada = false;
            }

            if (!TxtBx_res.Text.Contains("."))
                TxtBx_res.Text += ".";
        }

        private void Btn_mas_Click(object sender, EventArgs e)
        {
            btnOperador_Click(sender, e);
        }

        private void Btn_menos_Click(object sender, EventArgs e)
        {
            btnOperador_Click(sender, e);
        }

    }
}

