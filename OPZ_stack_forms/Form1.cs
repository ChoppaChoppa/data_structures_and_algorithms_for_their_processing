using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPZ_stack_forms
{
    public partial class FormMora : Form
    {
        string inputText;
        string _outOpz;
        string _outAns;

        private OPZ opz;

        public FormMora()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            opz = new OPZ();

            outOpz.Text = "";
            OutAns.Text = "";

            inputText = Input.Text;

            _outOpz = opz.CreateOPZ(inputText);//переводим пример в опз
            _outAns = opz.CalculationOPZ();//получаем отв через опз

            outOpz.Text = _outOpz;
            OutAns.Text = _outAns;
        }
    }
}
