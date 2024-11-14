using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLGuga
{
    public partial class Form2 : Form
    {
        private int rarity, weaponType, company, ability;
        public Form2(int rarity, int weaponType, int company, int ability)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.rarity = rarity;
            this.weaponType = weaponType;
            this.company = company;
            this.ability = ability;


        }
    }
}
