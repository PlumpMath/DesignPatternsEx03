using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Facebook;

namespace _523116184522448
{
    public partial class FormMain : Form
    {
        private FormEventImages m_ImagesFromEventsFrom;
        private FormEventLocations m_EventLocationForm;
        private FBAdapter m_FBAdapter;

        public FormMain()
        {
            m_FBAdapter = FBAdapter.Instance;
            InitializeComponent();
            buttonEventsImages.Enabled = false;
            buttonEventsLocations.Enabled = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = false;
            isLoggedIn = m_FBAdapter.Login();
            if (isLoggedIn)
            {
                fetchUserInfo();
                buttonLogin.Enabled = false;
                buttonEventsImages.Enabled = true;
                buttonEventsLocations.Enabled = true;
            }
            else
            {
                MessageBox.Show(m_FBAdapter.LoggedInError());
            }
        }

        private void fetchUserInfo()
        {
            userInfoBindingSource.DataSource = m_FBAdapter.UserInfo;
            this.bioTextBox.Visible = true;
            this.bioLabel.Visible = true;
        }

        private void buttonEventLocations_Click(object sender, EventArgs e)
        {
            m_EventLocationForm = new FormEventLocations();
            m_EventLocationForm.FBUtilities = m_FBAdapter;
            m_EventLocationForm.Show();
        }

        private void buttonEventImages_Click(object sender, EventArgs e)
        {
            m_ImagesFromEventsFrom = new FormEventImages();
            m_ImagesFromEventsFrom.FBUtilities = m_FBAdapter;
            m_ImagesFromEventsFrom.Show();
        }
    }
}
