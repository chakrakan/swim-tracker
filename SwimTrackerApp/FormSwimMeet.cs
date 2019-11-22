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
    public partial class FormSwimMeet : Form
    {
        public List<SwimMeet> SwimMeets { set; get; }
        public List<Event> SwimEvents { set; get; }
        FormMain formMain = new FormMain();

        public FormSwimMeet()
        {
            InitializeComponent();
        }

        private void FormSwimMeet_Load(object sender, EventArgs e)
        {
            dtpStart.MinDate = DateTime.Today;
            dtpEnd.MinDate = DateTime.Today;
            foreach (var item in SwimMeets)
            {
                lsbSwimMeets.Items.Add(item.Name);
            }
            foreach (var item in SwimEvents)
            {
                lsbEvents.Items.Add(item.Distance.ToString() + item.Stroke.ToString());
            }
        }

        private void btnAddSwimMeet_Click(object sender, EventArgs e)
        {
            int noOfLanes = 0;
            if (Int32.TryParse(txtLanes.Text, out noOfLanes))
            {
                PoolType course;
                switch (lsbCourse.SelectedIndex)
                {
                    case 0:
                        course = PoolType.SCM;
                        break;
                    case 1:
                        course = PoolType.SCY;
                        break;
                    case 2:
                        course = PoolType.LCM;
                        break;
                    default:
                        course = PoolType.SCM;
                        break;
                }
                SwimMeet aSwimMeet = new SwimMeet(txtMeetName.Text, dtpStart.Value.Date, dtpEnd.Value.Date, course, noOfLanes);
                SwimMeets.Add(aSwimMeet);
                formMain.SwimMeets = SwimMeets;
                lsbSwimMeets.Items.Add(aSwimMeet.Name);
                txtMeetName.Clear();
                txtLanes.Clear();
                lblError.Text = "";
            }
            else if (dtpStart.Value > dtpEnd.Value)
                lblError.Text = "End date should be later than start date";
            else
                lblError.Text = "Number of lanes should be integer";
        }

        private void lsbSwimMeets_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ShowInfo()
        {
            try
            {
                lblMeetInfo.Text = SwimMeets[lsbSwimMeets.SelectedIndex].ToString();
            }
            catch { }
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            SwimMeets[lsbSwimMeets.SelectedIndex].Seed();
            ShowInfo();
        }

        private void btnAssignEvent_Click(object sender, EventArgs e)
        {
            SwimMeets[lsbSwimMeets.SelectedIndex].AddEvent(SwimEvents[lsbEvents.SelectedIndex]);
            ShowInfo();
        }
    }
}
