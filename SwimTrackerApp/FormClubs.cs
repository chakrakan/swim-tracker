using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimTrackerLibrary;

namespace SwimTrackerApp
{
    public partial class FormClubs : Form
    {
        FormMain formMain = new FormMain();
        public List<Club> Clubs { set; get; }
        public List<Swimmer> Swimmers { set; get; }
        public List<Coach> Coaches { set; get; }
        ClubsManager clubManager = new ClubsManager();

        public FormClubs()
        {
            InitializeComponent();
        }

        private void btnLoadClubs_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse For Clubs.Txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clubManager.Load(openFileDialog1.FileName, ",");
                    Clubs.AddRange(clubManager.Clubs);

                    foreach (var item in clubManager.Clubs)
                    {
                        lsbClubs.Items.Add(item.Name);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //private void FormClubs_Load(object sender, EventArgs e)
        //{
        //    foreach (var item in Clubs)
        //    {
        //        lsbClubs.Items.Add(item.Name);
        //    }

        //    foreach (var item in Swimmers)
        //    {
        //        lsbFreeRegistrants.Items.Add(item.Name);
        //    }
        //}

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            if ((txtClubPhone.Text.Length == 10 && (long.TryParse(txtClubPhone.Text, out long phone))))
            {
                Club aClub = new Club(txtClubName.Text, new Address(txtClubStreet.Text, txtClubCity.Text, txtClubProvince.Text, txtClubPostal.Text), phone);
                txtClubName.Text = String.Empty;
                txtClubStreet.Text = String.Empty;
                txtClubCity.Text = String.Empty;
                txtClubProvince.Text = String.Empty;
                txtClubPostal.Text = String.Empty;
                txtClubPhone.Text = String.Empty;
                Clubs.Add(aClub);
                lblClubAddText.Text = "Club" + txtClubName.Text + " was added successfully";

                formMain.Clubs = Clubs;
                lsbClubs.Items.Add(aClub.Name);
            }
            else
            {
                MessageBox.Show("Error: Must enter a valid phone number equal to 10 digits");
            }
        }

        private void btnSaveClubs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Clubs to File";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                clubManager.Clubs = Clubs;
                clubManager.Save(saveFileDialog1.FileName, "|");
                MessageBox.Show($"Saved to {saveFileDialog1.FileName}", "Success!");
            }
        }

        private Club ReturnObject(ListBox lsb, List<Club> clubs)
        {
            Club aClub = null;
            try
            {
                foreach (var item in clubs)
                {
                    if (item.Name == lsb.SelectedItem.ToString())
                    {
                        return item;
                    }                        
                }
            }
            catch { }
            return aClub;
        }

        private string GetClubInfo(Club aClub)
        {
            return string.Format($"\nName: {aClub.Name} \nAddress: {aClub.Address.ToString()} \nPhone number: {aClub.PhoneNumber} \nReg number: {aClub.RegistrationNum}");
        }

        private void btnAddReg_Click(object sender, EventArgs e)
        {
            if (rbtnSwimmer.Checked)
            {
                try
                {
                    foreach (var item in Swimmers)
                    {
                        if (item.Name == lsbFreeRegistrants.SelectedItem.ToString())
                        {
                            ReturnObject(lsbClubs, Clubs).AddSwimmer(item);
                            break;
                        }
                    }
                }
                catch { }
            }
            else
            {
                try
                {
                    foreach (var item in Coaches)
                    {
                        if (item.Name == lsbFreeRegistrants.SelectedItem.ToString())
                        {
                            ReturnObject(lsbClubs, Clubs).AddCoach(item);
                            break;
                        }
                    }
                }
                catch { }
            }
            lblClubInfo.Text = GetClubInfo(ReturnObject(lsbClubs, Clubs));
            DisplayRegistrants();
        }

        private void rbtnCurrSwim_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lsbAssignedReg.Items.Clear();
                if (rbtnCurrSwim.Checked)
                {
                    foreach (var item in ReturnObject(lsbClubs, Clubs).Registrants)
                    {
                        lsbAssignedReg.Items.Add(item.Name);
                    }
                }
                else
                {
                    foreach (var item in ReturnObject(lsbClubs, Clubs).Coaches)
                    {
                        lsbAssignedReg.Items.Add(item.Name);
                    }
                }
            }
            catch { }
        }

        private void rbtnSwimmer_CheckedChanged(object sender, EventArgs e)
        {
            lsbFreeRegistrants.Items.Clear();
            try
            {
                if (rbtnSwimmer.Checked)
                {
                    foreach (var item in Swimmers)
                    {
                        lsbFreeRegistrants.Items.Add(item.Name);
                    }
                }
                else
                {
                    foreach (var item in Coaches)
                    {
                        lsbFreeRegistrants.Items.Add(item.Name);
                    }
                }
            }
            catch { }
        }

        private void DisplayRegistrants()
        {
            try
            {
                lsbAssignedReg.Items.Clear();
                if (rbtnSwimmer.Checked)
                {
                    foreach (var item in ReturnObject(lsbClubs, Clubs).Registrants)
                    {
                        lsbAssignedReg.Items.Add(item.Name);
                    }
                }
                else
                {
                    foreach (var item in ReturnObject(lsbClubs, Clubs).Coaches)
                    {
                        lsbAssignedReg.Items.Add(item.Name);
                    }
                }
            }
            catch { }
        }

        private void lsbFreeRegistrants_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnSwimmer.Checked)
                {
                    foreach (var item in Swimmers)
                    {
                        if (item.Name == lsbFreeRegistrants.SelectedItem.ToString())
                        {
                            lblRegInfo.Text = item.ToString();
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var item in Coaches)
                    {
                        if (item.Name == lsbFreeRegistrants.SelectedItem.ToString())
                        {
                            lblRegInfo.Text = item.ToString();
                            break;
                        }
                    }
                }
            }
            catch { }
        }

        private void lsbAssignedReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnCurrSwim.Checked)
                {
                    foreach (var item in Swimmers)
                    {
                        if (item.Name == lsbAssignedReg.SelectedItem.ToString())
                        {
                            lblRegInfo.Text = item.ToString();
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var item in Coaches)
                    {
                        if (item.Name == lsbAssignedReg.SelectedItem.ToString())
                        {
                            lblRegInfo.Text = item.ToString();
                            break;
                        }
                    }
                }
            }
            catch { }
        }

        private void lsbClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //lblClubInfo.Text = ReturnObjectClubFrom(lsbClubs, Clubs).ToString();
                lblClubInfo.Text = ReturnObject(lsbClubs, Clubs).ToString();
            }
            catch
            { }
        }

        private void FormClubs_Load_1(object sender, EventArgs e)
        {
            foreach (var item in Clubs)
            {
                lsbClubs.Items.Add(item.Name);
            }

            foreach (var item in Swimmers)
            {
                lsbFreeRegistrants.Items.Add(item.Name);
            }
        }
    }
}
