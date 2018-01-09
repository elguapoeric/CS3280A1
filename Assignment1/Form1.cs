using System;
using System.Windows.Forms;

namespace Assignment1
{
    /// <summary>
    /// This class contains methods for the eventhandler to call after a button is pressed
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult MyResult; //Variable to store info for messagebox

            //getting whats in the text box and using meassage box with ok cancel buttons along with an error icon
            MyResult = MessageBox.Show("You typed: " + textBox1.Text, "This is a caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //updating label text with what the button the user chose in the messsage box.
            label5.Text = "What you selected in the message box: You clicked the " + MyResult.ToString() + " button";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;
            //geting whats in the text box and using message box with yes no cancel buttons along with an exclamation icon
            MyResult = MessageBox.Show("You typed: " + textBox2.Text, "This is a caption", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            //updating label text with what the button the user chose in the messsage box.
            label5.Text = "What you selected in the message box: You clicked the " + MyResult.ToString() + " button";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            //getting what in the text box and using message box with yes no buttons along with asterick icon
            MyResult = MessageBox.Show("You typed: " + textBox3.Text, "This is a caption", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            //updating label text with what the button the user chose in the messsage box.
            label5.Text = "What you selected in the message box: You clicked the " + MyResult.ToString() + " button";
        }

    }
}
