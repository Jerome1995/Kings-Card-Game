using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    public partial class Exclude_Cards : Form
    {
        public Exclude_Cards()
        {
            InitializeComponent();
        }

        private void Exclude_Cards_Load(object sender, EventArgs e)
        {
            excludeCardButton.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
