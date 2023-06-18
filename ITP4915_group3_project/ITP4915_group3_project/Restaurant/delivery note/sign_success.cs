using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.delivery_note
{
    public partial class sign_success : UserControl
    {
        public sign_success(Form panel)
        {
            InitializeComponent();
            panel.Controls.Add(this);
            this.BringToFront();

            Timer timer = new Timer();
            timer.Interval = 3000;

            // Handle the Tick event of the timer to close the form
            timer.Tick += (sender, args) =>
            {
                timer.Stop(); // stop the timer
                new search(search.panelContent1);
                panel.Close(); // close the form
            };

            // Start the timer
            timer.Start();
        }
    }
}
