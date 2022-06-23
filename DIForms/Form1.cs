using Dependencias.Interfaces;
using System;
using System.Windows.Forms;

namespace DIForms
{
    public partial class Form1 : Form
    {
        
        public Form1(IUser user, IDateWriter dateToday, IOutput output)
        {
            InitializeComponent();
            MessageBox.Show(user.Login());
            MessageBox.Show(dateToday.WriteDate()); 

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
