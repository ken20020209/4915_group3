using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.request_order.process
{
    public partial class process_success_warehouse : Form
    {
        public process_success_warehouse()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 3000;

            // Handle the Tick event of the timer to close the form
            timer.Tick += (sender, args) =>
            {
                timer.Stop(); // stop the timer
                new check(check.panelContent);
                this.Close(); // close the form
            };

            // Start the timer
            timer.Start();
            



        }
    }
}
