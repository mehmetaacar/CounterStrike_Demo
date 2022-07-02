using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weapons;
using System.Media;

namespace CounterStrike_Demo
{
    public partial class Form1 : Form
    {
        #region GLOBAL TANIMLAMALARI
        Gun glock = new Gun();
        Gun desertEagle = new Gun();
        Gun shotgun = new Gun();
        Gun ak47 = new Gun();
        Gun m4a1 = new Gun();
        Gun awm = new Gun();
        Gun tb2 = new Gun();
        Gun hg = new Gun();
        Melee karambit = new Melee();
        Melee axe = new Melee();
        int enemyKilled = 1;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region FORM
        private void Form1_Load(object sender, EventArgs e)
        {
            PictureHide();
            ButtonHide();

            progressBarHealth.Value = 100;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.D1:
                    //KARAMBİT

                    KarambitInfo();
                    ButtonsforMelee();
                    PictureShow(pictureKarambit, true);

                    break;
                case Keys.D2:
                    //BALTA

                    AxeInfo();
                    ButtonsforMelee();
                    PictureShow(pictureAxe, true);

                    break;
                case Keys.D3:
                    //GLOCK

                    GlockInfo();
                    ButtonsforGun();
                    PictureShow(pictureGlock, true);

                    break;
                case Keys.D4:
                    // DESERT EAGLE

                    DesertEagleInfo();
                    ButtonsforGun();
                    PictureShow(pictureDeagle, true);

                    break;
                case Keys.D5:
                    //SHOTGUN

                    ShotgunInfo();
                    ButtonsforGun();
                    PictureShow(pictureShotgun, true);

                    break;

                case Keys.D6:
                    //AK47

                    ak47Info();
                    ButtonsforGun();
                    PictureShow(pictureAk47, true);

                    break;
                case Keys.D7:
                    //M4-SILENCED

                    m4a1Info();
                    ButtonsforScopeGun();
                    PictureShow(pictureM4Silenced, true);

                    break;
                case Keys.D8:
                    // AWM

                    awmInfo();
                    ButtonsforScopeGun();
                    PictureShow(pictureAWM, true);

                    break;
                case Keys.D9:
                    //Bayraktar

                    tb2Info();
                    ButtonsforScopeGun();
                    PictureShow(pictureTank, true);

                    break;
                case Keys.D0:
                    //HG

                    handGrenadeInfo();
                    ButtonsforGun();
                    PictureShow(pictureHandGrenade, true);

                    break;
            }
        }
        #endregion

        #region GÖRSEL VE BUTON METOTLARI

        void PictureShow(Control picture, bool activity)
        {
            PictureHide();
            picture.Visible = activity;
        }
        void PictureHide()
        {
            pictureKarambit.Visible = false;
            pictureHandGrenade.Visible = false;
            pictureGlock.Visible = false;
            pictureM4Silenced.Visible = false;
            pictureGlock.Visible = false;
            pictureAxe.Visible = false;
            pictureAk47.Visible = false;
            pictureAWM.Visible = false;
            pictureTank.Visible = false;
            pictureShotgun.Visible = false;
            pictureM60.Visible = false;
            pictureDeagle.Visible = false;

        }
        void ButtonShow(Control button, bool activity)
        {
            button.Visible = activity;
        }
        void ButtonHide()
        {
            btnFire.Visible = false;
            btnReload.Visible = false;
            btnZoomIn.Visible = false;
            btnZoomOut.Visible = false;
            btnCut.Visible = false;
            btnHone.Visible = false;
        }
        void ButtonsforMelee()
        {
            ButtonHide();
            ButtonShow(btnCut, true);
            ButtonShow(btnHone, true);

        }
        void ButtonsforGun()
        {
            ButtonHide();
            ButtonShow(btnFire, true);
            ButtonShow(btnReload, true);

        }
        void ButtonsforScopeGun()
        {
            ButtonsforGun();
            ButtonShow(btnZoomIn, true);
            ButtonShow(btnZoomOut, true);
        }

        #endregion

        #region SİLAH BİLGİLERİ

