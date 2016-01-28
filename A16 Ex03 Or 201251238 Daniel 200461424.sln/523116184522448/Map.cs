using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _523116184522448
{
    abstract class Map
    {
        private UserEvents m_UserEvents;

        internal void LoadMap(UserControl i_UserControl, FBAdapter i_FBAdapter, IEnumerable<object> i_Events)
        {
            //Set control
            SetControl(i_UserControl);

            //Clear previous events
            ClearMap();

            //Add new events
            AddEvents(i_FBAdapter, i_Events);

            //Draw Map
            DrawMap();
        }

        internal abstract void SetControl(UserControl i_UserControl);
        internal abstract void ClearMap();
        internal abstract void AddEvents(FBAdapter i_FBAdapter, IEnumerable<object> i_Events);
        internal abstract void DrawMap();
        internal abstract void Initialize(Int32 i_LocationX, Int32 i_LocationY, Int32 i_Width, Int32 i_Height);
        internal abstract void SetPosition(PointD i_Location);
        internal abstract void ZoomAndCenterMarkers();
        internal abstract UserControl MapControl { get; }
    }
}
