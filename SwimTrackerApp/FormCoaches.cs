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
    public partial class FormCoaches : Form
    {
        FormMain formMain = new FormMain();
        public List<Swimmer> Swimmers { set; get; }
        public List<Coach> Coaches { set; get; }

        public FormCoaches()
        {
            InitializeComponent();
        }

        private void lsbCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var coach in Coaches)
            {
                try
                {
                    if (coach.Name == lsbCoaches.SelectedItem.ToString())
                    {
                        lblCoachInfo.Text = coach.ToString();
                        break;
                    }
                }
                catch { }
            }

            DisplayRegistrants();
        }

        private void DisplayRegistrants()
        {
            try
            {
                lsbCoachSwimmers.Items.Clear();
                foreach (var item in ReturnObject(lsbCoaches, Coaches).Swimmers)
                {
                    lsbCoachSwimmers.Items.Add(item.Name);
                }
            }
            catch { }
        }

        private Coach ReturnObject(ListBox lsb, List<Coach> coaches)
        {
            Coach aCoach = null;
            try
            {
                foreach (var item in coaches)
                {
                    if (item.Name == lsb.SelectedItem.ToString())
                        return item;
                }

            }
            catch { }
            return aCoach;
        }

        private string GetInfo(Coach aCoach)
        {
            string info = "";
            info += string.Format($"Name: {aCoach.Name} \nAdress: {aCoach.Address.ToString()} \nPhone: {aCoach.PhoneNumber.ToString()} \nDOB: {aCoach.DateOfBirth.ToString()} \nReg number: {aCoach.RegistrantId} \nClub: {(aCoach.Club != null ? aCoach.Club.Name : "not assigned")}");
            info += string.Format("\nCredentials: {0}", aCoach.Credentials);
            return info;
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            long phoneNumber;
            try
            {
                phoneNumber = Convert.ToInt64(txtCoachPhone.Text);
            }
            catch
            {
                MessageBox.Show("Error: PhoneNumber must contain integer numbers only");
                return;
            }
            Coach aCoach = new Coach(txtCoachName.Text, new DateTime(dtpDOB.Value.Year, dtpDOB.Value.Month, dtpDOB.Value.Day), new Address(txtCoachStreet.Text,
                                                       txtCoachCity.Text, txtCoachProv.Text, txtCoachPost.Text), phoneNumber);
            aCoach.Credentials = txtCoachCred.Text;
            ResetTxtValues();
            Coaches.Add(aCoach);
            formMain.Coaches = Coaches;
            lsbCoaches.Items.Add(aCoach.Name);
            MessageBox.Show("A coach was created successfully");
        }

        private void ResetTxtValues()
        {
            txtCoachName.Text = "";
            txtCoachStreet.Text = "";
            txtCoachCity.Text = "";
            txtCoachProv.Text = "";
            txtCoachPost.Text = "";
            txtCoachPhone.Text = "";
            txtCoachCred.Text = "";
        }

        private void btnAssignSwimmer_Click(object sender, EventArgs e)
        {
            try
            {
                Coaches[lsbCoaches.SelectedIndex].AddSwimmer(Swimmers[lsbFreeSwimmers.SelectedIndex]);
                //Swimmers[lsbRegistrantsAssign.SelectedIndex].ItsCoach = Coaches[lsbAllCoaches.SelectedIndex];
                DisplayRegistrants();
                MessageBox.Show($"A swimmer has been assigned successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCoaches_Load(object sender, EventArgs e)
        {
            foreach (var coach in this.Coaches)
            {
                lsbCoaches.Items.Add(coach.Name);
            }
            foreach (var item in Swimmers)
            {
                lsbFreeSwimmers.Items.Add(item.Name);
            }
        }
    }
}
