using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Crate full of Monsters example
// norrisa
// feb 2017

namespace StructFullOfMonsters
{
    // namespace for this project contains two items:
    // a struct which serves as the data structure for an indivdual monster,
    // and the display form.

    // explanation of monster statistics:
    // hp indicates hit points, at 0 hp a monster is defeated
    // an attack round involves the attacker adding attack stat to a d20 (1-20) roll
    // if this is greater than the defense stat, a hit is recorded and the defender
    // takes damage based on the attacker's damageDie stat (from 1 to max of damageDie)

    public struct MonsterData
    {
        public string name;
        public string description;
        public int hp;
        public int attack;
        public int defense;
        public int damageDie;

    }


    public partial class MonsterDisplayForm : Form
    {
        public MonsterDisplayForm()
        {
            InitializeComponent();
        }
    }
}
