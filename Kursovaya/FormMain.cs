using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Kursovaya
{
    public partial class FormMain : Form
    {
        Database database = new Database("Data Source=dataBase.db;Version=3;");
        BinarySearch BS = new BinarySearch();
        public FormMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            DialogResult authDialogResult = new FormAuth().ShowDialog();

            if (authDialogResult == DialogResult.Cancel)
            {
                Close();
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Телефонный справочник", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение позволяет найти номер телефона интересующего абонента по его полному имени и фамилии.", "Возможности приложения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBoxName.Text = textBoxName.Text.Trim(); // убираем пробелы из начала и конца
            textBoxSurname.Text = textBoxSurname.Text.Trim();
            textBoxName.Text = textBoxName.Text.ToUpper(); // переводим имя в апперкейс, чтобы можно было писать имя в любом регистре
            textBoxSurname.Text = textBoxSurname.Text.ToUpper();
            string[] array = database.NametoArray();
            string keyword = textBoxSurname.Text + " " + textBoxName.Text;
            int index = BS.Find(array, keyword);
            if (index >= 0 && textBoxName.Text != "" && textBoxSurname.Text != "")
            {
                string number = database.ReturnNumber(index);
                MessageBox.Show($"Телефон пользователя {textBoxName.Text} {textBoxSurname.Text}:\n\t{number}", "Телефонный справочник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textBoxName.Text == "" && textBoxSurname.Text == "")
            {
                MessageBox.Show("Введите имя и фамилию", "Телефонный справочник", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Абонента {textBoxName.Text} {textBoxSurname.Text} нет в справочнике:(", "Телефонный справочник", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