        void KarambitInfo()
        {



            karambit.Name = "Karambit";
            karambit.SerialNo = "060153";
            karambit.Country = "USA";
            karambit.Damage = 30;
            karambit.Health = 50;

            this.Text = "Karambit";

            string name = karambit.Name;
            string serialNo = karambit.SerialNo;
            string country = karambit.Country;
            string damage = karambit.Damage.ToString();

            lblWeaponName.Text = "Silah Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "";

            progressBarAmmo.Maximum = karambit.Health;
            progressBarAmmo.Value = karambit.Health;


        }
        void AxeInfo()
        {


            axe.Name = "Balta";
            axe.SerialNo = "760248";
            axe.Country = "Avustralya";
            axe.Damage = 50;
            axe.Health = 100;
            this.Text = "Balta";

            string name = axe.Name;
            string serialNo = axe.SerialNo;
            string country = axe.Country;
            string damage = axe.Damage.ToString();

            lblWeaponName.Text = "Silah Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "";
            progressBarAmmo.Maximum = axe.Health;
            progressBarAmmo.Value = axe.Health;
        }
        void GlockInfo()
        {


            glock.Name = "Glock";
            glock.SerialNo = "CTN208";
            glock.Country = "Avusturya";
            glock.Damage = 25;
            glock.Ammo = 20;
            this.Text = "Glock";

            string name = glock.Name;
            string serialNo = glock.SerialNo;
            string country = glock.Country;
            string damage = glock.Damage.ToString();
            string ammo = glock.Ammo.ToString();

            lblWeaponName.Text = "Silah Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "Mermi: " + ammo;

            progressBarAmmo.Maximum = glock.Ammo;
            progressBarAmmo.Value = glock.Ammo;
        }
        void DesertEagleInfo()
        {
            desertEagle.Name = "Desert Eagle";
            desertEagle.SerialNo = "4233";
            desertEagle.Country = "İsrail";
            desertEagle.Damage = 32;
            desertEagle.Ammo = 7;

            this.Text = "Desert Eagle";


            string name = desertEagle.Name;
            string serialNo = desertEagle.SerialNo;
            string country = desertEagle.Country;
            string damage = desertEagle.Damage.ToString();
            string ammo = desertEagle.Ammo.ToString();

            lblWeaponName.Text = "Silah Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "Mermi: " + ammo;

            progressBarAmmo.Maximum = desertEagle.Ammo;
            progressBarAmmo.Value = desertEagle.Ammo;
        }
        void ShotgunInfo()
        {
            shotgun.Name = "Franchi";
            shotgun.SerialNo = "F23S211";
            shotgun.Country = "İtalya";
            shotgun.Damage = 50;
            shotgun.Ammo = 9;
            this.Text = "Pompalı Tüfek";

            string name = shotgun.Name;
            string serialNo = shotgun.SerialNo;
            string country = shotgun.Country;
            string damage = shotgun.Damage.ToString();
            string ammo = shotgun.Ammo.ToString();

            lblWeaponName.Text = "Silah Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "Mermi: " + ammo;
            progressBarAmmo.Maximum = shotgun.Ammo;
            progressBarAmmo.Value = shotgun.Ammo;
        }
        void ak47Info()
        {


            ak47.Name = "AK-47";
            ak47.SerialNo = "1964PG4458";
            ak47.Country = "Sovyet";
            ak47.Damage = 40;
            ak47.Ammo = 30;
            this.Text = "AK47";

            string name = ak47.Name;
            string serialNo = ak47.SerialNo;
            string country = ak47.Country;
            string damage = ak47.Damage.ToString();
            string ammo = ak47.Ammo.ToString();

            lblWeaponName.Text = "Silah Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "Mermi: " + ammo;
            progressBarAmmo.Maximum = ak47.Ammo;
            progressBarAmmo.Value = ak47.Ammo;
        }
        void m4a1Info()
        {
            m4a1.Name = "M4 Carbine";
            m4a1.SerialNo = "457M002";
            m4a1.Country = "USA";
            m4a1.Damage = 30;
            m4a1.Ammo = 30;
            this.Text = "M4 Carbine";

            string name = m4a1.Name;
            string serialNo = m4a1.SerialNo;
            string country = m4a1.Country;
            string damage = m4a1.Damage.ToString();
            string ammo = m4a1.Ammo.ToString();

            lblWeaponName.Text = "Silah Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "Mermi: " + ammo;

            progressBarAmmo.Maximum = m4a1.Ammo;
            progressBarAmmo.Value = m4a1.Ammo;
        }
        void awmInfo()
        {
            awm.Name = "AWM";
            awm.SerialNo = "AMW0007";
            awm.Country = "İngiltere";
            awm.Damage = 100;
            awm.Ammo = 10;
            this.Text = "AWM";

            string name = awm.Name;
            string serialNo = awm.SerialNo;
            string country = awm.Country;
            string damage = awm.Damage.ToString();
            string ammo = awm.Ammo.ToString();

            lblWeaponName.Text = "Silah Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "Mermi: " + ammo;

            progressBarAmmo.Maximum = awm.Ammo;
            progressBarAmmo.Value = awm.Ammo;
        }
        void tb2Info()
        {
            tb2.Name = "Bayraktar TB2";
            tb2.SerialNo = "0001";
            tb2.Country = "Türkiye";
            tb2.Damage = 100;
            tb2.Ammo = 5;
            this.Text = "BAYRAKTAR TB2";

            string name = tb2.Name;
            string serialNo = tb2.SerialNo;
            string country = tb2.Country;
            string damage = "XXX";
            string ammo = tb2.Ammo.ToString();


            lblWeaponName.Text = "Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "Mermi: " + ammo;
            progressBarAmmo.Maximum = tb2.Ammo;
            progressBarAmmo.Value = tb2.Ammo;

        }
        void handGrenadeInfo()
        {

            hg.Name = "El bombası";
            hg.SerialNo = "5-69C2E";
            hg.Country = "Ülkesiz";
            hg.Damage = 100;
            hg.Ammo = 2;
            this.Text = "El bombası";

            string name = hg.Name;
            string serialNo = hg.SerialNo;
            string country = hg.Country;
            string damage = hg.Damage.ToString();
            string ammo = hg.Ammo.ToString();

            lblWeaponName.Text = "Adı: " + name;
            lblSerialNo.Text = "Seri No: " + serialNo;
            lblCountryName.Text = "Menşei: " + country;
            lblDamage.Text = "Hasar: " + damage;
            lblAmmo.Text = "Mermi: " + ammo;
            progressBarAmmo.Maximum = hg.Ammo;
            progressBarAmmo.Value = hg.Ammo;
        }
        #endregion

