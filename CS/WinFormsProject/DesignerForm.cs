﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;

namespace WinFormsProject {
    public partial class DesignerForm : Form {
        public DesignerForm() {
            InitializeComponent();
        }

        public void ConfigureDataConnection(object sender, DevExpress.DataAccess.ConfigureDataConnectionEventArgs e) {
            switch (e.ConnectionName)
            {
                case "nwindConnection":
                    Access97ConnectionParameters access = e.ConnectionParameters as Access97ConnectionParameters;
                    if (access != null)
                        access.FileName = @"../../../nwind.mdb";
                    break;                
            }
        }

        private void ShowViewer_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewerForm vf = new ViewerForm( dashboardDesigner1.DashboardFileName  );
            vf.ShowDialog();
        }

        private void DesignerForm_Load(object sender, EventArgs e)
        {
            dashboardDesigner1.LoadDashboard(@"../../../Invoices.xml");
        }
    }
}
