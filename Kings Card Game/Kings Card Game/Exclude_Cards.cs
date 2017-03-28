using System;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    public partial class ExcludeCards : Form
    {
        public ExcludeCards()
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
