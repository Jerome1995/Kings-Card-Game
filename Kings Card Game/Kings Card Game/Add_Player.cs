using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Kings_Card_Game
{
    public partial class Add_Player : Form
    {
        public Add_Player()
        {
            InitializeComponent();
        }

        private void Add_Player_Load(object sender, EventArgs e)
        {
            addPlayerButton.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
