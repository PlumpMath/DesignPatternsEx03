using System;
using System.Threading;
using System.Windows.Forms;


namespace _523116184522448
{
    public partial class EventLocationsForm : Form
    {
        private FBAdapter m_FBAdapter;
        private Map m_Map = new GreatMap();
        UserEvents m_UserEvents;

        public FBAdapter FBUtilities 
        {
            set {
                m_FBAdapter = value;
                m_UserEvents = new UserEvents(m_FBAdapter);
                m_UserEvents.SetEventsStrategy(new AllAttendingEvents());
            }
        }

        public EventLocationsForm()
        {
            InitializeComponent();
            this.mapControl = m_Map.MapControl;
            m_Map.Initialize(284, 12, 315, 302);
            this.Controls.Add(this.mapControl);
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            new Thread(() => m_FBAdapter.FetchCollectionAsync(listBoxEvents, m_UserEvents.GetEvents(), "Name")).Start();
            new Thread(() => m_Map.LoadMap(mapControl, m_FBAdapter, m_UserEvents.GetEvents())).Start();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {       
            if (m_FBAdapter.HasLocationEvent(listBoxEvents.SelectedItem))
            {
                m_Map.SetPosition(m_FBAdapter.GetLatLong(listBoxEvents.SelectedItem));
            }
            else
            {
                m_Map.ZoomAndCenterMarkers();
            }
        }

        private void radioButtonAllEvents_CheckedChanged(object sender, EventArgs e)
        {
            m_UserEvents.SetEventsStrategy(new AllAttendingEvents());
        }

        private void radioButtonEventsCreated_CheckedChanged(object sender, EventArgs e)
        {
            m_UserEvents.SetEventsStrategy(new EventsCreated());
        }

        private void radioButtonEventsNotReplied_CheckedChanged(object sender, EventArgs e)
        {
            m_UserEvents.SetEventsStrategy(new EventsNotReplied());
        }
    }
}
