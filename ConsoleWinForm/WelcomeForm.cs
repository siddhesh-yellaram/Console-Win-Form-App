using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleWinForm
{
    class WelcomeForm: Form
    {
        public WelcomeForm()
        {
            this.ClientSize = new Size(559, 338);
            this.Text = "Siddhesh";
            Button myBtn = new Button();
            myBtn.Location = new Point(80, 80);
            myBtn.Text = "Red";
            myBtn.AutoSize = true;
            myBtn.Click += (sender, e) => { BackColor = System.Drawing.Color.Red;  };

            Button myBtn1 = new Button();
            myBtn1.Location = new Point(180, 80);
            myBtn1.Text = "Blue";
            myBtn1.AutoSize = true;
            myBtn1.Click += (sender, e) => { BackColor = System.Drawing.Color.Blue; };

            this.Controls.Add(myBtn);
            this.Controls.Add(myBtn1);
        }
    }
}
