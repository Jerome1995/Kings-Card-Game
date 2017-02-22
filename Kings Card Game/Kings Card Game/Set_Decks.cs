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
    public partial class Set_Decks : Form
    {
        public Set_Decks()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Set_Decks_Load(object sender, EventArgs e)
        {
            setDeckButton.Focus();
        }
    }
}
