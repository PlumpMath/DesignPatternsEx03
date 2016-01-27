using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace _523116184522448
{
    internal class UserEvents
    {
        private EventsStrategy m_EventsStrategy;
        private FBAdapter m_FBAdapter;

        internal UserEvents(FBAdapter i_FBAdapter)
        {
            m_FBAdapter = i_FBAdapter;
        }

        internal void SetEventsStrategy(EventsStrategy i_EventsStrategy)
        {
            this.m_EventsStrategy = i_EventsStrategy;
        }

        internal IEnumerable<Event> GetEvents()
        {
            return m_EventsStrategy.GetEvents(m_FBAdapter);
        }
    }

    internal interface EventsStrategy
    {
        IEnumerable<Event> GetEvents(FBAdapter i_FBAdapter);
    }

    internal class AllEvents : EventsStrategy
    {
        public IEnumerable<Event> GetEvents(FBAdapter i_FBAdapter)
        {
            return i_FBAdapter.Events;
        }
    }

    internal class EventsCreated : EventsStrategy
    {
        public IEnumerable<Event> GetEvents(FBAdapter i_FBAdapter)
        {
            return i_FBAdapter.EventsCreated;
        }
    }

    internal class EventsNotReplied : EventsStrategy
    {
        public IEnumerable<Event> GetEvents(FBAdapter i_FBAdapter)
        {
            return i_FBAdapter.EventsNotYetReplied;
        }
    }
}
