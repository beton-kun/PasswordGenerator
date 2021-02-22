using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                if (number.Text == "") throw new EmptyNumerFieldException();
                int num = Convert.ToInt32(number.Text);
                output.Text = "";
                for (int i = 0; i < 30; i++)
                {
                    output.Text += PasswordGenerator.Generate(num) + '\n';
                }
            }
            catch (EmptyNumerFieldException)
            {
                MessageBox.Show(
                   "Введите число символов в пароле",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, output.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            output.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
    }
    
}
