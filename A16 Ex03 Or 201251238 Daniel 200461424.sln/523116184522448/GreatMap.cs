using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace _523116184522448
{
    class GreatMap : Map
    {
        private GMapOverlay m_MarkersOverlay;
        private GMapControl m_GMapControl;

        internal GreatMap()
        {
            m_GMapControl = new GMapControl();
        }

        internal override void SetPosition(PointD i_Location)
        {
            m_GMapControl.Position = new PointLatLng(i_Location.X, i_Location.Y);
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

        internal override void SetControl(UserControl i_UserControl)
        {
            m_GMapControl = i_UserControl as GMapControl;
        }

        internal override void ClearMap()
        {
            m_GMapControl.Overlays.Clear();
        }

        internal override void AddEvents(FBAdapter i_FBAdapter, IEnumerable<object> i_Events)
        {
            m_GMapControl.Invoke(new Action(() => m_GMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance));
            m_GMapControl.Invoke(new Action(() => m_GMapControl.SetPositionByKeywords("dubnov, Tel Aviv, Israel")));
            m_MarkersOverlay = new GMapOverlay("markers");
            foreach (object fbEvent in i_Events)
            {
                if (i_FBAdapter.HasLocationEvent(fbEvent))
                {
                    //PointLatLng point = GetPosition(i_FBAdapter.GetLatLong(fbEvent));
                    PointD eventLocation = i_FBAdapter.GetLatLong(fbEvent);
                    PointLatLng point = new PointLatLng(eventLocation.X, eventLocation.Y);
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        point,
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small);
                    marker.ToolTipText = i_FBAdapter.GetEventName(fbEvent);
                    m_MarkersOverlay.Markers.Add(marker);
                }
            }
        }

        internal override void DrawMap()
        {
            m_GMapControl.Invoke(new Action(() => m_GMapControl.Overlays.Add(m_MarkersOverlay)));
            m_GMapControl.Invoke(new Action(() => m_GMapControl.ZoomAndCenterMarkers(null)));
        }

        internal override void ZoomAndCenterMarkers()
        {
            m_GMapControl.ZoomAndCenterMarkers(null);
        }
    }
}
