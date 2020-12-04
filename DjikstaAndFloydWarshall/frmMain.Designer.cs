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
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveConnection = new System.Windows.Forms.Button();
            this.lstCityConnections = new System.Windows.Forms.ListBox();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblShortestPath = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDijkstraResult = new System.Windows.Forms.Label();
            this.lblFloydWarshal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lstAllConnections = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateCities = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveCity = new System.Windows.Forms.Button();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
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
            this.gViewer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gViewer.ForwardEnabled = false;
            this.gViewer.Graph = null;
            this.gViewer.InsertingEdge = false;
            this.gViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer.LayoutEditingEnabled = true;
            this.gViewer.Location = new System.Drawing.Point(24, 430);
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
            this.gViewer.Size = new System.Drawing.Size(888, 647);
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
            this.pnlConnections.Controls.Add(this.label5);
            this.pnlConnections.Controls.Add(this.btnRemoveConnection);
            this.pnlConnections.Controls.Add(this.lstCityConnections);
            this.pnlConnections.Controls.Add(this.btnAddConnection);
            this.pnlConnections.Controls.Add(this.label3);
            this.pnlConnections.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConnections.Location = new System.Drawing.Point(469, 5);
            this.pnlConnections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlConnections.Name = "pnlConnections";
            this.pnlConnections.Size = new System.Drawing.Size(441, 405);
            this.pnlConnections.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Зв\'язки";
            // 
            // btnRemoveConnection
            // 
            this.btnRemoveConnection.Enabled = false;
            this.btnRemoveConnection.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveConnection.Location = new System.Drawing.Point(9, 336);
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
            this.lstCityConnections.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCityConnections.FormattingEnabled = true;
            this.lstCityConnections.ItemHeight = 21;
            this.lstCityConnections.Items.AddRange(new object[] {
            "Житомир - 130км"});
            this.lstCityConnections.Location = new System.Drawing.Point(178, 40);
            this.lstCityConnections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCityConnections.Name = "lstCityConnections";
            this.lstCityConnections.Size = new System.Drawing.Size(252, 340);
            this.lstCityConnections.TabIndex = 45;
            this.lstCityConnections.SelectedIndexChanged += new System.EventHandler(this.lstCityConnections_SelectedIndexChanged);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, -26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Наявні зв\'язки";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(1244, 187);
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
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(938, 599);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Алгоритм Флойда-Уоршелла";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1006, 556);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Алгоритм Дейкстри";
            // 
            // lblShortestPath
            // 
            this.lblShortestPath.AutoSize = true;
            this.lblShortestPath.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortestPath.Location = new System.Drawing.Point(1107, 504);
            this.lblShortestPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShortestPath.Name = "lblShortestPath";
            this.lblShortestPath.Size = new System.Drawing.Size(327, 21);
            this.lblShortestPath.TabIndex = 23;
            this.lblShortestPath.Text = "Київ -> Житомир -> Хмельницький (353км)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(933, 504);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Найкоротший шлях: ";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1294, 74);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 29);
            this.comboBox2.TabIndex = 26;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1294, 129);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(180, 29);
            this.comboBox3.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1240, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Розрахувати найкоротший шлях";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1249, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "з ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1249, 134);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "до";
            // 
            // lblDijkstraResult
            // 
            this.lblDijkstraResult.AutoSize = true;
            this.lblDijkstraResult.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraResult.Location = new System.Drawing.Point(1257, 556);
            this.lblDijkstraResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDijkstraResult.Name = "lblDijkstraResult";
            this.lblDijkstraResult.Size = new System.Drawing.Size(57, 21);
            this.lblDijkstraResult.TabIndex = 32;
            this.lblDijkstraResult.Text = "100мс";
            // 
            // lblFloydWarshal
            // 
            this.lblFloydWarshal.AutoSize = true;
            this.lblFloydWarshal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloydWarshal.Location = new System.Drawing.Point(1257, 599);
            this.lblFloydWarshal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloydWarshal.Name = "lblFloydWarshal";
            this.lblFloydWarshal.Size = new System.Drawing.Size(57, 21);
            this.lblFloydWarshal.TabIndex = 33;
            this.lblFloydWarshal.Text = "150мс";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1144, 448);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 21);
            this.label14.TabIndex = 34;
            this.label14.Text = "Результат";
            // 
            // lstAllConnections
            // 
            this.lstAllConnections.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllConnections.FormattingEnabled = true;
            this.lstAllConnections.ItemHeight = 21;
            this.lstAllConnections.Location = new System.Drawing.Point(917, 45);
            this.lstAllConnections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAllConnections.Name = "lstAllConnections";
            this.lstAllConnections.Size = new System.Drawing.Size(312, 340);
            this.lstAllConnections.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerateCities);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRemoveCity);
            this.panel1.Controls.Add(this.lstCity);
            this.panel1.Controls.Add(this.btnAddCity);
            this.panel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 405);
            this.panel1.TabIndex = 38;
            // 
            // btnGenerateCities
            // 
            this.btnGenerateCities.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCities.Location = new System.Drawing.Point(0, 338);
            this.btnGenerateCities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateCities.Name = "btnGenerateCities";
            this.btnGenerateCities.Size = new System.Drawing.Size(168, 45);
            this.btnGenerateCities.TabIndex = 40;
            this.btnGenerateCities.Text = "Автозаповнення";
            this.btnGenerateCities.UseVisualStyleBackColor = true;
            this.btnGenerateCities.Click += new System.EventHandler(this.btnGenerateCities_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Міста";
            // 
            // btnRemoveCity
            // 
            this.btnRemoveCity.Enabled = false;
            this.btnRemoveCity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCity.Location = new System.Drawing.Point(0, 118);
            this.btnRemoveCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveCity.Name = "btnRemoveCity";
            this.btnRemoveCity.Size = new System.Drawing.Size(158, 44);
            this.btnRemoveCity.TabIndex = 38;
            this.btnRemoveCity.Text = "Видалити";
            this.btnRemoveCity.UseVisualStyleBackColor = true;
            this.btnRemoveCity.Click += new System.EventHandler(this.btnRemoveCity_Click);
            // 
            // lstCity
            // 
            this.lstCity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 21;
            this.lstCity.Items.AddRange(new object[] {
            "Київ",
            "Житомир",
            "Хмельницький"});
            this.lstCity.Location = new System.Drawing.Point(177, 40);
            this.lstCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(252, 340);
            this.lstCity.TabIndex = 37;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.lstCity_SelectedIndexChanged);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCity.Location = new System.Drawing.Point(0, 40);
            this.btnAddCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(159, 44);
            this.btnAddCity.TabIndex = 36;
            this.btnAddCity.Text = "Додати";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1018, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 21);
            this.label15.TabIndex = 48;
            this.label15.Text = "Всі зв\'язки";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 1148);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstAllConnections);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblFloydWarshal);
            this.Controls.Add(this.lblDijkstraResult);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblShortestPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlConnections);
            this.Controls.Add(this.gViewer);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblShortestPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDijkstraResult;
        private System.Windows.Forms.Label lblFloydWarshal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveConnection;
        private System.Windows.Forms.ListBox lstCityConnections;
        private System.Windows.Forms.Button btnAddConnection;
        private System.Windows.Forms.ListBox lstAllConnections;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateCities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveCity;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Label label15;
    }
}
