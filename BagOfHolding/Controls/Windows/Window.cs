﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BagOfHolding
{
    public partial class Window : UserControl
    {
        string type;
        bool initialized;
        List<UserControl> pendingControls;

       delegate void Drag();
        Point dragStartPos;

        bool windowDrag;

        public Window(string t) {
            type = t;
            pendingControls = new List<UserControl>();
        }

        public void open() {
            if(!initialized)
                startup();

            Show();
            Visible = true;
            BringToFront();
            IsAccessible = true;
        }

        private void startup() {
            initialized = true;
            InitializeComponent();

            foreach(UserControl c in pendingControls)
                addControl(c);
            pendingControls.Clear();

            if(type.Equals("char")) {
                Location = new Point(100, 100);
                Size = new Size(new Point(832, 580));
            }
            else if(type.Equals("inv")) {
                Location = new Point(30, 30);
                Size = new Size(new Point(1250, 680));
            }
            else if(type.Equals("spellbook")) {
                Location = new Point(50, 50);
                Size = new Size(new Point(950, 700));
            }
            else if(type.Equals("party")) {
                Location = new Point(20, 20);
                Size = new Size(new Point(1200, 633));
            }
        }

        public void addControl(UserControl cont) {
            if(initialized)
                main_panel.Controls.Add(cont);
            else
                pendingControls.Add(cont);
        }

        private void dragWindow(Point m) {
            Location = new Point(Location.X + (m.X - dragStartPos.X), Location.Y + (m.Y - dragStartPos.Y));
        }

        #region Event Handlers

        private void back_panel_MouseDown(object sender, MouseEventArgs eArgs) {
            BringToFront();
            windowDrag = true;
            dragStartPos = eArgs.Location;
        }

        private void back_panel_MouseUp(object sender, MouseEventArgs eArgs) {
            windowDrag = false;
        }

        private void back_panel_MouseMove(object sender, MouseEventArgs eArgs) {
            if(windowDrag) 
                dragWindow(eArgs.Location);
        }

        private void back_panel_MouseEnter(object sender, EventArgs eArgs) {
            BringToFront();
        }

        private void back_panel_MouseLeave(object sender, EventArgs eArgs) {
            if(windowDrag) 
                dragWindow(back_panel.PointToClient(MousePosition));
        }

        private void closeB_Click(object sender, EventArgs eArgs) {
            Visible = false;
        }

        private void back_panel_MouseDoubleClick(object sender, MouseEventArgs e) {
            BringToFront();
        }
        #endregion
    }
}
