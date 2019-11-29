namespace RockPaperScissor
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
            this.components = new System.ComponentModel.Container();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.playernamescore_textBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.playerscoreshow_textBox = new System.Windows.Forms.TextBox();
            this.computerscore_textBox = new System.Windows.Forms.TextBox();
            this.rock_button = new System.Windows.Forms.Button();
            this.scissors_button = new System.Windows.Forms.Button();
            this.paper_button = new System.Windows.Forms.Button();
            this.playername_textBox = new System.Windows.Forms.TextBox();
            this.player_pictureBox = new System.Windows.Forms.PictureBox();
            this.computer_pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputplayername_textBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.timerstart_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enablegridlines_checkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox2.Location = new System.Drawing.Point(451, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Computer";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox3.Location = new System.Drawing.Point(307, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 28);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "VS";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox4.Location = new System.Drawing.Point(745, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Score";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playernamescore_textBox
            // 
            this.playernamescore_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playernamescore_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playernamescore_textBox.ForeColor = System.Drawing.Color.Black;
            this.playernamescore_textBox.Location = new System.Drawing.Point(663, 403);
            this.playernamescore_textBox.Name = "playernamescore_textBox";
            this.playernamescore_textBox.Size = new System.Drawing.Size(77, 19);
            this.playernamescore_textBox.TabIndex = 8;
            this.playernamescore_textBox.Text = "Player:";
            this.playernamescore_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(779, 403);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 19);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Computer:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerscoreshow_textBox
            // 
            this.playerscoreshow_textBox.Location = new System.Drawing.Point(674, 428);
            this.playerscoreshow_textBox.Name = "playerscoreshow_textBox";
            this.playerscoreshow_textBox.Size = new System.Drawing.Size(56, 20);
            this.playerscoreshow_textBox.TabIndex = 10;
            // 
            // computerscore_textBox
            // 
            this.computerscore_textBox.Location = new System.Drawing.Point(789, 428);
            this.computerscore_textBox.Name = "computerscore_textBox";
            this.computerscore_textBox.Size = new System.Drawing.Size(65, 20);
            this.computerscore_textBox.TabIndex = 11;
            // 
            // rock_button
            // 
            this.rock_button.BackColor = System.Drawing.Color.OliveDrab;
            this.rock_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rock_button.ForeColor = System.Drawing.Color.Black;
            this.rock_button.Location = new System.Drawing.Point(178, 475);
            this.rock_button.Name = "rock_button";
            this.rock_button.Size = new System.Drawing.Size(101, 32);
            this.rock_button.TabIndex = 12;
            this.rock_button.Text = "Rock";
            this.rock_button.UseVisualStyleBackColor = false;
            this.rock_button.Click += new System.EventHandler(this.rock_button_Click);
            // 
            // scissors_button
            // 
            this.scissors_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.scissors_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissors_button.ForeColor = System.Drawing.Color.Black;
            this.scissors_button.Location = new System.Drawing.Point(406, 475);
            this.scissors_button.Name = "scissors_button";
            this.scissors_button.Size = new System.Drawing.Size(101, 32);
            this.scissors_button.TabIndex = 13;
            this.scissors_button.Text = "Scissors";
            this.scissors_button.UseVisualStyleBackColor = false;
            this.scissors_button.Click += new System.EventHandler(this.scissors_button_Click);
            // 
            // paper_button
            // 
            this.paper_button.BackColor = System.Drawing.Color.Blue;
            this.paper_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper_button.ForeColor = System.Drawing.Color.Black;
            this.paper_button.Location = new System.Drawing.Point(292, 475);
            this.paper_button.Name = "paper_button";
            this.paper_button.Size = new System.Drawing.Size(101, 32);
            this.paper_button.TabIndex = 14;
            this.paper_button.Text = "Paper";
            this.paper_button.UseVisualStyleBackColor = false;
            this.paper_button.Click += new System.EventHandler(this.paper_button_Click);
            // 
            // playername_textBox
            // 
            this.playername_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playername_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playername_textBox.ForeColor = System.Drawing.Color.Teal;
            this.playername_textBox.Location = new System.Drawing.Point(97, 85);
            this.playername_textBox.Name = "playername_textBox";
            this.playername_textBox.Size = new System.Drawing.Size(100, 22);
            this.playername_textBox.TabIndex = 16;
            this.playername_textBox.Text = "Player";
            this.playername_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_pictureBox
            // 
            this.player_pictureBox.ErrorImage = global::RockPaperScissor.Properties.Resources.qq;
            this.player_pictureBox.ImageLocation = "center";
            this.player_pictureBox.InitialImage = global::RockPaperScissor.Properties.Resources.qq;
            this.player_pictureBox.Location = new System.Drawing.Point(7, 119);
            this.player_pictureBox.Name = "player_pictureBox";
            this.player_pictureBox.Size = new System.Drawing.Size(300, 300);
            this.player_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player_pictureBox.TabIndex = 19;
            this.player_pictureBox.TabStop = false;
            // 
            // computer_pictureBox
            // 
            this.computer_pictureBox.ErrorImage = global::RockPaperScissor.Properties.Resources.qq;
            this.computer_pictureBox.ImageLocation = "center";
            this.computer_pictureBox.InitialImage = global::RockPaperScissor.Properties.Resources.qq;
            this.computer_pictureBox.Location = new System.Drawing.Point(348, 119);
            this.computer_pictureBox.Name = "computer_pictureBox";
            this.computer_pictureBox.Size = new System.Drawing.Size(300, 300);
            this.computer_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.computer_pictureBox.TabIndex = 20;
            this.computer_pictureBox.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(663, 119);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(319, 278);
            this.dataGridView.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Enter Your Name:";
            // 
            // inputplayername_textBox
            // 
            this.inputplayername_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputplayername_textBox.Location = new System.Drawing.Point(176, 39);
            this.inputplayername_textBox.Name = "inputplayername_textBox";
            this.inputplayername_textBox.Size = new System.Drawing.Size(143, 29);
            this.inputplayername_textBox.TabIndex = 23;
            this.inputplayername_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputpalyername_textBox_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(714, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 25;
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Chocolate;
            this.reset_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.Black;
            this.reset_button.Location = new System.Drawing.Point(730, 472);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(115, 32);
            this.reset_button.TabIndex = 27;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // timerstart_button
            // 
            this.timerstart_button.BackColor = System.Drawing.Color.Yellow;
            this.timerstart_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerstart_button.ForeColor = System.Drawing.Color.Black;
            this.timerstart_button.Location = new System.Drawing.Point(567, 32);
            this.timerstart_button.Name = "timerstart_button";
            this.timerstart_button.Size = new System.Drawing.Size(134, 32);
            this.timerstart_button.TabIndex = 28;
            this.timerstart_button.Text = "Start Timer";
            this.timerstart_button.UseVisualStyleBackColor = false;
            this.timerstart_button.Click += new System.EventHandler(this.timerstart_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Red;
            this.exit_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.Black;
            this.exit_button.Location = new System.Drawing.Point(867, 472);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(115, 32);
            this.exit_button.TabIndex = 29;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.DarkOrange;
            this.help_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_button.ForeColor = System.Drawing.Color.Black;
            this.help_button.Location = new System.Drawing.Point(867, 32);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(115, 32);
            this.help_button.TabIndex = 31;
            this.help_button.Text = "Help";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(733, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "seconds";
            // 
            // enablegridlines_checkBox
            // 
            this.enablegridlines_checkBox.AutoSize = true;
            this.enablegridlines_checkBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enablegridlines_checkBox.Location = new System.Drawing.Point(860, 89);
            this.enablegridlines_checkBox.Name = "enablegridlines_checkBox";
            this.enablegridlines_checkBox.Size = new System.Drawing.Size(122, 18);
            this.enablegridlines_checkBox.TabIndex = 33;
            this.enablegridlines_checkBox.Text = "Enable Gridlines";
            this.enablegridlines_checkBox.UseVisualStyleBackColor = true;
            this.enablegridlines_checkBox.CheckedChanged += new System.EventHandler(this.enablegridlines_checkBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Choose your option:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enablegridlines_checkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.timerstart_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputplayername_textBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.computer_pictureBox);
            this.Controls.Add(this.player_pictureBox);
            this.Controls.Add(this.playername_textBox);
            this.Controls.Add(this.paper_button);
            this.Controls.Add(this.scissors_button);
            this.Controls.Add(this.rock_button);
            this.Controls.Add(this.computerscore_textBox);
            this.Controls.Add(this.playerscoreshow_textBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.playernamescore_textBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox playernamescore_textBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox playerscoreshow_textBox;
        private System.Windows.Forms.TextBox computerscore_textBox;
        private System.Windows.Forms.Button rock_button;
        private System.Windows.Forms.Button scissors_button;
        private System.Windows.Forms.Button paper_button;
        private System.Windows.Forms.TextBox playername_textBox;
        private System.Windows.Forms.PictureBox player_pictureBox;
        private System.Windows.Forms.PictureBox computer_pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox inputplayername_textBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button timerstart_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox enablegridlines_checkBox;
        private System.Windows.Forms.Label label3;
    }
}

