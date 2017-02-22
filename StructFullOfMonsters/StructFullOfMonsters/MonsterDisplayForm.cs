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
        private MonsterData[] monsters;

        public MonsterDisplayForm()
        {
            InitializeComponent();
        }

        private void buttonLoadStaticData_Click(object sender, EventArgs e)
        {
            initDefaultData();
            MessageBox.Show("Default data loaded");

        }

        private void buttonLoadRecords_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently unimplemented.\nUsing default values.");
            initDefaultData();
        }

        private void initDefaultData()
        {
            // helper method
            // for test purposes, create some monsters and init the array 'monsters'
            monsters = new MonsterData[3];

            // we'll create three MonsterData and add each to the array
            MonsterData cia;
            cia.name = "CIA";
            cia.description = "Dr. Pavel, I'm CIA";
            cia.hp = 10;
            cia.attack = 3;    // added to a d20 roll
            cia.defense = 10;  // default defense value
            cia.damageDie = 6; // 1-6 damage

            MonsterData bane;
            bane.name = "Bane";
            bane.description = "A big guy (for you)";
            bane.hp = 20;
            bane.attack = 5;
            bane.defense = 15;
            bane.damageDie = 8;

            MonsterData pavel;
            pavel.name = "Dr. Pavel";
            pavel.description = "Nothing, I told them nothing";
            pavel.hp = 5;
            pavel.attack = 0;
            pavel.defense = 10;
            pavel.damageDie = 4;

            monsters[0] = cia;
            monsters[1] = bane;
            monsters[2] = pavel;
        }
    }
}