        #region METOTLAR

        void ReloadAmmo()
        {
            switch (this.Text)
            {
                case "Glock":
                    progressBarAmmo.Value = glock.Ammo;
                    break;
                case "Desert Eagle":
                    progressBarAmmo.Value = desertEagle.Ammo;
                    break;
                case "Pompalı Tüfek":
                    progressBarAmmo.Value = shotgun.Ammo;
                    break;
                case "AK47":
                    progressBarAmmo.Value = ak47.Ammo;
                    break;
                case "M4 Carbine":
                    progressBarAmmo.Value = m4a1.Ammo;
                    break;
                case "AWM":
                    progressBarAmmo.Value = awm.Ammo;
                    break;
                case "BAYRAKTAR TB2":
                    progressBarAmmo.Value = tb2.Ammo;
                    break;
                case "El bombası":
                    progressBarAmmo.Value = hg.Ammo;
                    break;
            }
        }
        void FireClickSoundPlay()
        {
            switch (this.Text)
            {
                case "Glock":
                    GunFireSound(glock, "glockfire.wav");
                    break;
                case "Desert Eagle":
                    GunFireSound(desertEagle, "deserteaglefire.wav");
                    break;
                case "Pompalı Tüfek":
                    GunFireSound(shotgun, "shotgunfire.wav");
                    break;
                case "AK47":
                    GunFireSound(ak47, "ak47fire.wav");
                    break;
                case "M4 Carbine":
                    GunFireSound(m4a1, "m4a1fire.wav");
                    break;
                case "AWM":
                    GunFireSound(awm, "awmfire.wav");
                    break;
                case "BAYRAKTAR TB2":
                    GunFireSound(tb2, "bayraktar.wav");
                    break;
                case "El bombası":
                    GunFireSound(hg, "hgfire.wav");
                    break;

            }
        }
        void ReloadClickSoundPlay()
        {
            switch (this.Text)
            {
                case "Glock":
                    GunReloadSound(glock, "glockreload.wav");
                    break;
                case "Desert Eagle":
                    GunReloadSound(desertEagle, "deserteaglereload.wav");
                    break;
                case "Pompalı Tüfek":
                    GunReloadSound(shotgun, "shotgunreload.wav");
                    break;
                case "AK47":
                    GunReloadSound(ak47, "akreload.wav");
                    break;
                case "M4 Carbine":
                    GunReloadSound(m4a1, "m4a1reload.wav");
                    break;
                case "AWM":
                    GunReloadSound(awm, "awmreload.wav");
                    break;
                case "BAYRAKTAR TB2":
                    GunReloadSound(tb2, "bayraktarreload.wav");
                    break;
                case "El bombası":
                    GunReloadSound(hg, "hgreload.wav");
                    break;

            }
        }
        void GunFireSound(Gun gunName, string location)
        {
            gunName.Sound(location);
        }
        void GunReloadSound(Gun gunName, string location)
        {
            gunName.Sound(location);
        }
        void HoneMelee()
        {
            switch (this.Text)
            {
                case "Karambit":
                    
                    if (progressBarAmmo.Value == karambit.Health)
                    {
                        MessageBox.Show("Karambit zaten bileylenmiş");
                    }
                    else
                    {
                        progressBarAmmo.Value = karambit.Health;
                    }
                    break;
                case "Balta":
                    if (progressBarAmmo.Value == axe.Health)
                    {
                        MessageBox.Show("Balta zaten bileylenmiş");
                    }
                    else
                    {
                        progressBarAmmo.Value = axe.Health;
                    }
                    
                    break;
            }
        }
        void CutClickSoundPlay()
        {
            switch (this.Text)
            {
                case "Karambit":
                    MeleeCutSound(karambit, "meleehit.wav");
                    break;
                case "Balta":
                    MeleeCutSound(axe, "meleehit.wav");
                    break;
            }
        }
        void HoneClickSoundPlay()
        {
            switch (this.Text)
            {
                case "Karambit":
                    MeleeCutSound(karambit, "meleehone.wav");
                    break;
                case "Balta":
                    MeleeCutSound(axe, "meleehone.wav");
                    break;
            }
        }
        void MeleeCutSound(Melee meleeName, string location)
        {
            meleeName.Sound(location);
        }
        void MeleeHoneSound(Melee meleeName, string location)
        {
            meleeName.Sound(location);
        }

