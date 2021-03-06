
namespace Game_form
{
    partial class GameForm
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_playagain = new System.Windows.Forms.Button();
            this.btn_shootaway = new System.Windows.Forms.Button();
            this.btn_headshot = new System.Windows.Forms.Button();
            this.image_showbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_showbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_load.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_load.Location = new System.Drawing.Point(33, 102);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(237, 60);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_spin.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_spin.Location = new System.Drawing.Point(34, 192);
            this.btn_spin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(236, 57);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "SPIN";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_exit.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(939, 254);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(248, 111);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "EXIT THE GAME";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_playagain
            // 
            this.btn_playagain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_playagain.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playagain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_playagain.Location = new System.Drawing.Point(939, 115);
            this.btn_playagain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_playagain.Name = "btn_playagain";
            this.btn_playagain.Size = new System.Drawing.Size(235, 102);
            this.btn_playagain.TabIndex = 3;
            this.btn_playagain.Text = "PLAY AGAIN";
            this.btn_playagain.UseVisualStyleBackColor = false;
            this.btn_playagain.Click += new System.EventHandler(this.btn_playagain_Click);
            // 
            // btn_shootaway
            // 
            this.btn_shootaway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_shootaway.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shootaway.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_shootaway.Location = new System.Drawing.Point(21, 374);
            this.btn_shootaway.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_shootaway.Name = "btn_shootaway";
            this.btn_shootaway.Size = new System.Drawing.Size(249, 57);
            this.btn_shootaway.TabIndex = 4;
            this.btn_shootaway.Text = "SHOOT AWAY";
            this.btn_shootaway.UseVisualStyleBackColor = false;
            this.btn_shootaway.Click += new System.EventHandler(this.btn_shootaway_Click);
            // 
            // btn_headshot
            // 
            this.btn_headshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_headshot.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_headshot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_headshot.Location = new System.Drawing.Point(34, 282);
            this.btn_headshot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_headshot.Name = "btn_headshot";
            this.btn_headshot.Size = new System.Drawing.Size(236, 57);
            this.btn_headshot.TabIndex = 5;
            this.btn_headshot.Text = "HEADSHOT";
            this.btn_headshot.UseVisualStyleBackColor = false;
            this.btn_headshot.Click += new System.EventHandler(this.btn_headshot_Click);
            // 
            // image_showbox
            // 
            this.image_showbox.Location = new System.Drawing.Point(300, 77);
            this.image_showbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.image_showbox.Name = "image_showbox";
            this.image_showbox.Size = new System.Drawing.Size(590, 438);
            this.image_showbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_showbox.TabIndex = 6;
            this.image_showbox.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.image_showbox);
            this.Controls.Add(this.btn_headshot);
            this.Controls.Add(this.btn_shootaway);
            this.Controls.Add(this.btn_playagain);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameForm";
            this.Text = "GAME";
            ((System.ComponentModel.ISupportInitialize)(this.image_showbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_playagain;
        private System.Windows.Forms.Button btn_shootaway;
        private System.Windows.Forms.Button btn_headshot;
        private System.Windows.Forms.PictureBox image_showbox;
    }
}

