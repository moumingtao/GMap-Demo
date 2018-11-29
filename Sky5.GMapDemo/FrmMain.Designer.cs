namespace Sky5.GMapDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.pnlMenu = new Sky5.WinForms.Panel();
            this.xPanderPanelList1 = new Sky5.WinForms.XPanderPanelList();
            this.pnlPropertyView = new Sky5.WinForms.XPanderPanel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.xPanderPanel2 = new Sky5.WinForms.XPanderPanel();
            this.xPanderPanel3 = new Sky5.WinForms.XPanderPanel();
            this.pnlMenu.SuspendLayout();
            this.xPanderPanelList1.SuspendLayout();
            this.pnlPropertyView.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(518, 450);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.pnlMenu.CaptionHeight = 27;
            this.pnlMenu.Controls.Add(this.xPanderPanelList1);
            this.pnlMenu.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlMenu.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlMenu.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.pnlMenu.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlMenu.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnlMenu.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnlMenu.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.pnlMenu.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlMenu.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.Image = null;
            this.pnlMenu.Location = new System.Drawing.Point(518, 0);
            this.pnlMenu.MinimumSize = new System.Drawing.Size(27, 27);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.PanelStyle = Sky5.WinForms.PanelStyle.Office2007;
            this.pnlMenu.ShowExpandIcon = true;
            this.pnlMenu.Size = new System.Drawing.Size(282, 450);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Text = "菜单";
            this.pnlMenu.ToolTipTextCloseIcon = null;
            this.pnlMenu.ToolTipTextExpandIconPanelCollapsed = null;
            this.pnlMenu.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // xPanderPanelList1
            // 
            this.xPanderPanelList1.CaptionStyle = Sky5.WinForms.CaptionStyle.Flat;
            this.xPanderPanelList1.Controls.Add(this.pnlPropertyView);
            this.xPanderPanelList1.Controls.Add(this.xPanderPanel2);
            this.xPanderPanelList1.Controls.Add(this.xPanderPanel3);
            this.xPanderPanelList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanderPanelList1.GradientBackground = System.Drawing.Color.Empty;
            this.xPanderPanelList1.Location = new System.Drawing.Point(0, 28);
            this.xPanderPanelList1.Name = "xPanderPanelList1";
            this.xPanderPanelList1.PanelColors = null;
            this.xPanderPanelList1.PanelStyle = Sky5.WinForms.PanelStyle.Office2007;
            this.xPanderPanelList1.ShowExpandIcon = true;
            this.xPanderPanelList1.Size = new System.Drawing.Size(282, 421);
            this.xPanderPanelList1.TabIndex = 0;
            this.xPanderPanelList1.Text = "xPanderPanelList1";
            // 
            // pnlPropertyView
            // 
            this.pnlPropertyView.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.pnlPropertyView.Controls.Add(this.propertyGrid1);
            this.pnlPropertyView.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPropertyView.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlPropertyView.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.pnlPropertyView.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.pnlPropertyView.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.pnlPropertyView.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.pnlPropertyView.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.pnlPropertyView.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlPropertyView.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.pnlPropertyView.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlPropertyView.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.pnlPropertyView.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.pnlPropertyView.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.pnlPropertyView.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnlPropertyView.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnlPropertyView.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnlPropertyView.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.pnlPropertyView.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlPropertyView.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlPropertyView.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlPropertyView.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.pnlPropertyView.Expand = true;
            this.pnlPropertyView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPropertyView.Image = null;
            this.pnlPropertyView.Name = "pnlPropertyView";
            this.pnlPropertyView.PanelStyle = Sky5.WinForms.PanelStyle.Office2007;
            this.pnlPropertyView.Size = new System.Drawing.Size(282, 371);
            this.pnlPropertyView.TabIndex = 0;
            this.pnlPropertyView.Text = "地图属性";
            this.pnlPropertyView.ToolTipTextCloseIcon = null;
            this.pnlPropertyView.ToolTipTextExpandIconPanelCollapsed = null;
            this.pnlPropertyView.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(1, 25);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(280, 346);
            this.propertyGrid1.TabIndex = 0;
            // 
            // xPanderPanel2
            // 
            this.xPanderPanel2.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.xPanderPanel2.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanel2.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xPanderPanel2.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanel2.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xPanderPanel2.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanel2.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanel2.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xPanderPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.Image = null;
            this.xPanderPanel2.Name = "xPanderPanel2";
            this.xPanderPanel2.PanelStyle = Sky5.WinForms.PanelStyle.Office2007;
            this.xPanderPanel2.Size = new System.Drawing.Size(282, 25);
            this.xPanderPanel2.TabIndex = 1;
            this.xPanderPanel2.Text = "xPanderPanel2";
            this.xPanderPanel2.ToolTipTextCloseIcon = null;
            this.xPanderPanel2.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel2.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // xPanderPanel3
            // 
            this.xPanderPanel3.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.xPanderPanel3.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanel3.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xPanderPanel3.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xPanderPanel3.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xPanderPanel3.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xPanderPanel3.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanel3.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xPanderPanel3.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanel3.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.xPanderPanel3.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.xPanderPanel3.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanel3.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanel3.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xPanderPanel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.Image = null;
            this.xPanderPanel3.Name = "xPanderPanel3";
            this.xPanderPanel3.PanelStyle = Sky5.WinForms.PanelStyle.Office2007;
            this.xPanderPanel3.Size = new System.Drawing.Size(282, 25);
            this.xPanderPanel3.TabIndex = 2;
            this.xPanderPanel3.Text = "xPanderPanel3";
            this.xPanderPanel3.ToolTipTextCloseIcon = null;
            this.xPanderPanel3.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel3.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.xPanderPanelList1.ResumeLayout(false);
            this.pnlPropertyView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private WinForms.Panel pnlMenu;
        private WinForms.XPanderPanelList xPanderPanelList1;
        private WinForms.XPanderPanel pnlPropertyView;
        private WinForms.XPanderPanel xPanderPanel2;
        private WinForms.XPanderPanel xPanderPanel3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

