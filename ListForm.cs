using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordlePermutations
{
    public partial class ListForm : Form
    {
        public ListForm(List<string> permutations)
        {
            InitializeComponent();
            permutations.Sort();
            lbPermutations.DataSource = permutations;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
