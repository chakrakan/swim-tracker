﻿using System;
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
    public partial class FormMain : Form
    {
        public List<Club> Clubs { set; get; }
        public List<Event> SwimEvents { set; get; }
        public List<Swimmer> Swimmers { set; get; }
        public List<Coach> Coaches { set; get; }
        public List<SwimMeet> SwimMeets { set; get; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Creating and populating Swimmers List 
            Swimmers = new List<Swimmer>();
            Swimmer swimmer1;
            Swimmer swimmer2;
            Swimmer swimmer3;
            CreateSwimmers(out swimmer1, out swimmer2, out swimmer3);
            Swimmers.AddRange(new[] { swimmer1, swimmer2, swimmer3 });

            //Creating and populating Clubs List
            Clubs = new List<Club>();
            Club club1;
            Club club2;
            CreateClubs(out club1, out club2);
            Clubs.AddRange(new[] { club1, club2 });

            //Creating and populating Coaches List
            Coaches = new List<Coach>();
            Coach coach1;
            Coach coach2;
            CreateCoaches(out coach1, out coach2);
            Coaches.AddRange(new[] { coach1, coach2 });

            //Creating and populating SwimMeets List
            SwimMeets = new List<SwimMeet>();
            SwimMeet meet1;
            SwimMeet meet2;
            CreateSwimMeets(out meet1, out meet2);
            SwimMeets.AddRange(new[] { meet1, meet2 });

            //Creating and populating Events List (Events is reserved keyword for a component)
            SwimEvents = new List<Event>();
            Event _50free1;
            Event _100fly;
            Event _200breast;
            Event _400free;
            Event _1500free;
            Event _1500free2;
            CreateEvents(out _50free1, out _100fly, out _200breast, out _400free, out _1500free, out _1500free2);
            SwimEvents.AddRange(new[] { _50free1, _100fly, _200breast, _400free, _1500free, _1500free2 });

            AddEventsToSwimMeets(meet1, meet2, _50free1, _100fly, _200breast, _400free, _1500free, _1500free2);
            AddSwimmersToEvents(swimmer1, swimmer2, swimmer3, meet1, meet2,
                                _50free1, _100fly, _200breast, _400free, _1500free, _1500free2);
        }

        private static void CreateSwimmers(out Swimmer swimmer1, out Swimmer swimmer2, out Swimmer swimmer3)
        {
            swimmer1 = new Swimmer("Bob Smith", new DateTime(1970, 1, 1),
                                                    new Address("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567);
            swimmer2 = new Swimmer();
            swimmer2.Address = new Address("1 King St", "Toronto", "ON", "M2M 3M3");
            swimmer2.Name = "John Lee";
            swimmer2.PhoneNumber = 4162222222;
            swimmer2.DateOfBirth = new DateTime(1950, 12, 1);
            swimmer3 = new Swimmer("Ann Smith", new DateTime(1975, 1, 1),
                                                    new Address("5 Queen St", "Toronto", "ON", "M2M 4M4"), 4163333333);

        }

        private static void CreateClubs(out Club club1, out Club club2)
        {
            club1 = new Club();
            club1.PhoneNumber = 4164444444;
            club1.Name = "NYAC";
            club2 = new Club("CCAC", new Address("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);
        }

        private static void CreateCoaches(out Coach coach1, out Coach coach2)
        {
            coach1 = new Coach("John Wisemiler", new DateTime(1950, 1, 1),
                                                    new Address("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567);

            coach2 = new Coach("Micael Phelps", new DateTime(1975, 6, 30),
                                                    new Address("5 Queen St", "Boston", "ON", "234567"), 3123123333);
            coach2.Credentials = "NNCA Level 1";
        }

        private static void CreateSwimMeets(out SwimMeet meet1, out SwimMeet meet2)
        {
            meet1 = new SwimMeet();
            meet1.Name = "Winnter Splash";
            meet1.StartDate = new DateTime(2017, 1, 10);
            meet1.EndDate = new DateTime(2017, 1, 12);
            meet2 = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.SCM, 2);
        }

        private static void CreateEvents(out Event _50free1, out Event _100fly, out Event _200breast, out Event _400free, out Event _1500free, out Event _1500free2)
        {
            _50free1 = new Event();
            _50free1.Distance = EventDistance._50;
            _50free1.Stroke = Stroke.Freestyle;

            _100fly = new Event(EventDistance._100, Stroke.Butterfly);
            _200breast = new Event(EventDistance._200, Stroke.Breaststroke);
            _400free = new Event(EventDistance._400, Stroke.Freestyle);
            _1500free = new Event(EventDistance._1500, Stroke.Freestyle);
            _1500free2 = new Event(EventDistance._1500, Stroke.Freestyle);
        }

        private static void AddSwimmersToEvents(Registrant swimmer1, Registrant swimmer2, Registrant swimmer3, SwimMeet meet1, SwimMeet meet2, Event _50free1, Event _100fly, Event _200breast, Event _400free, Event _1500free, Event _1500free2)
        {
            //Add swimmers to event
            _50free1.AddSwimmer(swimmer1);
            _50free1.AddSwimmer(swimmer2);
            _50free1.AddSwimmer(swimmer3);

            _100fly.AddSwimmer(swimmer1);
            _100fly.AddSwimmer(swimmer2);

            _200breast.AddSwimmer(swimmer1);
            _200breast.AddSwimmer(swimmer2);
            _200breast.AddSwimmer(swimmer3);

            _400free.AddSwimmer(swimmer2);

            _1500free.AddSwimmer(swimmer1);
            _1500free.AddSwimmer(swimmer2);
            _1500free.AddSwimmer(swimmer3);

            _1500free2.AddSwimmer(swimmer1);
            _1500free2.AddSwimmer(swimmer3);
        }

        private static void AddEventsToSwimMeets(SwimMeet meet1, SwimMeet meet2, Event _50free1, Event _100fly, Event _200breast, Event _400free, Event _1500free, Event _1500free2)
        {
            meet1.AddEvent(_50free1);
            meet1.AddEvent(_100fly);
            meet1.AddEvent(_200breast);
            meet1.AddEvent(_1500free2);
            meet2.AddEvent(_400free);
            meet2.AddEvent(_1500free);
        }

        private void btnClubsManager_Click(object sender, EventArgs e)
        {
            FormClubs formClubs = new FormClubs();
            formClubs.Swimmers = Swimmers;
            formClubs.Clubs = Clubs;
            formClubs.Coaches = Coaches;
            formClubs.ShowDialog(this);
        }

        private void btnSwimmerManager_Click(object sender, EventArgs e)
        {
            FormSwimmers formSwimmers = new FormSwimmers();
            formSwimmers.Swimmers = Swimmers;
            formSwimmers.ShowDialog(this);
        }

        private void btnCoachManager_Click(object sender, EventArgs e)
        {
            FormCoaches formCoaches = new FormCoaches();
            formCoaches.Coaches = Coaches;
            formCoaches.Swimmers = Swimmers;
            formCoaches.ShowDialog(this);
        }

        private void btnEventsManager_Click(object sender, EventArgs e)
        {
            FormEvent formEvents = new FormEvent();
            formEvents.SwimEvents = SwimEvents;
            formEvents.Swimmers = Swimmers;
            formEvents.ShowDialog(this);
        }

        private void btnSwimMeetsManager_Click(object sender, EventArgs e)
        {
            FormSwimMeet formSwimMeet = new FormSwimMeet();
            formSwimMeet.SwimMeets = SwimMeets;
            formSwimMeet.SwimEvents = SwimEvents;
            formSwimMeet.ShowDialog(this);
        }
    }
}
