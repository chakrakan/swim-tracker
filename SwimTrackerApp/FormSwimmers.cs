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
    public partial class FormSwimmers : Form
    {
        FormMain formMain = new FormMain();
        public List<Swimmer> Swimmers { set; get; }
        ClubsManager clubManager;
        SwimmersManager swimmManager;

        public FormSwimmers()
        {
            InitializeComponent();
            clubManager = new ClubsManager();
            swimmManager = new SwimmersManager(clubManager);
        }

        private void btnAddSwimmer_Click(object sender, EventArgs e)
        {
            long phoneNumber;
            try
            {
                phoneNumber = Convert.ToInt64(txtSwimmerPhone.Text);
            }
            catch
            {
                MessageBox.Show("Error: PhoneNumber must contain integer numbers only");
                return;
            }
            Swimmer aSwimmer = new Swimmer(txtSwimmerName.Text, new DateTime(dtpDOB.Value.Year, dtpDOB.Value.Month, dtpDOB.Value.Day), new Address(txtSwimmerStreet.Text, txtSwimmerCity.Text, txtSwimmerProv.Text, txtSwimmerPost.Text), phoneNumber);
            ResetTxtValues();
            Swimmers.Add(aSwimmer);
            formMain.Swimmers = Swimmers;
            lsbSwimmers.Items.Add(aSwimmer.Name);
            MessageBox.Show("A swimmer was created successfully");
        }

        private void ResetTxtValues()
        {
            txtSwimmerName.Text = "";
            txtSwimmerStreet.Text = "";
            txtSwimmerCity.Text = "";
            txtSwimmerProv.Text = "";
            txtSwimmerPost.Text = "";
            txtSwimmerPhone.Text = "";
        }

        private void lsbSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var swimer in Swimmers)
                {
                    if (swimer.Name == lsbSwimmers.SelectedItem.ToString())
                    {
                        lblSwimmerInfo.Text = swimer.ToString();
                        break;
                    }
                }
            }
            catch { }
        }

        private void btnLoadSwimmers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse For Swimmers.Txt";
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
                    swimmManager.Load(openFileDialog1.FileName, ",");
                }
                catch { }

                foreach (var item in swimmManager.Swimmers)
                {
                    Swimmer aSwimmer = new Swimmer(item.Name, item.DateOfBirth, item.Address, item.PhoneNumber);
                    Swimmers.Add(aSwimmer);
                    lsbSwimmers.Items.Add(aSwimmer.Name);
                }
            }
        }

        private void btnSaveSwimmers_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Swimmers to File";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                swimmManager.Save(saveFileDialog1.FileName, "|");
                MessageBox.Show($"Saved to {saveFileDialog1.FileName}", "Success!");
            }
        }

        private void FormSwimmers_Load(object sender, EventArgs e)
        {
            foreach (var swimmer in Swimmers)
            {
                lsbSwimmers.Items.Add(swimmer.Name);
            }
        }
    }
}