        void ZoomIn()
        {
            SoundPlayer zoomIn = new SoundPlayer("zoom.wav");
            zoomIn.Play();
            MessageBox.Show("Zoom açıldı.");
        }
        void ZoomOut()
        {
            SoundPlayer zoomOut = new SoundPlayer("zoom.wav");
            zoomOut.Play();
            MessageBox.Show("Zoom kapandı.");
        }

        void OutOfBullets()
        {
            progressBarAmmo.Value--;

            if (progressBarAmmo.Value == 0)
            {
                ReloadClickSoundPlay();

                ReloadAmmo();
            }
        }

        void NeedHone()
        {
            progressBarAmmo.Value=progressBarAmmo.Value-10;

            if (progressBarAmmo.Value == 0)
            {
                HoneClickSoundPlay();

                HoneMelee();
            }
        }

        void KillEnemyandHealthBar(Weapon weapon)
        {
            try
            {
                progressBarHealth.Value = progressBarHealth.Value - weapon.Damage;

                if (progressBarHealth.Value <= 0)
                {
                    lblKilledEnemy.Text = "Öldürülen Düşman: " + enemyKilled.ToString();
                    MessageBox.Show("You killed an enemy");
                    enemyKilled++;

                    progressBarHealth.Value = 100;

                    SoundPlayer kill = new SoundPlayer("death.wav");
                    kill.Play();
                }
            }
            catch (Exception)
            {
                lblKilledEnemy.Text = "Öldürülen Düşman: " + enemyKilled.ToString();
                MessageBox.Show("You killed an enemy");
                enemyKilled++;

                progressBarHealth.Value = 100;

                SoundPlayer kill = new SoundPlayer("death.wav");
                kill.Play();

            }
            

            

        }
        void KillEnemyandHealthBarForWeapons()
        {
            switch (this.Text)
            {
                case "Karambit":
                    KillEnemyandHealthBar(karambit); 
                    break;
                case "Balta":
                    KillEnemyandHealthBar(axe); 
                    break;
                case "Glock":
                    KillEnemyandHealthBar(glock);
                    break;
                case "Desert Eagle":
                    KillEnemyandHealthBar(desertEagle);
                    break;
                case "Pompalı Tüfek":
                    KillEnemyandHealthBar(shotgun);
                    break;
                case "AK47":
                    KillEnemyandHealthBar(ak47);
                    break;
                case "M4 Carbine":
                    KillEnemyandHealthBar(m4a1);
                    break;
                case "AWM":
                    KillEnemyandHealthBar(awm);
                    break;
                case "BAYRAKTAR TB2":
                    KillEnemyandHealthBar(tb2);
                    break;
                case "El bombası":
                    KillEnemyandHealthBar(hg);
                    break;
            }

        }
        #endregion

        #region BUTONLAR
        private void btnFire_Click(object sender, EventArgs e)
        {
            FireClickSoundPlay();
            OutOfBullets();
            KillEnemyandHealthBarForWeapons();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadClickSoundPlay();
            ReloadAmmo();

        }
        private void btnCut_Click(object sender, EventArgs e)
        {
            CutClickSoundPlay();
            NeedHone();
            KillEnemyandHealthBarForWeapons();
        }
        private void btnHone_Click(object sender, EventArgs e)
        {
            HoneClickSoundPlay();
            HoneMelee();
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }
        #endregion

        private void nasılOynanırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klavyenizdeki sayı tuşlarına basıp silah seçmeniz gerekir.\nSeçtiğiniz silah ile ilgili butonlarla etkileşime geçebilirsiniz.");
        }
    }
}
