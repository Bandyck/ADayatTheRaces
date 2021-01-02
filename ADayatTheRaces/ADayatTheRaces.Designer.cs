namespace ADayatTheRaces
{
    partial class Form1
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
            this.RaceTrack = new System.Windows.Forms.PictureBox();
            this.Greyhound0 = new System.Windows.Forms.PictureBox();
            this.Greyhound1 = new System.Windows.Forms.PictureBox();
            this.Greyhound2 = new System.Windows.Forms.PictureBox();
            this.Greyhound3 = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.RaceButton = new System.Windows.Forms.Button();
            this.TBGuy2 = new System.Windows.Forms.TextBox();
            this.TBGuy1 = new System.Windows.Forms.TextBox();
            this.TBGuy0 = new System.Windows.Forms.TextBox();
            this.BettingLabel = new System.Windows.Forms.Label();
            this.DogNUD = new System.Windows.Forms.NumericUpDown();
            this.BettorDogLabel = new System.Windows.Forms.Label();
            this.BettingNUD = new System.Windows.Forms.NumericUpDown();
            this.BettingButton = new System.Windows.Forms.Button();
            this.BettorLabel = new System.Windows.Forms.Label();
            this.RBGuy2 = new System.Windows.Forms.RadioButton();
            this.RBGuy1 = new System.Windows.Forms.RadioButton();
            this.RBGuy0 = new System.Windows.Forms.RadioButton();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound3)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceTrack
            // 
            this.RaceTrack.Image = global::ADayatTheRaces.Properties.Resources.racetrack;
            this.RaceTrack.Location = new System.Drawing.Point(12, 12);
            this.RaceTrack.Name = "RaceTrack";
            this.RaceTrack.Size = new System.Drawing.Size(601, 204);
            this.RaceTrack.TabIndex = 0;
            this.RaceTrack.TabStop = false;
            // 
            // Greyhound0
            // 
            this.Greyhound0.Image = global::ADayatTheRaces.Properties.Resources.dog;
            this.Greyhound0.Location = new System.Drawing.Point(27, 22);
            this.Greyhound0.Name = "Greyhound0";
            this.Greyhound0.Size = new System.Drawing.Size(76, 22);
            this.Greyhound0.TabIndex = 1;
            this.Greyhound0.TabStop = false;
            // 
            // Greyhound1
            // 
            this.Greyhound1.Image = global::ADayatTheRaces.Properties.Resources.dog;
            this.Greyhound1.Location = new System.Drawing.Point(27, 68);
            this.Greyhound1.Name = "Greyhound1";
            this.Greyhound1.Size = new System.Drawing.Size(76, 22);
            this.Greyhound1.TabIndex = 2;
            this.Greyhound1.TabStop = false;
            // 
            // Greyhound2
            // 
            this.Greyhound2.Image = global::ADayatTheRaces.Properties.Resources.dog;
            this.Greyhound2.Location = new System.Drawing.Point(27, 123);
            this.Greyhound2.Name = "Greyhound2";
            this.Greyhound2.Size = new System.Drawing.Size(76, 22);
            this.Greyhound2.TabIndex = 3;
            this.Greyhound2.TabStop = false;
            // 
            // Greyhound3
            // 
            this.Greyhound3.Image = global::ADayatTheRaces.Properties.Resources.dog;
            this.Greyhound3.Location = new System.Drawing.Point(27, 177);
            this.Greyhound3.Name = "Greyhound3";
            this.Greyhound3.Size = new System.Drawing.Size(76, 22);
            this.Greyhound3.TabIndex = 4;
            this.Greyhound3.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.RaceButton);
            this.groupBox.Controls.Add(this.TBGuy2);
            this.groupBox.Controls.Add(this.TBGuy1);
            this.groupBox.Controls.Add(this.TBGuy0);
            this.groupBox.Controls.Add(this.BettingLabel);
            this.groupBox.Controls.Add(this.DogNUD);
            this.groupBox.Controls.Add(this.BettorDogLabel);
            this.groupBox.Controls.Add(this.BettingNUD);
            this.groupBox.Controls.Add(this.BettingButton);
            this.groupBox.Controls.Add(this.BettorLabel);
            this.groupBox.Controls.Add(this.RBGuy2);
            this.groupBox.Controls.Add(this.RBGuy1);
            this.groupBox.Controls.Add(this.RBGuy0);
            this.groupBox.Controls.Add(this.MinimumBetLabel);
            this.groupBox.Location = new System.Drawing.Point(12, 226);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(601, 171);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Betting Parlor";
            // 
            // RaceButton
            // 
            this.RaceButton.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RaceButton.Location = new System.Drawing.Point(494, 131);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(101, 29);
            this.RaceButton.TabIndex = 13;
            this.RaceButton.Text = "Race!";
            this.RaceButton.UseVisualStyleBackColor = true;
            // 
            // TBGuy0
            // 
            this.TBGuy0.Location = new System.Drawing.Point(326, 49);
            this.TBGuy0.Name = "TBGuy0";
            this.TBGuy0.Size = new System.Drawing.Size(269, 21);
            this.TBGuy0.TabIndex = 10;
            this.TBGuy0.Text = "Joe\'s bet";
            // 
            // TBGuy1
            // 
            this.TBGuy1.Location = new System.Drawing.Point(326, 76);
            this.TBGuy1.Name = "TBGuy1";
            this.TBGuy1.Size = new System.Drawing.Size(269, 21);
            this.TBGuy1.TabIndex = 11;
            this.TBGuy1.Text = "Bob\'s bet";
            // 
            // TBGuy2
            // 
            this.TBGuy2.Location = new System.Drawing.Point(326, 103);
            this.TBGuy2.Name = "TBGuy2";
            this.TBGuy2.Size = new System.Drawing.Size(269, 21);
            this.TBGuy2.TabIndex = 12;
            this.TBGuy2.Text = "Al\'s bet";
            // 
            // BettingLabel
            // 
            this.BettingLabel.AutoSize = true;
            this.BettingLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BettingLabel.Location = new System.Drawing.Point(323, 21);
            this.BettingLabel.Name = "BettingLabel";
            this.BettingLabel.Size = new System.Drawing.Size(41, 15);
            this.BettingLabel.TabIndex = 9;
            this.BettingLabel.Text = "Bets";
            // 
            // DogNUD
            // 
            this.DogNUD.Location = new System.Drawing.Point(326, 137);
            this.DogNUD.Name = "DogNUD";
            this.DogNUD.Size = new System.Drawing.Size(60, 21);
            this.DogNUD.TabIndex = 8;
            this.DogNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BettorDogLabel
            // 
            this.BettorDogLabel.AutoSize = true;
            this.BettorDogLabel.Location = new System.Drawing.Point(186, 142);
            this.BettorDogLabel.Name = "BettorDogLabel";
            this.BettorDogLabel.Size = new System.Drawing.Size(129, 12);
            this.BettorDogLabel.TabIndex = 7;
            this.BettorDogLabel.Text = "bucks on dog number";
            // 
            // BettingNUD
            // 
            this.BettingNUD.Location = new System.Drawing.Point(120, 137);
            this.BettingNUD.Name = "BettingNUD";
            this.BettingNUD.Size = new System.Drawing.Size(60, 21);
            this.BettingNUD.TabIndex = 6;
            this.BettingNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BettingButton
            // 
            this.BettingButton.Location = new System.Drawing.Point(39, 137);
            this.BettingButton.Name = "BettingButton";
            this.BettingButton.Size = new System.Drawing.Size(75, 23);
            this.BettingButton.TabIndex = 5;
            this.BettingButton.Text = "Bets";
            this.BettingButton.UseVisualStyleBackColor = true;
            // 
            // BettorLabel
            // 
            this.BettorLabel.AutoSize = true;
            this.BettorLabel.Location = new System.Drawing.Point(8, 142);
            this.BettorLabel.Name = "BettorLabel";
            this.BettorLabel.Size = new System.Drawing.Size(25, 12);
            this.BettorLabel.TabIndex = 4;
            this.BettorLabel.Text = "Joe";
            // 
            // RBGuy0
            // 
            this.RBGuy0.AutoSize = true;
            this.RBGuy0.Location = new System.Drawing.Point(9, 50);
            this.RBGuy0.Name = "RBGuy0";
            this.RBGuy0.Size = new System.Drawing.Size(43, 16);
            this.RBGuy0.TabIndex = 1;
            this.RBGuy0.TabStop = true;
            this.RBGuy0.Text = "Joe";
            this.RBGuy0.UseVisualStyleBackColor = true;
            this.RBGuy0.CheckedChanged += new System.EventHandler(this.RBGuy0_CheckedChanged);
            // 
            // RBGuy1
            // 
            this.RBGuy1.AutoSize = true;
            this.RBGuy1.Location = new System.Drawing.Point(9, 77);
            this.RBGuy1.Name = "RBGuy1";
            this.RBGuy1.Size = new System.Drawing.Size(45, 16);
            this.RBGuy1.TabIndex = 2;
            this.RBGuy1.TabStop = true;
            this.RBGuy1.Text = "Bob";
            this.RBGuy1.UseVisualStyleBackColor = true;
            this.RBGuy1.CheckedChanged += new System.EventHandler(this.RBGuy1_CheckedChanged);
            // 
            // RBGuy2
            // 
            this.RBGuy2.AutoSize = true;
            this.RBGuy2.Location = new System.Drawing.Point(9, 104);
            this.RBGuy2.Name = "RBGuy2";
            this.RBGuy2.Size = new System.Drawing.Size(34, 16);
            this.RBGuy2.TabIndex = 3;
            this.RBGuy2.TabStop = true;
            this.RBGuy2.Text = "Al";
            this.RBGuy2.UseVisualStyleBackColor = true;
            this.RBGuy2.CheckedChanged += new System.EventHandler(this.RBGuy2_CheckedChanged);
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinimumBetLabel.Location = new System.Drawing.Point(7, 21);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(99, 15);
            this.MinimumBetLabel.TabIndex = 0;
            this.MinimumBetLabel.Text = "Minimum bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 409);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.Greyhound3);
            this.Controls.Add(this.Greyhound2);
            this.Controls.Add(this.Greyhound1);
            this.Controls.Add(this.Greyhound0);
            this.Controls.Add(this.RaceTrack);
            this.Name = "Form1";
            this.Text = "A Day at The Races";
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound3)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RaceTrack;
        private System.Windows.Forms.PictureBox Greyhound0;
        private System.Windows.Forms.PictureBox Greyhound1;
        private System.Windows.Forms.PictureBox Greyhound2;
        private System.Windows.Forms.PictureBox Greyhound3;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label BettorLabel;
        private System.Windows.Forms.RadioButton RBGuy2;
        private System.Windows.Forms.RadioButton RBGuy1;
        private System.Windows.Forms.RadioButton RBGuy0;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.TextBox TBGuy2;
        private System.Windows.Forms.TextBox TBGuy1;
        private System.Windows.Forms.TextBox TBGuy0;
        private System.Windows.Forms.Label BettingLabel;
        private System.Windows.Forms.NumericUpDown DogNUD;
        private System.Windows.Forms.Label BettorDogLabel;
        private System.Windows.Forms.NumericUpDown BettingNUD;
        private System.Windows.Forms.Button BettingButton;
    }
}

