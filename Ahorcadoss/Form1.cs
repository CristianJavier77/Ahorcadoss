using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcadoss
{
    public partial class Form1 : Form
    {
        char[] PalabrasAdivinadas; int Oportunidades;
        char[] PalabraSeleccionada;
        char[] Alfabeto;
        String[] Palabras;
        public Form1()
        {
            InitializeComponent();
        }
        public void IniciarJuego()
        {
            flFichasDeJuego.Controls.Clear();
            flFichasDeJuego.Enabled = true;
            picAhorcado.Image = null;
            lblMensaje.Visible = false;
            Oportunidades = 0;
            btnIniciarJuego.Image = Properties.Resources.Jugando;
            Palabras = new string[] { "mango", "habichuela", "guineo" };
            Alfabeto = "abcdefghijklmnñopqrstuvwxyz".ToCharArray();
            Random random = new Random();
            int indicepalabrasseleccionada = random.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[indicepalabrasseleccionada].ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabraSeleccionada;

            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichasDeJuego.Controls.Add(btnLetra);
            }
            flPalabra.Controls.Clear();

            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
            {
                Button Letra = new Button();
                Letra.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.Purple;
                Letra.Text = "-";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "Adivinado" + IndiceValorLetra.ToString();
                Letra.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Acertijo));
                flPalabra.Controls.Add(Letra);
            }

        }

        void Compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            for (int indicerevisar = 0; indicerevisar < PalabrasAdivinadas.Length; indicerevisar++)
            {
                if (PalabrasAdivinadas[indicerevisar] == Char.Parse(btn.Text))
                {
                    Button tbx = this.Controls.Find("Adivinado" + indicerevisar, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinadas[indicerevisar].ToString();
                    PalabrasAdivinadas[indicerevisar] = '-';
                    encontrado = true;
                }
            }
            bool Ganaste = true;
            for (int IndiceAnalizadorGanador = 0; IndiceAnalizadorGanador < PalabrasAdivinadas.Length; IndiceAnalizadorGanador++)
            {
                if (PalabrasAdivinadas[IndiceAnalizadorGanador] != '-')
                {
                    Ganaste = false;
                }
            }
            if (Ganaste) { MessageBox.Show("Ganaste"); btnIniciarJuego.Image = Properties.Resources.BtnStart; }
            if (!encontrado)
            {
                Oportunidades = Oportunidades + 1;
                picAhorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Ahorcado" + Oportunidades);

                if (Oportunidades == 8)
                {
                    lblMensaje.Visible = true;
                    for (int indicevalorletra = 0; indicevalorletra < PalabraSeleccionada.Length; indicevalorletra++)
                    {
                        Button btnletra = this.Controls.Find("adivinado" + indicevalorletra, true).FirstOrDefault() as Button;
                        btnletra.Text = btnletra.Tag.ToString();
                    }
                    flFichasDeJuego.Enabled = false;
                    btnIniciarJuego.Image = Properties.Resources.BtnStart;
                }
            }
        }




            private void Form1_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void BtnIniciarJuego_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }
    }
}
