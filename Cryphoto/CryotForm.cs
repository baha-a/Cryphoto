using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Cryphoto.Helper;
using System.Diagnostics;

namespace Cryphoto
{
    //////////////////////////////////////////
    ///   Created by Baha'a al-Sharif       //
    ///                                     //
    //////////////////////// 2014 ////////////
    //////////////////////////////////////////
    //
    //  add fast bitmap classes
    ///////////////////////// 2017 ////////////


    public partial class CryotForm : Form
    {

        #region Code For UserInterface

        public CryotForm()
        {
            InitializeComponent();
        }

        void buttonClicker(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "btnChangeCryption":
                    Height = !(grpBxEncrypt.Visible = !(grpBxDecrypt.Visible = !grpBxDecrypt.Visible)) ? 500 : 697;
                    btnChangeCryption.Text = btnChangeCryption.Text == "Decryption >>" ? "<< Encryption" : "Decryption >>";
                    break;
                case "btnEncrypt":
                    Trigger(encrypt);
                    break;
                case "btnDecrypt":
                    Trigger(decrypt);
                    break;
                case "btnSource":
                    Trigger(getSource);
                    break;
                case "btnHelp":
                    MessageBox.Show("Click On Any PictureBox To Load Image or to Save it");
                    break;
            }
        }
        void pictureBoxClicker(object sender, EventArgs e)
        {
            switch ((sender as PictureBox).Name)
            {
                case "pctrBxDecryptSource":
                    DecryptionFilPath = Dialogs(true, pctrBxDecryptSource);
                    break;
                case "pctrBxDecryptResult":
                    Dialogs(false, pctrBxDecryptResult);
                    break;
                case "pctrBxEncryptSource":
                    EncryptionFilPath = Dialogs(true, pctrBxEncryptSource);
                    break;
                case "pctrBxEncryptHiddn":
                    HiddenFilPath = Dialogs(true, pctrBxEncryptHiddn);
                    break;
                case "pctrBxEncryptResult":
                    Dialogs(false, pctrBxEncryptResult);

                    break;
            }
        }
        private void CryotForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lastThread != null && lastThread.IsAlive)
                lastThread.Abort();
        }


        Thread lastThread;
        void Trigger(ThreadStart t)
        {
            lastThread = new Thread(t) { IsBackground = true };
            lastThread.Start();
        }

        string
                DecryptionFilPath,
                EncryptionFilPath,
                HiddenFilPath;

        string Dialogs(bool isOpen, PictureBox p)
        {
            FileDialog op;
            if (isOpen)
                op = new OpenFileDialog();
            else
                op = new SaveFileDialog();
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif|All Files|*.*";

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (isOpen)
                        p.Image = new Bitmap(op.FileName);
                    else
                        p.Image.Save(op.FileName);

                    return op.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return "";
        }

        #endregion


        #region Code For Cyption

        void encrypt()
        {
            try
            {
                Stopwatch st = Stopwatch.StartNew();
                if (string.IsNullOrEmpty(EncryptionFilPath) || string.IsNullOrEmpty(HiddenFilPath))
                {
                    MessageBox.Show("Load Tow Images First !");
                    return;
                }

                btnChangeCryption.Enabled = grpBxEncrypt.Enabled = false;
                using (Bitmap bm1 = new Bitmap(EncryptionFilPath))
                {
                    int totl = bm1.Width * bm1.Height, percent = 0;

                    pctrBxEncryptResult.Image =
                    new Bitmap(HiddenFilPath).HideIn(bm1, () =>
                    {
                        if (percent++ % 5000 == 0)
                            Text = Math.Round((100.0 * percent / totl), 2) + " %";
                    }
                    );
                }

                btnChangeCryption.Enabled = grpBxEncrypt.Enabled = true;
                st.Stop();
                Text = "100.00 % - " + st.ElapsedMilliseconds + " ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void decrypt()
        {
                Stopwatch st = Stopwatch.StartNew();
            if (string.IsNullOrEmpty(DecryptionFilPath))
            {
                MessageBox.Show("Load Image First !");
                return;
            }
            btnChangeCryption.Enabled = grpBxDecrypt.Enabled = false;

            var bm = new Bitmap(DecryptionFilPath);
            int total = bm.Width * bm.Height, percent = 0;

            pctrBxDecryptResult.Image = bm.GetHidden(() =>
            {
                if (percent++ % 1000 == 0)
                    Text = Math.Round(percent * 100.0 / total, 2) + " %";
            });

            btnChangeCryption.Enabled = grpBxDecrypt.Enabled = true;
            st.Stop();
            Text = "100.00 % - " + st.ElapsedMilliseconds + " ms";
        }

        void getSource()
        {
                Stopwatch st = Stopwatch.StartNew();
            if (string.IsNullOrEmpty(DecryptionFilPath))
            {
                MessageBox.Show("Load Image First !");
                return;
            }

            btnChangeCryption.Enabled = grpBxDecrypt.Enabled = false;
            var bm = new Bitmap(DecryptionFilPath);
            int total = bm.Width * bm.Height, percent = 0;
            pctrBxDecryptResult.Image = bm.GetSource(() =>
            {
                if (percent++ % 1000 == 0)
                    Text = Math.Round(percent * 100.0 / total, 2) + " %";
            });
            
            btnChangeCryption.Enabled = grpBxDecrypt.Enabled = true;
            st.Stop();
            Text = "100.00 % - " + st.ElapsedMilliseconds + " ms";
        }

        #endregion

        private void pctrBxEncryptSource_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    BitmapExtenison.HowToCreateNewIBitmap = x => new FastBitmap(x);
                    break;
                case 1:
                    BitmapExtenison.HowToCreateNewIBitmap = x => new LockBitmap(x);
                    break;
                case 2:
                    BitmapExtenison.HowToCreateNewIBitmap = x => new DotNetBitmap(x);
                    break;
                default:break;
            }
        }

        private void pctrBxEncryptSource_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text, false) == true)
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void CryotForm_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
