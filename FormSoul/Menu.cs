using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSoul
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }
        private void child_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btn_Prac04_Click(object sender, EventArgs e)
        {
            Calculator child = new Calculator();
            child.Show();
            this.Hide();
            child.FormClosing += child_Closing;
        }

        private void btn_Test04_Click(object sender, EventArgs e)
        {
            CalculatorAdv child = new CalculatorAdv();
            child.Show();
            this.Hide();
            child.FormClosing += child_Closing;
        }

        private void btn_Prac05_Click(object sender, EventArgs e)
        {
            DateTimer child = new DateTimer();
            child.Show();
            this.Hide();
            child.FormClosing += child_Closing;
        }

        private void btn_Prac06_Click(object sender, EventArgs e)
        {
            MyArray child = new MyArray();
            child.Show();
            this.Hide();
            child.FormClosing += child_Closing;
        }

        private void btn_Prac07_Click(object sender, EventArgs e)
        {
            MyArrayAdv child = new MyArrayAdv();
            child.Show();
            this.Hide();
            child.FormClosing += child_Closing;
        }

        private void btn_Test05_Click(object sender, EventArgs e)
        {
            PracListbox child = new PracListbox();
            child.Show();
            this.Hide();
            child.FormClosing += child_Closing;
        }

        private void btn_Prac08_Click(object sender, EventArgs e)
        {
            PracListboxAdv child = new PracListboxAdv();
            child.Show();
            this.Hide();
            child.FormClosing += child_Closing;
        }

        private void btn_Prac09_Click(object sender, EventArgs e)
        {

        }
    }
}
