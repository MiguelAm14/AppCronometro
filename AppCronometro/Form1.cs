namespace AppCronometro
{
    public partial class FrmCronometro : Form
    {
        // Declaración de variables de tiempo, y control del cronometro
        int horas, minutos, segundos;
        Boolean play;

        public FrmCronometro()
        {
            InitializeComponent();
            horas = minutos = segundos = 0;
            play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tiempo;
            // Aumentar los segundos, minutos y horas de acuerdo con el timer.
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }
            if (minutos == 60)
            {
                minutos = 0;
                horas++;
            }

            tiempo = horas.ToString("00") + ":" + minutos.ToString("00") + ":" + segundos.ToString("00");
            lblContador.Text = tiempo;

        }

        private void btnAccionar_Click(object sender, EventArgs e)
        {
            // Si el cronometro esta en marcha, el botón cambia a parar.
            if (play == true)
            {
                timer1.Stop();
                play = false;
                btnAccionar.BackColor = Color.Green;
                btnAccionar.Text = "Iniciar";
                return;
            }

            // Si el cronometro esta parado, cambia a iniciar.
            timer1.Enabled = true;
            timer1.Start();
            play = true;
            btnAccionar.BackColor = Color.Red;
            btnAccionar.Text = "Parar";
            
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Se detiene el timer y se reinician las horas, minutos y segundos.
            timer1.Stop();
            play = false;
            btnAccionar.BackColor = Color.Green;
            btnAccionar.Text = "Iniciar";
            horas = minutos = segundos = 0;
            lblContador.Text = "00:00:00";
        }


    }
}
