using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateControls_Click(object sender, EventArgs e)
        {
            int numberOfControls = int.Parse(txtNumberOfControls.Text);

            // Let's create a loop to create the correct number of buttons
            if (CmboxControlTybe.Text == "Button")
            {


                for (int i = 0; i < numberOfControls; i++)
                {
                    // Let's write code to create a single button dynamically
                    Button newButton = new Button();
                    newButton.Name = "DButton" + (i + 1);
                    newButton.Text = "DButton" + (i + 1);
                    newButton.Size = new Size(120, 40);
                    newButton.Location = new Point(0, (i * 50));

                    pnlDynamicControls.Controls.Add(newButton);
                }
            }
            if (CmboxControlTybe.Text == "TextBox")
            {
                for (int i = 0; i < numberOfControls; i++)
            {
                // Let's write code to create a single button dynamically
                TextBox newTextBox = new TextBox();
                newTextBox.Name = "DTextBox" + (i + 1);
                newTextBox.Text = "DTextBox" + (i + 1);
                newTextBox.Size = new Size(120, 40);
                newTextBox.Location = new Point(150, (i * 50));

                pnlDynamicControls.Controls.Add(newTextBox);
            }
            }
            if (CmboxControlTybe.Text == "Label")
            {
                for (int i = 0; i < numberOfControls; i++)
                {
                    // Let's write code to create a single button dynamically
                    Label newLabel = new Label();
                    newLabel.Name = "DLabel" + (i + 1);
                    newLabel.Text = "DLabel" + (i + 1);
                    newLabel.Size = new Size(120, 40);
                    newLabel.Location = new Point(300, (i * 50));

                    pnlDynamicControls.Controls.Add(newLabel);
                }
            }



        }

        private void pnlDynamicControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
