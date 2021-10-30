using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class InsideFormLandmarks : Form
    {
        
        SpeechSynthesizer spee = new SpeechSynthesizer();
        public InsideFormLandmarks()
        {
            InitializeComponent();
            
        }
        private void InsideFormAccommodations_Load(object sender, EventArgs e)
        {

        }





        private void CrownePlazaAthens_Click(object sender, EventArgs e)
        {
            if (StaticFieldsClass.usernameCopy != "Guest")
            {
                Acropolis landmark = new Acropolis();
                landmark.ShowDialog();
            }
            else
            {
                MessageBox.Show("Παρακαλώ κάντε εγγραφή για να δείτε το πλήρες περιεχόμενο της εφαρμογής.");
            }
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (StaticFieldsClass.usernameCopy != "Guest")
            {
                Museums landmark = new Museums();
                landmark.ShowDialog();
            }
            else
            {
                MessageBox.Show("Παρακαλώ κάντε εγγραφή για να δείτε το πλήρες περιεχόμενο της εφαρμογής.");
            }
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (StaticFieldsClass.usernameCopy != "Guest")
            {
                Buildings landmark = new Buildings();
                landmark.ShowDialog();
            }
            else
            {
                MessageBox.Show("Παρακαλώ κάντε εγγραφή για να δείτε το πλήρες περιεχόμενο της εφαρμογής.");
            }
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (StaticFieldsClass.usernameCopy != "Guest")
            {
                AcropolisMuseum landmark = new AcropolisMuseum();
                landmark.ShowDialog();
            }
            else
            {
                MessageBox.Show("Παρακαλώ κάντε εγγραφή για να δείτε το πλήρες περιεχόμενο της εφαρμογής.");
            }
            

        }

        public void ResumeSpeaker()
        {
            if (spee.State == SynthesizerState.Paused)
            {
                spee.Resume();
            }
        }

        public void PauseSpeaker()
        {
            if (spee.State == SynthesizerState.Speaking)
            {
                spee.Pause();
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            iconButton5.Enabled = true;
            iconButton6.Enabled = true;
            iconButton5.IconColor = Color.White;
            iconButton6.IconColor = Color.White;
            spee.Pause();
            spee = new SpeechSynthesizer();
            if (comboBox1.Text != "Διαλέξτε φωνή")
            {
                spee.SelectVoice(comboBox1.Text);
            }
            spee.SpeakAsync(label1.Text);
            spee.SpeakAsync(label2.Text);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            PauseSpeaker();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ResumeSpeaker();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            iconButton8.Enabled = true;
            iconButton9.Enabled = true;
            iconButton8.IconColor = Color.White;
            iconButton9.IconColor = Color.White;
            spee.Pause();
            spee = new SpeechSynthesizer();
            if (comboBox2.Text != "Διαλέξτε φωνή")
            {
                spee.SelectVoice(comboBox2.Text);
            }
            spee.SpeakAsync(label3.Text);
            spee.SpeakAsync(label4.Text);
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            PauseSpeaker();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ResumeSpeaker();
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            iconButton11.Enabled = true;
            iconButton12.Enabled = true;
            iconButton11.IconColor = Color.White;
            iconButton12.IconColor = Color.White;
            spee.Pause();
            spee = new SpeechSynthesizer();
            if (comboBox3.Text != "Διαλέξτε φωνή")
            {
                spee.SelectVoice(comboBox3.Text);
            }
            spee.SpeakAsync(label5.Text);
            spee.SpeakAsync(label6.Text);
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            PauseSpeaker();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            ResumeSpeaker();
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            iconButton14.Enabled = true;
            iconButton15.Enabled = true;
            iconButton14.IconColor = Color.White;
            iconButton15.IconColor = Color.White;
            spee.Pause();
            spee = new SpeechSynthesizer();
            if (comboBox4.Text != "Διαλέξτε φωνή")
            {
                spee.SelectVoice(comboBox4.Text);
            }
            spee.SpeakAsync(label7.Text);
            spee.SpeakAsync(label8.Text);
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            PauseSpeaker();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            ResumeSpeaker();
        }
    }
}
