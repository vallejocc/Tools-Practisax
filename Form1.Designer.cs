namespace PractiSax
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.firstPictureBox = new System.Windows.Forms.PictureBox();
      this.checkBoxEscalas = new System.Windows.Forms.CheckBox();
      this.checkBoxProgresiones = new System.Windows.Forms.CheckBox();
      this.secondPictureBox = new System.Windows.Forms.PictureBox();
      this.thirdPictureBox = new System.Windows.Forms.PictureBox();
      this.mainTimer = new System.Windows.Forms.Timer(this.components);
      this.trackBarTimerInterval = new System.Windows.Forms.TrackBar();
      this.labelSelectTimerInterval = new System.Windows.Forms.Label();
      this.timerProgressBar = new System.Windows.Forms.ProgressBar();
      this.fourthPictureBox = new System.Windows.Forms.PictureBox();
      this.checkBoxIntervalos = new System.Windows.Forms.CheckBox();
      this.checkBoxTecnica = new System.Windows.Forms.CheckBox();
      this.textBoxEscalasTicks = new System.Windows.Forms.TextBox();
      this.textBoxProgresionesTicks = new System.Windows.Forms.TextBox();
      this.textBoxIntervalosTicks = new System.Windows.Forms.TextBox();
      this.textBoxTecnicaTicks = new System.Windows.Forms.TextBox();
      this.checkBoxEscalas2Octavas = new System.Windows.Forms.CheckBox();
      this.textBoxEscalas2OctavasTicks = new System.Windows.Forms.TextBox();
      this.textBoxProgresiones2OctavasTicks = new System.Windows.Forms.TextBox();
      this.checkBoxProgresiones2Octavas = new System.Windows.Forms.CheckBox();
      this.labelCabeceraTicks = new System.Windows.Forms.Label();
      this.labelNextChange = new System.Windows.Forms.Label();
      this.buttonCambiaNow = new System.Windows.Forms.Button();
      this.checkBoxArpegios = new System.Windows.Forms.CheckBox();
      this.checkBoxArpegios2Octavas = new System.Windows.Forms.CheckBox();
      this.textBoxArpegiosTicks = new System.Windows.Forms.TextBox();
      this.textBoxArpegios2OctavasTicks = new System.Windows.Forms.TextBox();
      this.labelPausaEntrePruebas = new System.Windows.Forms.Label();
      this.textBoxPausaEntrePruebas = new System.Windows.Forms.TextBox();
      this.buttonSemaforoEmpezarPrueba = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.thirdPictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInterval)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fourthPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // firstPictureBox
      // 
      this.firstPictureBox.Location = new System.Drawing.Point(273, 32);
      this.firstPictureBox.Name = "firstPictureBox";
      this.firstPictureBox.Size = new System.Drawing.Size(256, 256);
      this.firstPictureBox.TabIndex = 0;
      this.firstPictureBox.TabStop = false;
      this.firstPictureBox.Click += new System.EventHandler(this.firstPictureBox_Click);
      // 
      // checkBoxEscalas
      // 
      this.checkBoxEscalas.AutoSize = true;
      this.checkBoxEscalas.Location = new System.Drawing.Point(2, 32);
      this.checkBoxEscalas.Name = "checkBoxEscalas";
      this.checkBoxEscalas.Size = new System.Drawing.Size(63, 17);
      this.checkBoxEscalas.TabIndex = 1;
      this.checkBoxEscalas.Text = "Escalas";
      this.checkBoxEscalas.UseVisualStyleBackColor = true;
      // 
      // checkBoxProgresiones
      // 
      this.checkBoxProgresiones.AutoSize = true;
      this.checkBoxProgresiones.Location = new System.Drawing.Point(2, 121);
      this.checkBoxProgresiones.Name = "checkBoxProgresiones";
      this.checkBoxProgresiones.Size = new System.Drawing.Size(87, 17);
      this.checkBoxProgresiones.TabIndex = 2;
      this.checkBoxProgresiones.Text = "Progresiones";
      this.checkBoxProgresiones.UseVisualStyleBackColor = true;
      // 
      // secondPictureBox
      // 
      this.secondPictureBox.Location = new System.Drawing.Point(535, 32);
      this.secondPictureBox.Name = "secondPictureBox";
      this.secondPictureBox.Size = new System.Drawing.Size(256, 256);
      this.secondPictureBox.TabIndex = 3;
      this.secondPictureBox.TabStop = false;
      this.secondPictureBox.Click += new System.EventHandler(this.secondPictureBox_Click);
      // 
      // thirdPictureBox
      // 
      this.thirdPictureBox.Location = new System.Drawing.Point(273, 294);
      this.thirdPictureBox.Name = "thirdPictureBox";
      this.thirdPictureBox.Size = new System.Drawing.Size(256, 256);
      this.thirdPictureBox.TabIndex = 4;
      this.thirdPictureBox.TabStop = false;
      this.thirdPictureBox.Click += new System.EventHandler(this.thirdPictureBox_Click);
      // 
      // mainTimer
      // 
      this.mainTimer.Enabled = true;
      this.mainTimer.Interval = 1000;
      this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
      // 
      // trackBarTimerInterval
      // 
      this.trackBarTimerInterval.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.trackBarTimerInterval.Location = new System.Drawing.Point(2, 473);
      this.trackBarTimerInterval.Maximum = 200;
      this.trackBarTimerInterval.Name = "trackBarTimerInterval";
      this.trackBarTimerInterval.Size = new System.Drawing.Size(151, 42);
      this.trackBarTimerInterval.TabIndex = 5;
      this.trackBarTimerInterval.Scroll += new System.EventHandler(this.trackBarTimerInterval_Scroll);
      // 
      // labelSelectTimerInterval
      // 
      this.labelSelectTimerInterval.AutoSize = true;
      this.labelSelectTimerInterval.Location = new System.Drawing.Point(-1, 454);
      this.labelSelectTimerInterval.Name = "labelSelectTimerInterval";
      this.labelSelectTimerInterval.Size = new System.Drawing.Size(91, 13);
      this.labelSelectTimerInterval.TabIndex = 6;
      this.labelSelectTimerInterval.Text = "Intervalo 1000 ms";
      // 
      // timerProgressBar
      // 
      this.timerProgressBar.Location = new System.Drawing.Point(2, 520);
      this.timerProgressBar.Maximum = 9;
      this.timerProgressBar.Name = "timerProgressBar";
      this.timerProgressBar.Size = new System.Drawing.Size(151, 23);
      this.timerProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.timerProgressBar.TabIndex = 7;
      // 
      // fourthPictureBox
      // 
      this.fourthPictureBox.Location = new System.Drawing.Point(535, 294);
      this.fourthPictureBox.Name = "fourthPictureBox";
      this.fourthPictureBox.Size = new System.Drawing.Size(256, 256);
      this.fourthPictureBox.TabIndex = 8;
      this.fourthPictureBox.TabStop = false;
      this.fourthPictureBox.Click += new System.EventHandler(this.fourthPictureBox_Click);
      // 
      // checkBoxIntervalos
      // 
      this.checkBoxIntervalos.AutoSize = true;
      this.checkBoxIntervalos.Location = new System.Drawing.Point(2, 166);
      this.checkBoxIntervalos.Name = "checkBoxIntervalos";
      this.checkBoxIntervalos.Size = new System.Drawing.Size(72, 17);
      this.checkBoxIntervalos.TabIndex = 9;
      this.checkBoxIntervalos.Text = "Intervalos";
      this.checkBoxIntervalos.UseVisualStyleBackColor = true;
      // 
      // checkBoxTecnica
      // 
      this.checkBoxTecnica.AutoSize = true;
      this.checkBoxTecnica.Location = new System.Drawing.Point(2, 189);
      this.checkBoxTecnica.Name = "checkBoxTecnica";
      this.checkBoxTecnica.Size = new System.Drawing.Size(65, 17);
      this.checkBoxTecnica.TabIndex = 10;
      this.checkBoxTecnica.Text = "Técnica";
      this.checkBoxTecnica.UseVisualStyleBackColor = true;
      // 
      // textBoxEscalasTicks
      // 
      this.textBoxEscalasTicks.Location = new System.Drawing.Point(109, 32);
      this.textBoxEscalasTicks.Name = "textBoxEscalasTicks";
      this.textBoxEscalasTicks.Size = new System.Drawing.Size(35, 20);
      this.textBoxEscalasTicks.TabIndex = 11;
      this.textBoxEscalasTicks.Text = "4";
      this.textBoxEscalasTicks.TextChanged += new System.EventHandler(this.textBoxEscalasTicks_TextChanged);
      // 
      // textBoxProgresionesTicks
      // 
      this.textBoxProgresionesTicks.Location = new System.Drawing.Point(109, 120);
      this.textBoxProgresionesTicks.Name = "textBoxProgresionesTicks";
      this.textBoxProgresionesTicks.Size = new System.Drawing.Size(35, 20);
      this.textBoxProgresionesTicks.TabIndex = 12;
      this.textBoxProgresionesTicks.Text = "42";
      this.textBoxProgresionesTicks.TextChanged += new System.EventHandler(this.textBoxProgresionesTicks_TextChanged);
      // 
      // textBoxIntervalosTicks
      // 
      this.textBoxIntervalosTicks.Location = new System.Drawing.Point(109, 163);
      this.textBoxIntervalosTicks.Name = "textBoxIntervalosTicks";
      this.textBoxIntervalosTicks.Size = new System.Drawing.Size(35, 20);
      this.textBoxIntervalosTicks.TabIndex = 13;
      this.textBoxIntervalosTicks.Text = "1";
      this.textBoxIntervalosTicks.TextChanged += new System.EventHandler(this.textBoxIntervalosTicks_TextChanged);
      // 
      // textBoxTecnicaTicks
      // 
      this.textBoxTecnicaTicks.Location = new System.Drawing.Point(109, 186);
      this.textBoxTecnicaTicks.Name = "textBoxTecnicaTicks";
      this.textBoxTecnicaTicks.Size = new System.Drawing.Size(35, 20);
      this.textBoxTecnicaTicks.TabIndex = 14;
      this.textBoxTecnicaTicks.Text = "120";
      this.textBoxTecnicaTicks.TextChanged += new System.EventHandler(this.textBoxTecnicaTicks_TextChanged);
      // 
      // checkBoxEscalas2Octavas
      // 
      this.checkBoxEscalas2Octavas.AutoSize = true;
      this.checkBoxEscalas2Octavas.Location = new System.Drawing.Point(2, 55);
      this.checkBoxEscalas2Octavas.Name = "checkBoxEscalas2Octavas";
      this.checkBoxEscalas2Octavas.Size = new System.Drawing.Size(72, 17);
      this.checkBoxEscalas2Octavas.TabIndex = 15;
      this.checkBoxEscalas2Octavas.Text = "Escalas 2";
      this.checkBoxEscalas2Octavas.UseVisualStyleBackColor = true;
      // 
      // textBoxEscalas2OctavasTicks
      // 
      this.textBoxEscalas2OctavasTicks.Location = new System.Drawing.Point(109, 53);
      this.textBoxEscalas2OctavasTicks.Name = "textBoxEscalas2OctavasTicks";
      this.textBoxEscalas2OctavasTicks.Size = new System.Drawing.Size(35, 20);
      this.textBoxEscalas2OctavasTicks.TabIndex = 16;
      this.textBoxEscalas2OctavasTicks.Text = "18";
      this.textBoxEscalas2OctavasTicks.TextChanged += new System.EventHandler(this.textBoxEscalas2OctavasTicks_TextChanged);
      // 
      // textBoxProgresiones2OctavasTicks
      // 
      this.textBoxProgresiones2OctavasTicks.Location = new System.Drawing.Point(109, 141);
      this.textBoxProgresiones2OctavasTicks.Name = "textBoxProgresiones2OctavasTicks";
      this.textBoxProgresiones2OctavasTicks.Size = new System.Drawing.Size(35, 20);
      this.textBoxProgresiones2OctavasTicks.TabIndex = 17;
      this.textBoxProgresiones2OctavasTicks.Text = "96";
      this.textBoxProgresiones2OctavasTicks.TextChanged += new System.EventHandler(this.textBoxProgresiones2OctavasTicks_TextChanged);
      // 
      // checkBoxProgresiones2Octavas
      // 
      this.checkBoxProgresiones2Octavas.AutoSize = true;
      this.checkBoxProgresiones2Octavas.Location = new System.Drawing.Point(2, 143);
      this.checkBoxProgresiones2Octavas.Name = "checkBoxProgresiones2Octavas";
      this.checkBoxProgresiones2Octavas.Size = new System.Drawing.Size(96, 17);
      this.checkBoxProgresiones2Octavas.TabIndex = 18;
      this.checkBoxProgresiones2Octavas.Text = "Progresiones 2";
      this.checkBoxProgresiones2Octavas.UseVisualStyleBackColor = true;
      // 
      // labelCabeceraTicks
      // 
      this.labelCabeceraTicks.AutoSize = true;
      this.labelCabeceraTicks.Location = new System.Drawing.Point(109, 13);
      this.labelCabeceraTicks.Name = "labelCabeceraTicks";
      this.labelCabeceraTicks.Size = new System.Drawing.Size(33, 13);
      this.labelCabeceraTicks.TabIndex = 19;
      this.labelCabeceraTicks.Text = "Ticks";
      // 
      // labelNextChange
      // 
      this.labelNextChange.AutoSize = true;
      this.labelNextChange.Location = new System.Drawing.Point(-1, 431);
      this.labelNextChange.Name = "labelNextChange";
      this.labelNextChange.Size = new System.Drawing.Size(91, 13);
      this.labelNextChange.TabIndex = 20;
      this.labelNextChange.Text = "Cambio en 0 ticks";
      // 
      // buttonCambiaNow
      // 
      this.buttonCambiaNow.Location = new System.Drawing.Point(103, 426);
      this.buttonCambiaNow.Name = "buttonCambiaNow";
      this.buttonCambiaNow.Size = new System.Drawing.Size(50, 23);
      this.buttonCambiaNow.TabIndex = 21;
      this.buttonCambiaNow.Text = "Cambia";
      this.buttonCambiaNow.UseVisualStyleBackColor = true;
      this.buttonCambiaNow.Click += new System.EventHandler(this.buttonCambiaNow_Click);
      // 
      // checkBoxArpegios
      // 
      this.checkBoxArpegios.AutoSize = true;
      this.checkBoxArpegios.Location = new System.Drawing.Point(2, 78);
      this.checkBoxArpegios.Name = "checkBoxArpegios";
      this.checkBoxArpegios.Size = new System.Drawing.Size(67, 17);
      this.checkBoxArpegios.TabIndex = 22;
      this.checkBoxArpegios.Text = "Arpegios";
      this.checkBoxArpegios.UseVisualStyleBackColor = true;
      // 
      // checkBoxArpegios2Octavas
      // 
      this.checkBoxArpegios2Octavas.AutoSize = true;
      this.checkBoxArpegios2Octavas.Location = new System.Drawing.Point(2, 100);
      this.checkBoxArpegios2Octavas.Name = "checkBoxArpegios2Octavas";
      this.checkBoxArpegios2Octavas.Size = new System.Drawing.Size(76, 17);
      this.checkBoxArpegios2Octavas.TabIndex = 23;
      this.checkBoxArpegios2Octavas.Text = "Arpegios 2";
      this.checkBoxArpegios2Octavas.UseVisualStyleBackColor = true;
      // 
      // textBoxArpegiosTicks
      // 
      this.textBoxArpegiosTicks.Location = new System.Drawing.Point(109, 75);
      this.textBoxArpegiosTicks.Name = "textBoxArpegiosTicks";
      this.textBoxArpegiosTicks.Size = new System.Drawing.Size(35, 20);
      this.textBoxArpegiosTicks.TabIndex = 24;
      this.textBoxArpegiosTicks.Text = "2";
      // 
      // textBoxArpegios2OctavasTicks
      // 
      this.textBoxArpegios2OctavasTicks.Location = new System.Drawing.Point(109, 97);
      this.textBoxArpegios2OctavasTicks.Name = "textBoxArpegios2OctavasTicks";
      this.textBoxArpegios2OctavasTicks.Size = new System.Drawing.Size(35, 20);
      this.textBoxArpegios2OctavasTicks.TabIndex = 25;
      this.textBoxArpegios2OctavasTicks.Text = "9";
      // 
      // labelPausaEntrePruebas
      // 
      this.labelPausaEntrePruebas.AutoSize = true;
      this.labelPausaEntrePruebas.Location = new System.Drawing.Point(-1, 240);
      this.labelPausaEntrePruebas.Name = "labelPausaEntrePruebas";
      this.labelPausaEntrePruebas.Size = new System.Drawing.Size(105, 13);
      this.labelPausaEntrePruebas.TabIndex = 26;
      this.labelPausaEntrePruebas.Text = "Pausa entre pruebas";
      // 
      // textBoxPausaEntrePruebas
      // 
      this.textBoxPausaEntrePruebas.Location = new System.Drawing.Point(109, 233);
      this.textBoxPausaEntrePruebas.Name = "textBoxPausaEntrePruebas";
      this.textBoxPausaEntrePruebas.Size = new System.Drawing.Size(35, 20);
      this.textBoxPausaEntrePruebas.TabIndex = 27;
      this.textBoxPausaEntrePruebas.Text = "2";
      this.textBoxPausaEntrePruebas.TextChanged += new System.EventHandler(this.textBoxPausaEntrePruebas_TextChanged);
      // 
      // buttonSemaforoEmpezarPrueba
      // 
      this.buttonSemaforoEmpezarPrueba.BackColor = System.Drawing.Color.Red;
      this.buttonSemaforoEmpezarPrueba.Location = new System.Drawing.Point(273, 3);
      this.buttonSemaforoEmpezarPrueba.Name = "buttonSemaforoEmpezarPrueba";
      this.buttonSemaforoEmpezarPrueba.Size = new System.Drawing.Size(518, 23);
      this.buttonSemaforoEmpezarPrueba.TabIndex = 28;
      this.buttonSemaforoEmpezarPrueba.Text = "WAIT";
      this.buttonSemaforoEmpezarPrueba.UseVisualStyleBackColor = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(803, 555);
      this.Controls.Add(this.buttonSemaforoEmpezarPrueba);
      this.Controls.Add(this.textBoxPausaEntrePruebas);
      this.Controls.Add(this.labelPausaEntrePruebas);
      this.Controls.Add(this.textBoxArpegios2OctavasTicks);
      this.Controls.Add(this.textBoxArpegiosTicks);
      this.Controls.Add(this.checkBoxArpegios2Octavas);
      this.Controls.Add(this.checkBoxArpegios);
      this.Controls.Add(this.buttonCambiaNow);
      this.Controls.Add(this.labelNextChange);
      this.Controls.Add(this.labelCabeceraTicks);
      this.Controls.Add(this.checkBoxProgresiones2Octavas);
      this.Controls.Add(this.textBoxProgresiones2OctavasTicks);
      this.Controls.Add(this.textBoxEscalas2OctavasTicks);
      this.Controls.Add(this.checkBoxEscalas2Octavas);
      this.Controls.Add(this.textBoxTecnicaTicks);
      this.Controls.Add(this.textBoxIntervalosTicks);
      this.Controls.Add(this.textBoxProgresionesTicks);
      this.Controls.Add(this.textBoxEscalasTicks);
      this.Controls.Add(this.checkBoxTecnica);
      this.Controls.Add(this.checkBoxIntervalos);
      this.Controls.Add(this.fourthPictureBox);
      this.Controls.Add(this.timerProgressBar);
      this.Controls.Add(this.labelSelectTimerInterval);
      this.Controls.Add(this.trackBarTimerInterval);
      this.Controls.Add(this.thirdPictureBox);
      this.Controls.Add(this.secondPictureBox);
      this.Controls.Add(this.checkBoxProgresiones);
      this.Controls.Add(this.checkBoxEscalas);
      this.Controls.Add(this.firstPictureBox);
      this.Name = "Form1";
      this.Text = "PractiSax";
      ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.thirdPictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInterval)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fourthPictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox firstPictureBox;
    private System.Windows.Forms.CheckBox checkBoxEscalas;
    private System.Windows.Forms.CheckBox checkBoxProgresiones;
    private System.Windows.Forms.PictureBox secondPictureBox;
    private System.Windows.Forms.PictureBox thirdPictureBox;
    private System.Windows.Forms.Timer mainTimer;
    private System.Windows.Forms.TrackBar trackBarTimerInterval;
    private System.Windows.Forms.Label labelSelectTimerInterval;
    private System.Windows.Forms.ProgressBar timerProgressBar;
    private System.Windows.Forms.PictureBox fourthPictureBox;
    private System.Windows.Forms.CheckBox checkBoxIntervalos;
    private System.Windows.Forms.CheckBox checkBoxTecnica;
    private System.Windows.Forms.TextBox textBoxEscalasTicks;
    private System.Windows.Forms.TextBox textBoxProgresionesTicks;
    private System.Windows.Forms.TextBox textBoxIntervalosTicks;
    private System.Windows.Forms.TextBox textBoxTecnicaTicks;
    private System.Windows.Forms.CheckBox checkBoxEscalas2Octavas;
    private System.Windows.Forms.TextBox textBoxEscalas2OctavasTicks;
    private System.Windows.Forms.TextBox textBoxProgresiones2OctavasTicks;
    private System.Windows.Forms.CheckBox checkBoxProgresiones2Octavas;
    private System.Windows.Forms.Label labelCabeceraTicks;
    private System.Windows.Forms.Label labelNextChange;
    private System.Windows.Forms.Button buttonCambiaNow;
    private System.Windows.Forms.CheckBox checkBoxArpegios;
    private System.Windows.Forms.CheckBox checkBoxArpegios2Octavas;
    private System.Windows.Forms.TextBox textBoxArpegiosTicks;
    private System.Windows.Forms.TextBox textBoxArpegios2OctavasTicks;
    private System.Windows.Forms.Label labelPausaEntrePruebas;
    private System.Windows.Forms.TextBox textBoxPausaEntrePruebas;
    private System.Windows.Forms.Button buttonSemaforoEmpezarPrueba;
  }
}

