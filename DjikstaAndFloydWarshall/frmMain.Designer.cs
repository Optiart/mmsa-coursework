﻿
namespace DjikstaAndFloydWarshall
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.pnlConnections = new System.Windows.Forms.Panel();
            this.lblConnectionCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveConnection = new System.Windows.Forms.Button();
            this.lstCityConnections = new System.Windows.Forms.ListBox();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCityFrom = new System.Windows.Forms.ComboBox();
            this.cmbCityTo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFloydWarshal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lstAllConnections = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCityCount = new System.Windows.Forms.Label();
            this.btnGenerateCitiesLoad = new System.Windows.Forms.Button();
            this.btnGenerateCitiesDemo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveCity = new System.Windows.Forms.Button();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDijkstraShortestPath = new System.Windows.Forms.TextBox();
            this.lblDijkstraShortestDistance = new System.Windows.Forms.Label();
            this.lblGraphError = new System.Windows.Forms.Label();
            this.lblAllConnectionsCount = new System.Windows.Forms.Label();
            this.lblDijkstraResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFloydWarshalShortestDistance = new System.Windows.Forms.Label();
            this.txtFloydWarshalShortestPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlConnections.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gViewer
            // 
            this.gViewer.ArrowheadLength = 10D;
            this.gViewer.AsyncLayout = false;
            this.gViewer.AutoScroll = true;
            this.gViewer.BackwardEnabled = false;
            this.gViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gViewer.BuildHitTree = true;
            this.gViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer.EdgeInsertButtonVisible = true;
            this.gViewer.FileName = "";
            this.gViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gViewer.ForwardEnabled = false;
            this.gViewer.Graph = null;
            this.gViewer.InsertingEdge = false;
            this.gViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer.LayoutEditingEnabled = true;
            this.gViewer.Location = new System.Drawing.Point(24, 448);
            this.gViewer.LooseOffsetForRouting = 0.25D;
            this.gViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gViewer.MouseHitDistance = 0.05D;
            this.gViewer.Name = "gViewer";
            this.gViewer.NavigationVisible = true;
            this.gViewer.NeedToCalculateLayout = true;
            this.gViewer.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer.PaddingForEdgeRouting = 8D;
            this.gViewer.PanButtonPressed = false;
            this.gViewer.SaveAsImageEnabled = true;
            this.gViewer.SaveAsMsaglEnabled = true;
            this.gViewer.SaveButtonVisible = true;
            this.gViewer.SaveGraphButtonVisible = true;
            this.gViewer.SaveInVectorFormatEnabled = true;
            this.gViewer.Size = new System.Drawing.Size(888, 629);
            this.gViewer.TabIndex = 3;
            this.gViewer.TightOffsetForRouting = 0.125D;
            this.gViewer.ToolBarIsVisible = true;
            this.gViewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer.Transform")));
            this.gViewer.UndoRedoButtonsVisible = true;
            this.gViewer.WindowZoomButtonPressed = false;
            this.gViewer.ZoomF = 1D;
            this.gViewer.ZoomWindowThreshold = 0.05D;
            // 
            // pnlConnections
            // 
            this.pnlConnections.Controls.Add(this.lblConnectionCount);
            this.pnlConnections.Controls.Add(this.label5);
            this.pnlConnections.Controls.Add(this.btnRemoveConnection);
            this.pnlConnections.Controls.Add(this.lstCityConnections);
            this.pnlConnections.Controls.Add(this.btnAddConnection);
            this.pnlConnections.Controls.Add(this.label3);
            this.pnlConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConnections.Location = new System.Drawing.Point(469, 5);
            this.pnlConnections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlConnections.Name = "pnlConnections";
            this.pnlConnections.Size = new System.Drawing.Size(441, 405);
            this.pnlConnections.TabIndex = 12;
            // 
            // lblConnectionCount
            // 
            this.lblConnectionCount.AutoSize = true;
            this.lblConnectionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionCount.Location = new System.Drawing.Point(240, 14);
            this.lblConnectionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionCount.Name = "lblConnectionCount";
            this.lblConnectionCount.Size = new System.Drawing.Size(46, 20);
            this.lblConnectionCount.TabIndex = 43;
            this.lblConnectionCount.Text = "(100)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Зв\'язки";
            // 
            // btnRemoveConnection
            // 
            this.btnRemoveConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveConnection.Enabled = false;
            this.btnRemoveConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveConnection.Location = new System.Drawing.Point(9, 106);
            this.btnRemoveConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveConnection.Name = "btnRemoveConnection";
            this.btnRemoveConnection.Size = new System.Drawing.Size(152, 44);
            this.btnRemoveConnection.TabIndex = 46;
            this.btnRemoveConnection.Text = "Видалити";
            this.btnRemoveConnection.UseVisualStyleBackColor = true;
            this.btnRemoveConnection.Click += new System.EventHandler(this.btnRemoveConnection_Click);
            // 
            // lstCityConnections
            // 
            this.lstCityConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCityConnections.FormattingEnabled = true;
            this.lstCityConnections.ItemHeight = 20;
            this.lstCityConnections.Items.AddRange(new object[] {
            "Житомир - 130км"});
            this.lstCityConnections.Location = new System.Drawing.Point(178, 40);
            this.lstCityConnections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCityConnections.Name = "lstCityConnections";
            this.lstCityConnections.Size = new System.Drawing.Size(252, 324);
            this.lstCityConnections.TabIndex = 45;
            this.lstCityConnections.SelectedIndexChanged += new System.EventHandler(this.lstCityConnections_SelectedIndexChanged);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConnection.Location = new System.Drawing.Point(9, 40);
            this.btnAddConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(152, 44);
            this.btnAddConnection.TabIndex = 44;
            this.btnAddConnection.Text = "Додати";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, -26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Наявні зв\'язки";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(1265, 323);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 63);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(913, 778);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Алгоритм Флойда-Уоршелла";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(924, 515);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Найкоротший шлях: ";
            // 
            // cmbCityFrom
            // 
            this.cmbCityFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCityFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCityFrom.FormattingEnabled = true;
            this.cmbCityFrom.Location = new System.Drawing.Point(1294, 74);
            this.cmbCityFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCityFrom.Name = "cmbCityFrom";
            this.cmbCityFrom.Size = new System.Drawing.Size(180, 28);
            this.cmbCityFrom.TabIndex = 26;
            this.cmbCityFrom.Click += new System.EventHandler(this.cmbCityFrom_Click);
            // 
            // cmbCityTo
            // 
            this.cmbCityTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCityTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCityTo.FormattingEnabled = true;
            this.cmbCityTo.Location = new System.Drawing.Point(1294, 129);
            this.cmbCityTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCityTo.Name = "cmbCityTo";
            this.cmbCityTo.Size = new System.Drawing.Size(180, 28);
            this.cmbCityTo.TabIndex = 27;
            this.cmbCityTo.Click += new System.EventHandler(this.cmbCityTo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1240, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Розрахувати найкоротший шлях";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1249, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "з ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1249, 134);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "до";
            // 
            // lblFloydWarshal
            // 
            this.lblFloydWarshal.AutoSize = true;
            this.lblFloydWarshal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloydWarshal.Location = new System.Drawing.Point(1261, 778);
            this.lblFloydWarshal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloydWarshal.Name = "lblFloydWarshal";
            this.lblFloydWarshal.Size = new System.Drawing.Size(55, 20);
            this.lblFloydWarshal.TabIndex = 33;
            this.lblFloydWarshal.Text = "150мс";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1144, 448);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Результат";
            // 
            // lstAllConnections
            // 
            this.lstAllConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllConnections.FormattingEnabled = true;
            this.lstAllConnections.ItemHeight = 20;
            this.lstAllConnections.Location = new System.Drawing.Point(917, 45);
            this.lstAllConnections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAllConnections.Name = "lstAllConnections";
            this.lstAllConnections.Size = new System.Drawing.Size(312, 324);
            this.lstAllConnections.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lblCityCount);
            this.panel1.Controls.Add(this.btnGenerateCitiesLoad);
            this.panel1.Controls.Add(this.btnGenerateCitiesDemo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRemoveCity);
            this.panel1.Controls.Add(this.lstCity);
            this.panel1.Controls.Add(this.btnAddCity);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 405);
            this.panel1.TabIndex = 38;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(4, 332);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 32);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "Стерти всі дані";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCityCount
            // 
            this.lblCityCount.AutoSize = true;
            this.lblCityCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityCount.Location = new System.Drawing.Point(229, 14);
            this.lblCityCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCityCount.Name = "lblCityCount";
            this.lblCityCount.Size = new System.Drawing.Size(46, 20);
            this.lblCityCount.TabIndex = 42;
            this.lblCityCount.Text = "(100)";
            // 
            // btnGenerateCitiesLoad
            // 
            this.btnGenerateCitiesLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateCitiesLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCitiesLoad.Location = new System.Drawing.Point(4, 252);
            this.btnGenerateCitiesLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateCitiesLoad.Name = "btnGenerateCitiesLoad";
            this.btnGenerateCitiesLoad.Size = new System.Drawing.Size(168, 62);
            this.btnGenerateCitiesLoad.TabIndex = 41;
            this.btnGenerateCitiesLoad.Text = "Автозаповнення (Load)";
            this.btnGenerateCitiesLoad.UseVisualStyleBackColor = true;
            this.btnGenerateCitiesLoad.Click += new System.EventHandler(this.btnGenerateCitiesLoad_Click);
            // 
            // btnGenerateCitiesDemo
            // 
            this.btnGenerateCitiesDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateCitiesDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCitiesDemo.Location = new System.Drawing.Point(4, 170);
            this.btnGenerateCitiesDemo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateCitiesDemo.Name = "btnGenerateCitiesDemo";
            this.btnGenerateCitiesDemo.Size = new System.Drawing.Size(168, 62);
            this.btnGenerateCitiesDemo.TabIndex = 40;
            this.btnGenerateCitiesDemo.Text = "Автозаповнення (Demo)";
            this.btnGenerateCitiesDemo.UseVisualStyleBackColor = true;
            this.btnGenerateCitiesDemo.Click += new System.EventHandler(this.btnGenerateCities_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Міста";
            // 
            // btnRemoveCity
            // 
            this.btnRemoveCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCity.Enabled = false;
            this.btnRemoveCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCity.Location = new System.Drawing.Point(4, 106);
            this.btnRemoveCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveCity.Name = "btnRemoveCity";
            this.btnRemoveCity.Size = new System.Drawing.Size(168, 44);
            this.btnRemoveCity.TabIndex = 38;
            this.btnRemoveCity.Text = "Видалити";
            this.btnRemoveCity.UseVisualStyleBackColor = true;
            this.btnRemoveCity.Click += new System.EventHandler(this.btnRemoveCity_Click);
            // 
            // lstCity
            // 
            this.lstCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 20;
            this.lstCity.Items.AddRange(new object[] {
            "Київ",
            "Житомир",
            "Хмельницький"});
            this.lstCity.Location = new System.Drawing.Point(177, 40);
            this.lstCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(252, 324);
            this.lstCity.TabIndex = 37;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.lstCity_SelectedIndexChanged);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCity.Location = new System.Drawing.Point(4, 40);
            this.btnAddCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(168, 44);
            this.btnAddCity.TabIndex = 36;
            this.btnAddCity.Text = "Додати";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(918, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 48;
            this.label15.Text = "Всі зв\'язки";
            // 
            // txtDijkstraShortestPath
            // 
            this.txtDijkstraShortestPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDijkstraShortestPath.Location = new System.Drawing.Point(1096, 515);
            this.txtDijkstraShortestPath.Multiline = true;
            this.txtDijkstraShortestPath.Name = "txtDijkstraShortestPath";
            this.txtDijkstraShortestPath.ReadOnly = true;
            this.txtDijkstraShortestPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDijkstraShortestPath.Size = new System.Drawing.Size(399, 241);
            this.txtDijkstraShortestPath.TabIndex = 49;
            // 
            // lblDijkstraShortestDistance
            // 
            this.lblDijkstraShortestDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraShortestDistance.Location = new System.Drawing.Point(924, 545);
            this.lblDijkstraShortestDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDijkstraShortestDistance.Name = "lblDijkstraShortestDistance";
            this.lblDijkstraShortestDistance.Size = new System.Drawing.Size(152, 21);
            this.lblDijkstraShortestDistance.TabIndex = 50;
            this.lblDijkstraShortestDistance.Text = "(350 км)";
            this.lblDijkstraShortestDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGraphError
            // 
            this.lblGraphError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphError.ForeColor = System.Drawing.Color.Red;
            this.lblGraphError.Location = new System.Drawing.Point(24, 422);
            this.lblGraphError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGraphError.Name = "lblGraphError";
            this.lblGraphError.Size = new System.Drawing.Size(888, 21);
            this.lblGraphError.TabIndex = 51;
            this.lblGraphError.Text = "Граф не буде відображений - занадто багато зв\'язків";
            this.lblGraphError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAllConnectionsCount
            // 
            this.lblAllConnectionsCount.AutoSize = true;
            this.lblAllConnectionsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllConnectionsCount.Location = new System.Drawing.Point(1006, 19);
            this.lblAllConnectionsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllConnectionsCount.Name = "lblAllConnectionsCount";
            this.lblAllConnectionsCount.Size = new System.Drawing.Size(46, 20);
            this.lblAllConnectionsCount.TabIndex = 48;
            this.lblAllConnectionsCount.Text = "(100)";
            // 
            // lblDijkstraResult
            // 
            this.lblDijkstraResult.AutoSize = true;
            this.lblDijkstraResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraResult.Location = new System.Drawing.Point(1261, 485);
            this.lblDijkstraResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDijkstraResult.Name = "lblDijkstraResult";
            this.lblDijkstraResult.Size = new System.Drawing.Size(55, 20);
            this.lblDijkstraResult.TabIndex = 53;
            this.lblDijkstraResult.Text = "100мс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(924, 485);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Алгоритм Дейкстри";
            // 
            // lblFloydWarshalShortestDistance
            // 
            this.lblFloydWarshalShortestDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloydWarshalShortestDistance.Location = new System.Drawing.Point(924, 837);
            this.lblFloydWarshalShortestDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloydWarshalShortestDistance.Name = "lblFloydWarshalShortestDistance";
            this.lblFloydWarshalShortestDistance.Size = new System.Drawing.Size(152, 21);
            this.lblFloydWarshalShortestDistance.TabIndex = 56;
            this.lblFloydWarshalShortestDistance.Text = "(350 км)";
            this.lblFloydWarshalShortestDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFloydWarshalShortestPath
            // 
            this.txtFloydWarshalShortestPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFloydWarshalShortestPath.Location = new System.Drawing.Point(1096, 807);
            this.txtFloydWarshalShortestPath.Multiline = true;
            this.txtFloydWarshalShortestPath.Name = "txtFloydWarshalShortestPath";
            this.txtFloydWarshalShortestPath.ReadOnly = true;
            this.txtFloydWarshalShortestPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFloydWarshalShortestPath.Size = new System.Drawing.Size(399, 241);
            this.txtFloydWarshalShortestPath.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(924, 807);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Найкоротший шлях: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 1148);
            this.Controls.Add(this.lblFloydWarshalShortestDistance);
            this.Controls.Add(this.txtFloydWarshalShortestPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDijkstraResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAllConnectionsCount);
            this.Controls.Add(this.lblGraphError);
            this.Controls.Add(this.lblDijkstraShortestDistance);
            this.Controls.Add(this.txtDijkstraShortestPath);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstAllConnections);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblFloydWarshal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCityTo);
            this.Controls.Add(this.cmbCityFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlConnections);
            this.Controls.Add(this.gViewer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Відстань між містами";
            this.pnlConnections.ResumeLayout(false);
            this.pnlConnections.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer;
        private System.Windows.Forms.Panel pnlConnections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCityFrom;
        private System.Windows.Forms.ComboBox cmbCityTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFloydWarshal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveConnection;
        private System.Windows.Forms.ListBox lstCityConnections;
        private System.Windows.Forms.Button btnAddConnection;
        private System.Windows.Forms.ListBox lstAllConnections;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateCitiesDemo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveCity;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGenerateCitiesLoad;
        private System.Windows.Forms.TextBox txtDijkstraShortestPath;
        private System.Windows.Forms.Label lblDijkstraShortestDistance;
        private System.Windows.Forms.Label lblGraphError;
        private System.Windows.Forms.Label lblConnectionCount;
        private System.Windows.Forms.Label lblCityCount;
        private System.Windows.Forms.Label lblAllConnectionsCount;
        private System.Windows.Forms.Label lblDijkstraResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFloydWarshalShortestDistance;
        private System.Windows.Forms.TextBox txtFloydWarshalShortestPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
    }
}

