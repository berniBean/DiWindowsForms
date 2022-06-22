using Dependencias.Interfaces;
using System;
using System.Windows.Forms;

namespace DIForms
{
    public partial class Form1 : Form, IDateWriter
    {
        private IOutput _output;
        public Form1(IOutput output)
        {
            InitializeComponent();
        }

        public void WriteDate()
        {
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}
