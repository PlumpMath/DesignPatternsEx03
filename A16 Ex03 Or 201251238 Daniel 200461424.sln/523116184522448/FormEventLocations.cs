using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;

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
                m_UserEvents.SetEventsStrategy(new AllEvents());
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
            new Thread(() => m_Map.LoadMap(mapControl, m_FBAdapter)).Start();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {       
            if (m_FBAdapter.HasLocationEvent(listBoxEvents.SelectedItem))
            {
                m_Map.Position = m_Map.getLatLong(m_FBAdapter.GetLatLong(listBoxEvents.SelectedItem));
            }
            else
            {
                m_Map.ZoomAndCenterMarkers();
            }
        }

        private void radioButtonAllEvents_CheckedChanged(object sender, EventArgs e)
        {
            m_UserEvents.SetEventsStrategy(new AllEvents());
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

    // Use of Template Method pattern to keep code maintainable. 
    // This will allow easy replacement of map tool in the future.
    abstract class Map
    {
        
        internal abstract void LoadMap(UserControl i_UserControl, FBAdapter i_FBAdapter);
        internal abstract void Initialize(Int32 i_LocationX, Int32 i_LocationY, Int32 i_Width, Int32 i_Height);
        internal abstract PointLatLng Position { get; set; }
        internal abstract void ZoomAndCenterMarkers();
        internal abstract UserControl MapControl { get; }

        internal void TemplateMethod(UserControl i_UserControl, FBAdapter i_FBAdapter)
        {
            LoadMap(i_UserControl, i_FBAdapter);
        }

        internal PointLatLng getLatLong(PointD i_location)
        {
            PointLatLng coordinates;
            coordinates = new PointLatLng(i_location.X, i_location.Y);

            return coordinates;
        }
    }

    class GreatMap : Map
    {
        private GMapOverlay m_MarkersOverlay;
        private GMapControl m_GMapControl;

        internal GreatMap()
        {
            m_GMapControl = new GMapControl();
        }

        internal override PointLatLng Position
        {
            get
            {
                return m_GMapControl.Position;
            }

            set
            {
                m_GMapControl.Position = value;
            }
        }

        internal override UserControl MapControl
        {
            get
            {
                return m_GMapControl;
            }
        }

        internal override void Initialize(Int32 i_LocationX, Int32 i_LocationY, Int32 i_Width, Int32 i_Height)
        {
            m_GMapControl.Bearing = 0F;
            m_GMapControl.CanDragMap = true;
            m_GMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            m_GMapControl.GrayScaleMode = false;
            m_GMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            m_GMapControl.LevelsKeepInMemmory = 5;
            m_GMapControl.Location = new System.Drawing.Point(i_LocationX, i_LocationY);
            m_GMapControl.MarkersEnabled = true;
            m_GMapControl.MaxZoom = 30;
            m_GMapControl.MinZoom = 1;
            m_GMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            m_GMapControl.Name = "gMapControl";
            m_GMapControl.NegativeMode = false;
            m_GMapControl.PolygonsEnabled = false;
            m_GMapControl.RetryLoadTile = 0;
            m_GMapControl.RoutesEnabled = false;
            m_GMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            m_GMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            m_GMapControl.ShowTileGridLines = false;
            m_GMapControl.Size = new System.Drawing.Size(i_Width, i_Height);
            m_GMapControl.TabIndex = 7;
            m_GMapControl.Zoom = 0D;
        }

        internal override void LoadMap(UserControl i_UserControl, FBAdapter i_FBAdapter)
        {
            GMapControl gMapControl = i_UserControl as GMapControl;

            gMapControl.Invoke(new Action(() => gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance));
            gMapControl.Invoke(new Action(() => gMapControl.SetPositionByKeywords("dubnov, Tel Aviv, Israel")));
            m_MarkersOverlay = new GMapOverlay("markers");
            foreach (object fbEvent in i_FBAdapter.Events)
            {
                if (i_FBAdapter.HasLocationEvent(fbEvent))
                {
                    PointLatLng point = getLatLong(i_FBAdapter.GetLatLong(fbEvent));
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        point,
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small);
                    marker.ToolTipText = i_FBAdapter.GetEventName(fbEvent);
                    m_MarkersOverlay.Markers.Add(marker);
                }
            }

            gMapControl.Invoke(new Action(() => gMapControl.Overlays.Add(m_MarkersOverlay)));
            gMapControl.Invoke(new Action(() => gMapControl.ZoomAndCenterMarkers(null)));
        }

        internal override void ZoomAndCenterMarkers()
        {
            m_GMapControl.ZoomAndCenterMarkers(null);
        }
    }
}
