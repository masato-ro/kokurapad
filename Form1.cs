using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace tinynotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_area.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                text_area.Text = "";

                StreamReader sr = new StreamReader(dialog.FileName, Encoding.Default, true);

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    text_area.AppendText(line+Environment.NewLine);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Save file";
            savedialog.InitialDirectory = ".\\";
            savedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(savedialog.FileName, text_area.Text);
            }
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要儲存變更", "是否儲存", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Save file";
                savedialog.InitialDirectory = ".\\";
                savedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(savedialog.FileName, text_area.Text);
                }
                text_area.Text = "";
            }
            else
            {
                text_area.Text = "";
            }
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                text_area.Text = "";

                StreamReader sr = new StreamReader(dialog.FileName, Encoding.Default, true);

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    text_area.AppendText(line + Environment.NewLine);
                }
            }
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Save file";
            savedialog.InitialDirectory = ".\\";
            savedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(savedialog.FileName, text_area.Text);
            }
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("沒有說明","沒有說明",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KokuraPad\n版本 0.1\nPowered by Kokuraden.", "關於KokuraPad", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
