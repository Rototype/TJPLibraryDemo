using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace tjp_tester
{
    public partial class Form1 : Form
    {
        byte QRVersion;

        ParmsForm LoadInitBitmapForm = new ParmsForm(1);
        ParmsForm LoadDocumentBarcodeForm = new ParmsForm(2);
        ParmsForm LoadDocumentFieldForm = new ParmsForm(3);
        ParmsForm EndDocumentForm = new ParmsForm(4);
        ParmsForm SetBarCodeForm = new ParmsForm(5);
        ParmsForm SetBarBuildBookForm = new ParmsForm(6);

        public Form1()
        {
            InitializeComponent();
            SetBarcode(TjpNative.QRecLevel.QR_ECLEVEL_L, 2);

            toolStripComboBox1.SelectedIndex = 0;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "output.txt";
            sfd.Filter = "Text file|*.txt|All Files|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
                System.IO.File.WriteAllText(sfd.FileName, richTextBox1.Text);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CBD2000 helper library tester", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }


        private void startInitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TjpNative.StartInit();
            richTextBox1.Clear();
        }

        private void startDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TjpNative.StartDocument();
            richTextBox1.Clear();

        }


        private void loadInitBitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadInitBitmapForm.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.FileName = "*.bmp";
                ofd.Filter = "Bitmap Image|*.bmp|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                    TjpErrors.Show(TjpNative.LoadInitBitmap(ofd.FileName, LoadInitBitmapForm.Par_BitmapID));
            }
        }

        private void getInitStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.FileName = "*.rbd";
                ofd.Filter = "Booklet Definitions|*.rbd|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    const int size = 16 * 1024;
                    byte[] room = new byte[size];
                    TjpErrors.Show(TjpNative.EndInit(ofd.FileName, room, size));

                    richTextBox1.Text = Encoding.ASCII.GetString(room, 0, room.TakeWhile(l => l != '\0').Count()); 
                }
        }


        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.FileName = "*.rbd";
                ofd.Filter = "Booklet Definitions|*.rbd|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    uint w10 = 0;
                    uint h10 = 0;
                    if ( TjpNative.GetDimensions( ofd.FileName, ref w10, ref h10) != 0) {
                        System.Windows.Forms.MessageBox.Show(
                            "Cannot open file",
                            "Error",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error
                        );
                    } else {
                        string str;
                        float w = w10 / 10.0F;
                        float h = h10 / 10.0F;
                        str = "Width is " + w.ToString() + " mm\n";
                        str += "Height is " + h.ToString() + " mm";
                        System.Windows.Forms.MessageBox.Show(
                            str,
                            "GetDimensions",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Information
                        );
                    }

                }

        }

        private void setbarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SetBarCodeForm.ShowDialog() == DialogResult.OK)
                TjpErrors.Show(
                    SetBarcode(
                        (TjpNative.QRecLevel)SetBarCodeForm.Par_QRCorrection, 
                        (byte)SetBarCodeForm.Par_QRVersion
                    )
                );
        }


        private int SetBarcode( TjpNative.QRecLevel rl, byte Version) {
            byte[] Setting = new byte[4];
            Setting[0] = (byte)TjpNative.Encoder.QR;
            Setting[1] = (byte)rl;
            Setting[2] = QRVersion = Version;
            Setting[3] = (byte)TjpNative.QRencodeMode.QR_MODE_8;

            toolStripStatusLabel1.Text = rl.ToString();
            toolStripStatusLabel2.Text = "QR Version:" + Version.ToString(); 
            return TjpNative.SetBarcode(Setting);
        }

        private void loadDocumentBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadDocumentBarcodeForm.ShowDialog() == DialogResult.OK)
            {
                TjpErrors.Show(
                    TjpNative.LoadDocumentBarcode(
                        LoadDocumentBarcodeForm.Par_field,
                        LoadDocumentBarcodeForm.Par_BitmapID,
                        LoadDocumentBarcodeForm.Par_Zoom
                    )
                );
            }
        }

        private void loadDocumentFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadDocumentFieldForm.ShowDialog() == DialogResult.OK)
            {
                TjpErrors.Show(
                    TjpNative.LoadDocumentField(
                        LoadDocumentFieldForm.Par_field, 
                        LoadDocumentFieldForm.Par_FieldID
                    )
                );
            }
        }

        private void getDocumentStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EndDocumentForm.ShowDialog() == DialogResult.OK)
            {
                const int size = 16 * 1024;
                byte[] room = new byte[size];
                TjpErrors.Show(
                    TjpNative.EndDocument(
                        EndDocumentForm.Par_DocType, room, size
                    )
                );
                richTextBox1.Text = Encoding.ASCII.GetString(room, 0, room.TakeWhile(l => l != '\0').Count());
            }
        }

        private void makeBookletFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] size = new int[] { 0, 21, 25, 29, 33, 37, 41, 45, 49};    // QR size Vs. version

            int zoom = toolStripComboBox1.SelectedIndex;

            if (zoom < 1) 
                zoom = 150 / size[QRVersion];
            if (zoom > 5)
                zoom = 5;



            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "*.csv";
            ofd.Filter = "Unicode CSV|*.csv|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    CbdFac cbd = new CbdFac();
                    string[] csv = File.ReadAllLines(ofd.FileName);
                    foreach (string sheetcmd in cbd.GetCommand(csv, (uint)zoom))
                        sb.Append(sheetcmd);
                    richTextBox1.Text = sb.ToString();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Cannot open file",
                        "Error",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error
                    );

                }

            }

        }
    }
}
