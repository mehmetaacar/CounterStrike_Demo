
namespace CounterStrike_Demo
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
            this.btnFire = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnHone = new System.Windows.Forms.Button();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.progressBarAmmo = new System.Windows.Forms.ProgressBar();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.pictureTank = new System.Windows.Forms.PictureBox();
            this.pictureHandGrenade = new System.Windows.Forms.PictureBox();
            this.pictureAWM = new System.Windows.Forms.PictureBox();
            this.pictureM60 = new System.Windows.Forms.PictureBox();
            this.pictureM4Silenced = new System.Windows.Forms.PictureBox();
            this.pictureAk47 = new System.Windows.Forms.PictureBox();
            this.pictureShotgun = new System.Windows.Forms.PictureBox();
            this.pictureDeagle = new System.Windows.Forms.PictureBox();
            this.pictureGlock = new System.Windows.Forms.PictureBox();
            this.pictureAxe = new System.Windows.Forms.PictureBox();
            this.pictureKarambit = new System.Windows.Forms.PictureBox();
            this.lblKilledEnemy = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nasılOynanırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasılOynanırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHandGrenade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAWM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureM60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureM4Silenced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAk47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShotgun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeagle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKarambit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFire.Location = new System.Drawing.Point(28, 396);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(126, 45);
            this.btnFire.TabIndex = 5;
            this.btnFire.Text = "Ateş Et";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReload.Location = new System.Drawing.Point(28, 443);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(126, 45);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Mermi Değiştir";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZoomIn.Location = new System.Drawing.Point(160, 396);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(126, 45);
            this.btnZoomIn.TabIndex = 7;
            this.btnZoomIn.Text = "Yakınlaş";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZoomOut.Location = new System.Drawing.Point(160, 443);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(126, 45);
            this.btnZoomOut.TabIndex = 8;
            this.btnZoomOut.Text = "Uzaklaş";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnCut
            // 
            this.btnCut.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCut.Location = new System.Drawing.Point(28, 396);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(126, 45);
            this.btnCut.TabIndex = 9;
            this.btnCut.Text = "Kes";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnHone
            // 
            this.btnHone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHone.Location = new System.Drawing.Point(28, 444);
            this.btnHone.Name = "btnHone";
            this.btnHone.Size = new System.Drawing.Size(126, 45);
            this.btnHone.TabIndex = 10;
            this.btnHone.Text = "Bileyle";
            this.btnHone.UseVisualStyleBackColor = true;
            this.btnHone.Click += new System.EventHandler(this.btnHone_Click);
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.Location = new System.Drawing.Point(309, 444);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(196, 33);
            this.progressBarHealth.TabIndex = 11;
            // 
            // progressBarAmmo
            // 
            this.progressBarAmmo.Location = new System.Drawing.Point(28, 360);
            this.progressBarAmmo.Name = "progressBarAmmo";
            this.progressBarAmmo.Size = new System.Drawing.Size(258, 30);
            this.progressBarAmmo.TabIndex = 12;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHealth.Location = new System.Drawing.Point(391, 422);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(135, 24);
            this.lblHealth.TabIndex = 13;
            this.lblHealth.Text = "Enemy Health";
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmmo.Location = new System.Drawing.Point(10, 121);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(89, 23);
            this.lblAmmo.TabIndex = 14;
            this.lblAmmo.Text = "Magazine";
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeaponName.Location = new System.Drawing.Point(10, 49);
            this.lblWeaponName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(59, 23);
            this.lblWeaponName.TabIndex = 16;
            this.lblWeaponName.Text = "Name";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountryName.Location = new System.Drawing.Point(10, 85);
            this.lblCountryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(75, 23);
            this.lblCountryName.TabIndex = 17;
            this.lblCountryName.Text = "Country";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDamage.Location = new System.Drawing.Point(10, 103);
            this.lblDamage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(80, 23);
            this.lblDamage.TabIndex = 18;
            this.lblDamage.Text = "Damage";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSerialNo.Location = new System.Drawing.Point(10, 67);
            this.lblSerialNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(79, 23);
            this.lblSerialNo.TabIndex = 29;
            this.lblSerialNo.Text = "SerialNo";
            // 
            // pictureTank
            // 
            this.pictureTank.Image = global::CounterStrike_Demo.Properties.Resources.bayraktartb2;
            this.pictureTank.Location = new System.Drawing.Point(166, 72);
            this.pictureTank.Margin = new System.Windows.Forms.Padding(2);
            this.pictureTank.Name = "pictureTank";
            this.pictureTank.Size = new System.Drawing.Size(339, 257);
            this.pictureTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTank.TabIndex = 28;
            this.pictureTank.TabStop = false;
            // 
            // pictureHandGrenade
            // 
            this.pictureHandGrenade.Image = global::CounterStrike_Demo.Properties.Resources.handgranade;
            this.pictureHandGrenade.Location = new System.Drawing.Point(223, 33);
            this.pictureHandGrenade.Margin = new System.Windows.Forms.Padding(2);
            this.pictureHandGrenade.Name = "pictureHandGrenade";
            this.pictureHandGrenade.Size = new System.Drawing.Size(275, 310);
            this.pictureHandGrenade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHandGrenade.TabIndex = 27;
            this.pictureHandGrenade.TabStop = false;
            // 
            // pictureAWM
            // 
            this.pictureAWM.Image = global::CounterStrike_Demo.Properties.Resources.awp;
            this.pictureAWM.Location = new System.Drawing.Point(166, 97);
            this.pictureAWM.Margin = new System.Windows.Forms.Padding(2);
            this.pictureAWM.Name = "pictureAWM";
            this.pictureAWM.Size = new System.Drawing.Size(341, 184);
            this.pictureAWM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAWM.TabIndex = 26;
            this.pictureAWM.TabStop = false;
            // 
            // pictureM60
            // 
            this.pictureM60.Image = global::CounterStrike_Demo.Properties.Resources.m60;
            this.pictureM60.Location = new System.Drawing.Point(166, 33);
            this.pictureM60.Margin = new System.Windows.Forms.Padding(2);
            this.pictureM60.Name = "pictureM60";
            this.pictureM60.Size = new System.Drawing.Size(341, 310);
            this.pictureM60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureM60.TabIndex = 25;
            this.pictureM60.TabStop = false;
            // 
            // pictureM4Silenced
            // 
            this.pictureM4Silenced.Image = global::CounterStrike_Demo.Properties.Resources.m4silenced;
            this.pictureM4Silenced.Location = new System.Drawing.Point(166, 59);
            this.pictureM4Silenced.Margin = new System.Windows.Forms.Padding(2);
            this.pictureM4Silenced.Name = "pictureM4Silenced";
            this.pictureM4Silenced.Size = new System.Drawing.Size(341, 270);
            this.pictureM4Silenced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureM4Silenced.TabIndex = 24;
            this.pictureM4Silenced.TabStop = false;
            // 
            // pictureAk47
            // 
            this.pictureAk47.Image = global::CounterStrike_Demo.Properties.Resources.ak47;
            this.pictureAk47.Location = new System.Drawing.Point(166, 33);
            this.pictureAk47.Margin = new System.Windows.Forms.Padding(2);
            this.pictureAk47.Name = "pictureAk47";
            this.pictureAk47.Size = new System.Drawing.Size(341, 310);
            this.pictureAk47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAk47.TabIndex = 23;
            this.pictureAk47.TabStop = false;
            // 
            // pictureShotgun
            // 
            this.pictureShotgun.Image = global::CounterStrike_Demo.Properties.Resources.shotgun;
            this.pictureShotgun.Location = new System.Drawing.Point(166, 59);
            this.pictureShotgun.Margin = new System.Windows.Forms.Padding(2);
            this.pictureShotgun.Name = "pictureShotgun";
            this.pictureShotgun.Size = new System.Drawing.Size(341, 244);
            this.pictureShotgun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShotgun.TabIndex = 22;
            this.pictureShotgun.TabStop = false;
            // 
            // pictureDeagle
            // 
            this.pictureDeagle.Image = global::CounterStrike_Demo.Properties.Resources.deserteagle;
            this.pictureDeagle.Location = new System.Drawing.Point(166, 67);
            this.pictureDeagle.Margin = new System.Windows.Forms.Padding(2);
            this.pictureDeagle.Name = "pictureDeagle";
            this.pictureDeagle.Size = new System.Drawing.Size(341, 246);
            this.pictureDeagle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDeagle.TabIndex = 21;
            this.pictureDeagle.TabStop = false;
            // 
            // pictureGlock
            // 
            this.pictureGlock.Image = global::CounterStrike_Demo.Properties.Resources.glock;
            this.pictureGlock.Location = new System.Drawing.Point(166, 33);
            this.pictureGlock.Margin = new System.Windows.Forms.Padding(2);
            this.pictureGlock.Name = "pictureGlock";
            this.pictureGlock.Size = new System.Drawing.Size(341, 310);
            this.pictureGlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGlock.TabIndex = 20;
            this.pictureGlock.TabStop = false;
            // 
            // pictureAxe
            // 
            this.pictureAxe.Image = global::CounterStrike_Demo.Properties.Resources.axe;
            this.pictureAxe.Location = new System.Drawing.Point(223, 33);
            this.pictureAxe.Margin = new System.Windows.Forms.Padding(2);
            this.pictureAxe.Name = "pictureAxe";
            this.pictureAxe.Size = new System.Drawing.Size(245, 310);
            this.pictureAxe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAxe.TabIndex = 19;
            this.pictureAxe.TabStop = false;
            // 
            // pictureKarambit
            // 
            this.pictureKarambit.Image = global::CounterStrike_Demo.Properties.Resources.karambit;
            this.pictureKarambit.Location = new System.Drawing.Point(166, 33);
            this.pictureKarambit.Margin = new System.Windows.Forms.Padding(2);
            this.pictureKarambit.Name = "pictureKarambit";
            this.pictureKarambit.Size = new System.Drawing.Size(341, 310);
            this.pictureKarambit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKarambit.TabIndex = 15;
            this.pictureKarambit.TabStop = false;
            // 
            // lblKilledEnemy
            // 
            this.lblKilledEnemy.AutoSize = true;
            this.lblKilledEnemy.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKilledEnemy.Location = new System.Drawing.Point(306, 396);
            this.lblKilledEnemy.Name = "lblKilledEnemy";
            this.lblKilledEnemy.Size = new System.Drawing.Size(150, 23);
            this.lblKilledEnemy.TabIndex = 30;
            this.lblKilledEnemy.Text = "Enemies Killed";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nasılOynanırToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nasılOynanırToolStripMenuItem
            // 
            this.nasılOynanırToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nasılOynanırToolStripMenuItem1});
            this.nasılOynanırToolStripMenuItem.Name = "nasılOynanırToolStripMenuItem";
            this.nasılOynanırToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.nasılOynanırToolStripMenuItem.Text = "Info";
            // 
            // nasılOynanırToolStripMenuItem1
            // 
            this.nasılOynanırToolStripMenuItem1.Name = "nasılOynanırToolStripMenuItem1";
            this.nasılOynanırToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.nasılOynanırToolStripMenuItem1.Text = "Nasıl Oynanır?";
            this.nasılOynanırToolStripMenuItem1.Click += new System.EventHandler(this.nasılOynanırToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 500);
            this.Controls.Add(this.lblKilledEnemy);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.pictureTank);
            this.Controls.Add(this.pictureHandGrenade);
            this.Controls.Add(this.pictureAWM);
            this.Controls.Add(this.pictureM60);
            this.Controls.Add(this.pictureM4Silenced);
            this.Controls.Add(this.pictureAk47);
            this.Controls.Add(this.pictureShotgun);
            this.Controls.Add(this.pictureDeagle);
            this.Controls.Add(this.pictureGlock);
            this.Controls.Add(this.pictureAxe);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblWeaponName);
            this.Controls.Add(this.pictureKarambit);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.progressBarAmmo);
            this.Controls.Add(this.progressBarHealth);
            this.Controls.Add(this.btnHone);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Counter Strike 0.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHandGrenade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAWM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureM60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureM4Silenced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAk47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShotgun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeagle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKarambit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnHone;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.ProgressBar progressBarAmmo;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.PictureBox pictureKarambit;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.PictureBox pictureAxe;
        private System.Windows.Forms.PictureBox pictureGlock;
        private System.Windows.Forms.PictureBox pictureDeagle;
        private System.Windows.Forms.PictureBox pictureShotgun;
        private System.Windows.Forms.PictureBox pictureAk47;
        private System.Windows.Forms.PictureBox pictureM4Silenced;
        private System.Windows.Forms.PictureBox pictureM60;
        private System.Windows.Forms.PictureBox pictureAWM;
        private System.Windows.Forms.PictureBox pictureHandGrenade;
        private System.Windows.Forms.PictureBox pictureTank;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblKilledEnemy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nasılOynanırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasılOynanırToolStripMenuItem1;
    }
}

