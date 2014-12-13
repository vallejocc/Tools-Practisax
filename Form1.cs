using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PractiSax
{
  public partial class Form1 : Form
  {
    public const int trackBarTimerStep = 10;
    
    int timerCount = 0;
    int timerTrackBarDirection = 0;
    DateTime lastTimeMed;

    int LockImagesForNTicks = 0;
    int PausaEntreImagenesTicks = 0;
    
    //cacheamos en memoria el contenido de mybeepsound.wav para evitar lecturas de disco
    byte[] BeepSoundData;
    System.IO.MemoryStream BeepSoundMemoryStream;
    System.Media.SoundPlayer beepPlayer;
    
    //cacheamos tambien las imagenes para cada tipo de prueba
    const int nTiposPruebas = 8;
    String [] tiposPruebas = {"Escalas", 
                              "Escalas2Octavas", 
                              "Arpegios", 
                              "Arpegios2Octavas", 
                              "Progresiones", 
                              "Progresiones2Octavas", 
                              "Intervalos", 
                              "Tecnica"};
    CheckBox[] tiposPruebasCheckBoxes = new CheckBox[nTiposPruebas];
    TextBox[] tiposPruebasTextBoxesTicks = new TextBox[nTiposPruebas];
    ImageList[] Imagenes1ParaPruebas = new ImageList[nTiposPruebas];
    ImageList[] Imagenes2ParaPruebas = new ImageList[nTiposPruebas];
    ImageList[] Imagenes3ParaPruebas = new ImageList[nTiposPruebas];
    ImageList[] Imagenes4ParaPruebas = new ImageList[nTiposPruebas];

    public void InitializeImages()
    {
      tiposPruebasCheckBoxes[0] = checkBoxEscalas;
      tiposPruebasCheckBoxes[1] = checkBoxEscalas2Octavas;
      tiposPruebasCheckBoxes[2] = checkBoxArpegios;
      tiposPruebasCheckBoxes[3] = checkBoxArpegios2Octavas;
      tiposPruebasCheckBoxes[4] = checkBoxProgresiones;
      tiposPruebasCheckBoxes[5] = checkBoxProgresiones2Octavas;
      tiposPruebasCheckBoxes[6] = checkBoxIntervalos;
      tiposPruebasCheckBoxes[7] = checkBoxTecnica;

      tiposPruebasTextBoxesTicks[0] = textBoxEscalasTicks;
      tiposPruebasTextBoxesTicks[1] = textBoxEscalas2OctavasTicks;
      tiposPruebasTextBoxesTicks[2] = textBoxArpegiosTicks;
      tiposPruebasTextBoxesTicks[3] = textBoxArpegios2OctavasTicks;
      tiposPruebasTextBoxesTicks[4] = textBoxProgresionesTicks;
      tiposPruebasTextBoxesTicks[5] = textBoxProgresiones2OctavasTicks;
      tiposPruebasTextBoxesTicks[6] = textBoxIntervalosTicks;
      tiposPruebasTextBoxesTicks[7] = textBoxTecnicaTicks;


      for (int i = 0; i < nTiposPruebas; i++)
      {
        Imagenes1ParaPruebas[i] = new ImageList();
        Imagenes1ParaPruebas[i].ImageSize = new Size(256, 256);
        Imagenes2ParaPruebas[i] = new ImageList();
        Imagenes2ParaPruebas[i].ImageSize = new Size(256, 256);
        Imagenes3ParaPruebas[i] = new ImageList();
        Imagenes3ParaPruebas[i].ImageSize = new Size(256, 256);
        Imagenes4ParaPruebas[i] = new ImageList();
        Imagenes4ParaPruebas[i].ImageSize = new Size(256, 256);
      }

      for (int i = 0; i < nTiposPruebas; i++)
      {
        foreach (var filepath in System.IO.Directory.EnumerateFiles("imagenes\\" + tiposPruebas[i] + "\\1"))
        {
          Imagenes1ParaPruebas[i].Images.Add(Image.FromFile(filepath));
        }

        foreach (var filepath in System.IO.Directory.EnumerateFiles("imagenes\\" + tiposPruebas[i] + "\\2"))
        {
          Imagenes2ParaPruebas[i].Images.Add(Image.FromFile(filepath));
        }

        foreach (var filepath in System.IO.Directory.EnumerateFiles("imagenes\\" + tiposPruebas[i] + "\\3"))
        {
          Imagenes3ParaPruebas[i].Images.Add(Image.FromFile(filepath));
        }

        foreach (var filepath in System.IO.Directory.EnumerateFiles("imagenes\\" + tiposPruebas[i] + "\\4"))
        {
          Imagenes4ParaPruebas[i].Images.Add(Image.FromFile(filepath));
        }
      }
    }

    public Form1()
    {
      InitializeComponent();

      InitializeImages();

      BeepSoundData = System.IO.File.ReadAllBytes(@"mybeepsound.wav");
      BeepSoundMemoryStream = new System.IO.MemoryStream(BeepSoundData);      
      beepPlayer = new System.Media.SoundPlayer(BeepSoundMemoryStream);
      beepPlayer.Load();

      trackBarTimerInterval.Value = trackBarTimerInterval.Maximum/2;
      timerProgressBar.Value = 0;
      mainTimer.Interval = (trackBarTimerInterval.Value * trackBarTimerStep) / 10;
      labelSelectTimerInterval.Text = "Metrónomo " + (trackBarTimerInterval.Value * trackBarTimerStep).ToString() + " ms " + (60000 / (trackBarTimerInterval.Value * trackBarTimerStep)).ToString() + " bpm";
      lastTimeMed = DateTime.Now;
    }

    private void firstPictureBox_Click(object sender, EventArgs e){}
    private void secondPictureBox_Click(object sender, EventArgs e){}
    private void thirdPictureBox_Click(object sender, EventArgs e){}
    private void fourthPictureBox_Click(object sender, EventArgs e){}


    private void ChangePictureBoxes(int PausaEntreImagenesTicks)
    {
      //Bitmap myImage = new Bitmap("imagenes\\escalas\\a.bmp");
      //mainPictureBox.Image = myImage;

      Random rnd = new Random();

      int nPruebasActivadas = 0;

      for (int i = 0; i < nTiposPruebas; i++)
        if (tiposPruebasCheckBoxes[i].Checked)
          nPruebasActivadas++;

      firstPictureBox.Image = null;
      secondPictureBox.Image = null;
      thirdPictureBox.Image = null;
      fourthPictureBox.Image = null;

      if (nPruebasActivadas > 0)
      {
        int x = rnd.Next(0, nPruebasActivadas);

        for (int i = 0; i < nTiposPruebas; i++)
        {
          if (tiposPruebasCheckBoxes[i].Checked)
          {
            if (x == 0)
            {
              LockImagesForNTicks = Convert.ToInt32(tiposPruebasTextBoxesTicks[i].Text) + PausaEntreImagenesTicks;

              if (Imagenes1ParaPruebas[i].Images.Count > 0)
              {
                firstPictureBox.Image = Imagenes1ParaPruebas[i].Images[rnd.Next(0, Imagenes1ParaPruebas[i].Images.Count)];
              }

              if (Imagenes2ParaPruebas[i].Images.Count > 0)
              {
                secondPictureBox.Image = Imagenes2ParaPruebas[i].Images[rnd.Next(0, Imagenes2ParaPruebas[i].Images.Count)];
              }

              if (Imagenes3ParaPruebas[i].Images.Count > 0)
              {
                thirdPictureBox.Image = Imagenes3ParaPruebas[i].Images[rnd.Next(0, Imagenes3ParaPruebas[i].Images.Count)];
              }

              if (Imagenes4ParaPruebas[i].Images.Count > 0)
              {
                fourthPictureBox.Image = Imagenes4ParaPruebas[i].Images[rnd.Next(0, Imagenes4ParaPruebas[i].Images.Count)];
              }

              break;
            }
            else
            {
              x--;
            }
          }
        }
      }
    }

    private void ManageBeep()
    {
      if (LockImagesForNTicks > 0)
      {
        LockImagesForNTicks--;
        labelNextChange.Text = "Cambio en " + LockImagesForNTicks.ToString() + " ticks";
      }
      else 
      {
        PausaEntreImagenesTicks = Convert.ToInt32(textBoxPausaEntrePruebas.Text);
        ChangePictureBoxes(PausaEntreImagenesTicks);
        labelNextChange.Text = "Cambio en " + LockImagesForNTicks.ToString() + " ticks";
      }

      if (PausaEntreImagenesTicks > 0)
      {
        PausaEntreImagenesTicks--;
        buttonSemaforoEmpezarPrueba.BackColor = Color.Red;
        buttonSemaforoEmpezarPrueba.Text = "WAIT";
      }
      else
      {
        buttonSemaforoEmpezarPrueba.BackColor = Color.Green;
        buttonSemaforoEmpezarPrueba.Text = "GO GO GO";
      }
    }

    private void buttonCambiaNow_Click(object sender, EventArgs e)
    {
      LockImagesForNTicks = 0;
      labelNextChange.Text = "Cambio en 0 ticks";
    }

    private void mainTimer_Tick(object sender, EventArgs e)
    {
      timerCount++;
      
      if (timerTrackBarDirection == 0) timerProgressBar.Value++;
      else timerProgressBar.Value--;


      if (timerCount == 9)
      {
        if (timerTrackBarDirection == 0) timerTrackBarDirection = 1;
        else timerTrackBarDirection = 0;
        timerCount = 0;

        //hacemos un pequeno reajuste en el timer
        DateTime now = DateTime.Now;
        var seconds = (now - lastTimeMed).TotalSeconds;
        lastTimeMed = now;
        if (seconds * 1000 < (trackBarTimerInterval.Value * trackBarTimerStep))
          System.Threading.Thread.Sleep(Convert.ToInt32((trackBarTimerInterval.Value * trackBarTimerStep) - seconds * 1000));

        beepPlayer.Play();

        ManageBeep();
      }      
    }

    private void trackBarTimerInterval_Scroll(object sender, EventArgs e)
    {
      if (trackBarTimerInterval.Value == 0)
      {
        mainTimer.Enabled = false;
        labelSelectTimerInterval.Text = "Metrónomo 0 ms 0 bpm";
      }
      else
      {
        mainTimer.Enabled = true;
        mainTimer.Interval = (trackBarTimerInterval.Value * trackBarTimerStep) / 10;
        labelSelectTimerInterval.Text = "Metrónomo " + (trackBarTimerInterval.Value * trackBarTimerStep).ToString() + " ms " + (60000 / (trackBarTimerInterval.Value * trackBarTimerStep)).ToString() + " bpm";
      }
    }

    private void textBoxEscalasTicks_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxProgresionesTicks_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxIntervalosTicks_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxTecnicaTicks_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxEscalas2OctavasTicks_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxProgresiones2OctavasTicks_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxPausaEntrePruebas_TextChanged(object sender, EventArgs e)
    {

    }
  }
}


