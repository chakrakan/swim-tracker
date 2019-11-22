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
    public partial class FormEvent : Form
    {
        FormMain formMain = new FormMain();
        public List<Event> SwimEvents { set; get; }
        public List<Swimmer> Swimmers { set; get; }


        public FormEvent()
        {
            InitializeComponent();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            EventDistance distance;
            switch (lsbDistance.SelectedIndex)
            {
                case 0:
                    distance = EventDistance._50;
                    break;
                case 1:
                    distance = EventDistance._100;
                    break;
                case 2:
                    distance = EventDistance._200;
                    break;
                case 3:
                    distance = EventDistance._400;
                    break;
                case 4:
                    distance = EventDistance._800;
                    break;
                case 5:
                    distance = EventDistance._1500;
                    break;
                default:
                    distance = EventDistance._50;
                    break;
            }

            Stroke stroke;
            switch (lsbStroke.SelectedIndex)
            {
                case 0:
                    stroke = Stroke.Butterfly;
                    break;
                case 1:
                    stroke= Stroke.Backstsroke;
                    break;
                case 2:
                    stroke= Stroke.Breaststroke;
                    break;
                case 3:
                    stroke = Stroke.Freestyle;
                    break;
                case 4:
                    stroke = Stroke.Individual_Medley;
                    break;
                default:
                    stroke = Stroke.Freestyle;
                    break;
            }

            Event aEvent = new Event(distance, stroke);
            SwimEvents.Add(aEvent);
            formMain.SwimEvents = SwimEvents;
            lsbEvents.Items.Add(aEvent.Distance.ToString() + " " + aEvent.Stroke.ToString());
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {
            foreach (var item in SwimEvents)
            {
                lsbEvents.Items.Add(item.Distance.ToString() + " " + item.Stroke.ToString());
            }
            foreach (var item in Swimmers)
            {
                lsbSwimmers.Items.Add(item.Name);
            }
        }

        private void btnAssignSwimmer_Click(object sender, EventArgs e)
        {
            SwimEvents[lsbEvents.SelectedIndex].AddSwimmer(Swimmers[lsbSwimmers.SelectedIndex]);
            lblEventInfo.Text = SwimEvents[lsbEvents.SelectedIndex].ToString();
        }

        private void lsbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblEventInfo.Text = SwimEvents[lsbEvents.SelectedIndex].ToString();
            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SwimEvents[lsbEvents.SelectedIndex].EnterSwimmersTime(Swimmers[lsbSwimmers.SelectedIndex], txtMinutes.Text + ":" +
                    txtSeconds.Text + "." + txtMiliSeconds.Text);
                txtMiliSeconds.Clear();
                txtSeconds.Clear();
                txtMinutes.Clear();
                lblErrorTime.Text = "";
            }
            catch (Exception ex)
            {
                lblErrorTime.Text = ex.Message;
            }
            lblEventInfo.Text = SwimEvents[lsbEvents.SelectedIndex].ToString();
        }
    }
}
