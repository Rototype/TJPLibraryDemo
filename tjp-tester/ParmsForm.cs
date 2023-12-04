using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tjp_tester
{
    public partial class ParmsForm : Form
    {
        public uint Par_BitmapID;
        public uint Par_FieldID;
        public uint Par_Zoom;
        public UInt16 Par_DocType;
        public string Par_field;

        public uint Par_QRVersion;
        public uint Par_QRCorrection;

        public ParmsForm( int n)
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            switch (n)
            {
                case 1:
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    textBox1.Enabled = false;
                    break;
                case 2:
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    textBox1.Enabled = true;
                    break;
                case 3:
                    numericUpDown1.Enabled = false;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = false;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    textBox1.Enabled = true;
                    break;
                case 4:
                    numericUpDown1.Enabled = false;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = false;
                    textBox1.Enabled = false;
                    break;
                case 5:
                    numericUpDown1.Enabled = false;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = true;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = true;
                    textBox1.Enabled = false;
                    break;
                case 6:
                    numericUpDown1.Enabled = false;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = true;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = true;
                    textBox1.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Par_BitmapID = (uint)numericUpDown1.Value;
            Par_FieldID = (uint)numericUpDown3.Value;
            Par_Zoom = (uint)numericUpDown2.Value;
            Par_DocType = (UInt16)comboBox1.Text[0];
            Par_field = textBox1.Text;

            Par_QRVersion = (uint)numericUpDown4.Value; ;
            Par_QRCorrection = UInt32.Parse(comboBox2.Text[0].ToString());

        }
    }
}
