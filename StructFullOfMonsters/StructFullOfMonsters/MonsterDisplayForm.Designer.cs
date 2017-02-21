namespace StructFullOfMonsters
{
    partial class MonsterDisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.groupBoxStatDisplay = new System.Windows.Forms.GroupBox();
            this.buttonPrevRecord = new System.Windows.Forms.Button();
            this.buttonNextRecord = new System.Windows.Forms.Button();
            this.buttonLoadRecords = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelAtk = new System.Windows.Forms.Label();
            this.labelDef = new System.Windows.Forms.Label();
            this.labelDmg = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.textHP = new System.Windows.Forms.TextBox();
            this.textAtk = new System.Windows.Forms.TextBox();
            this.textDef = new System.Windows.Forms.TextBox();
            this.textDmg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSelect.SuspendLayout();
            this.groupBoxStatDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.label1);
            this.groupBoxSelect.Controls.Add(this.buttonLoadRecords);
            this.groupBoxSelect.Controls.Add(this.buttonNextRecord);
            this.groupBoxSelect.Controls.Add(this.buttonPrevRecord);
            this.groupBoxSelect.Location = new System.Drawing.Point(33, 26);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(200, 351);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Choose A Monster";
            // 
            // groupBoxStatDisplay
            // 
            this.groupBoxStatDisplay.Controls.Add(this.textDmg);
            this.groupBoxStatDisplay.Controls.Add(this.textDef);
            this.groupBoxStatDisplay.Controls.Add(this.textAtk);
            this.groupBoxStatDisplay.Controls.Add(this.textHP);
            this.groupBoxStatDisplay.Controls.Add(this.textDesc);
            this.groupBoxStatDisplay.Controls.Add(this.textName);
            this.groupBoxStatDisplay.Controls.Add(this.labelDmg);
            this.groupBoxStatDisplay.Controls.Add(this.labelDef);
            this.groupBoxStatDisplay.Controls.Add(this.labelAtk);
            this.groupBoxStatDisplay.Controls.Add(this.labelHP);
            this.groupBoxStatDisplay.Controls.Add(this.labelDesc);
            this.groupBoxStatDisplay.Controls.Add(this.labelName);
            this.groupBoxStatDisplay.Location = new System.Drawing.Point(325, 26);
            this.groupBoxStatDisplay.Name = "groupBoxStatDisplay";
            this.groupBoxStatDisplay.Size = new System.Drawing.Size(304, 351);
            this.groupBoxStatDisplay.TabIndex = 1;
            this.groupBoxStatDisplay.TabStop = false;
            this.groupBoxStatDisplay.Text = "Monster Statistics";
            // 
            // buttonPrevRecord
            // 
            this.buttonPrevRecord.Location = new System.Drawing.Point(16, 34);
            this.buttonPrevRecord.Name = "buttonPrevRecord";
            this.buttonPrevRecord.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevRecord.TabIndex = 0;
            this.buttonPrevRecord.Text = "Previous";
            this.buttonPrevRecord.UseVisualStyleBackColor = true;
            // 
            // buttonNextRecord
            // 
            this.buttonNextRecord.Location = new System.Drawing.Point(107, 34);
            this.buttonNextRecord.Name = "buttonNextRecord";
            this.buttonNextRecord.Size = new System.Drawing.Size(75, 23);
            this.buttonNextRecord.TabIndex = 1;
            this.buttonNextRecord.Text = "Next";
            this.buttonNextRecord.UseVisualStyleBackColor = true;
            // 
            // buttonLoadRecords
            // 
            this.buttonLoadRecords.Location = new System.Drawing.Point(16, 113);
            this.buttonLoadRecords.Name = "buttonLoadRecords";
            this.buttonLoadRecords.Size = new System.Drawing.Size(166, 23);
            this.buttonLoadRecords.TabIndex = 2;
            this.buttonLoadRecords.Text = "Load from File";
            this.buttonLoadRecords.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(25, 92);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(63, 13);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Description:";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(25, 160);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(25, 13);
            this.labelHP.TabIndex = 2;
            this.labelHP.Text = "HP:";
            // 
            // labelAtk
            // 
            this.labelAtk.AutoSize = true;
            this.labelAtk.Location = new System.Drawing.Point(25, 198);
            this.labelAtk.Name = "labelAtk";
            this.labelAtk.Size = new System.Drawing.Size(41, 13);
            this.labelAtk.TabIndex = 3;
            this.labelAtk.Text = "Attack:";
            // 
            // labelDef
            // 
            this.labelDef.AutoSize = true;
            this.labelDef.Location = new System.Drawing.Point(25, 230);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(50, 13);
            this.labelDef.TabIndex = 4;
            this.labelDef.Text = "Defense:";
            // 
            // labelDmg
            // 
            this.labelDmg.AutoSize = true;
            this.labelDmg.Location = new System.Drawing.Point(28, 266);
            this.labelDmg.Name = "labelDmg";
            this.labelDmg.Size = new System.Drawing.Size(50, 13);
            this.labelDmg.TabIndex = 5;
            this.labelDmg.Text = "Damage:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(125, 36);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(146, 20);
            this.textName.TabIndex = 6;
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(125, 84);
            this.textDesc.Multiline = true;
            this.textDesc.Name = "textDesc";
            this.textDesc.ReadOnly = true;
            this.textDesc.Size = new System.Drawing.Size(146, 52);
            this.textDesc.TabIndex = 7;
            // 
            // textHP
            // 
            this.textHP.Location = new System.Drawing.Point(125, 160);
            this.textHP.Name = "textHP";
            this.textHP.ReadOnly = true;
            this.textHP.Size = new System.Drawing.Size(100, 20);
            this.textHP.TabIndex = 8;
            // 
            // textAtk
            // 
            this.textAtk.Location = new System.Drawing.Point(125, 198);
            this.textAtk.Name = "textAtk";
            this.textAtk.ReadOnly = true;
            this.textAtk.Size = new System.Drawing.Size(100, 20);
            this.textAtk.TabIndex = 9;
            // 
            // textDef
            // 
            this.textDef.Location = new System.Drawing.Point(125, 230);
            this.textDef.Name = "textDef";
            this.textDef.Size = new System.Drawing.Size(100, 20);
            this.textDef.TabIndex = 10;
            // 
            // textDmg
            // 
            this.textDmg.Location = new System.Drawing.Point(125, 266);
            this.textDmg.Name = "textDmg";
            this.textDmg.Size = new System.Drawing.Size(100, 20);
            this.textDmg.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistics Explained:\r\n\r\nAttacker rolls 1-20 + Attack\r\n\r\nIf > defender\'s Defense," +
    " hit!\r\nIf hit, damage roll from 1 - Damage\r\nis subtracted from defender\'s HP\r\n";
            // 
            // MonsterDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 416);
            this.Controls.Add(this.groupBoxStatDisplay);
            this.Controls.Add(this.groupBoxSelect);
            this.Name = "MonsterDisplayForm";
            this.Text = "Crate Full of Monsters";
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.groupBoxStatDisplay.ResumeLayout(false);
            this.groupBoxStatDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.Button buttonLoadRecords;
        private System.Windows.Forms.Button buttonNextRecord;
        private System.Windows.Forms.Button buttonPrevRecord;
        private System.Windows.Forms.GroupBox groupBoxStatDisplay;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDef;
        private System.Windows.Forms.Label labelAtk;
        private System.Windows.Forms.TextBox textDmg;
        private System.Windows.Forms.TextBox textDef;
        private System.Windows.Forms.TextBox textAtk;
        private System.Windows.Forms.TextBox textHP;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelDmg;
        private System.Windows.Forms.Label label1;
    }
}

