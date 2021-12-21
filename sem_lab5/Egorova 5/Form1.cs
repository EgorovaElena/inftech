using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egorova_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priceText.Text = "Цена: ";
            amount_Lists_text.Text = "Количество листов: ";
            lists_size_text.Text = "Размер листов: ";
            isPresent_text.Text = "Подарочный: ";
            Globals.Notebook_For_Drawing = new Notebook_for_drawing(Int32.Parse(PriceRichTextBox.Text),
                IsPresentCheckBox.Checked,
                Int32.Parse(amount_lists_text_box.Text), SizeRichTextBox.Text);
            Notebook_for_drawing notebook = Globals.Notebook_For_Drawing;
            notebook.paper_colored = painted_checker.Checked;

            priceText.Text += notebook.get_price();
            amount_Lists_text.Text += notebook.get_amount_of_sheets();
            lists_size_text.Text += notebook.get_size_of_sheets();
            isPresent_text.Checked = notebook.get_isPresent();
            checkBox1.Checked = notebook.paper_colored;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.Notebook_For_Drawing.paper_colored = true;
            checkBox1.Checked = Globals.Notebook_For_Drawing.paper_colored;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Globals.Notebook_For_Drawing.paper_colored = false;
            checkBox1.Checked = Globals.Notebook_For_Drawing.paper_colored;
        }
    }
}
