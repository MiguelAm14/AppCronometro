
namespace AppCronometro
{
    partial class FrmCronometro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblContador = new Label();
            btnAccionar = new Button();
            btnReiniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("7 SEGMENTAL DIGITAL DISPLAY", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContador.ForeColor = SystemColors.ControlDarkDark;
            lblContador.Location = new Point(50, 33);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(438, 94);
            lblContador.TabIndex = 0;
            lblContador.Text = "00:00:00";
            lblContador.TextAlign = ContentAlignment.MiddleCenter;
            lblContador.Click += lblContador_Click;
            // 
            // btnAccionar
            // 
            btnAccionar.BackColor = Color.Green;
            btnAccionar.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccionar.ForeColor = SystemColors.ButtonHighlight;
            btnAccionar.Location = new Point(134, 156);
            btnAccionar.Name = "btnAccionar";
            btnAccionar.Size = new Size(113, 47);
            btnAccionar.TabIndex = 1;
            btnAccionar.Text = "Iniciar";
            btnAccionar.UseVisualStyleBackColor = false;
            btnAccionar.Click += btnAccionar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReiniciar.ForeColor = SystemColors.ControlDarkDark;
            btnReiniciar.Location = new Point(276, 156);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(113, 47);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FrmCronometro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 231);
            Controls.Add(btnReiniciar);
            Controls.Add(btnAccionar);
            Controls.Add(lblContador);
            Name = "FrmCronometro";
            Text = "Cronómetro";
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private Label lblContador;
        private Button btnAccionar;
        private Button btnReiniciar;
        private System.Windows.Forms.Timer timer1;
    }
}
