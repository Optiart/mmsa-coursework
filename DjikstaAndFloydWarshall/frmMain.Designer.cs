
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.pnlConnections = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlConnections.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Київ",
            "Житомир",
            "Хмельницький"});
            this.listBox1.Location = new System.Drawing.Point(12, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 212);
            this.listBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gViewer1
            // 
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(528, 12);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(593, 401);
            this.gViewer1.TabIndex = 3;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // pnlConnections
            // 
            this.pnlConnections.Controls.Add(this.button4);
            this.pnlConnections.Controls.Add(this.label3);
            this.pnlConnections.Controls.Add(this.listBox2);
            this.pnlConnections.Controls.Add(this.button3);
            this.pnlConnections.Controls.Add(this.textBox1);
            this.pnlConnections.Controls.Add(this.label2);
            this.pnlConnections.Controls.Add(this.label1);
            this.pnlConnections.Controls.Add(this.comboBox1);
            this.pnlConnections.Location = new System.Drawing.Point(190, 45);
            this.pnlConnections.Name = "pnlConnections";
            this.pnlConnections.Size = new System.Drawing.Size(315, 234);
            this.pnlConnections.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(207, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 27);
            this.button4.TabIndex = 19;
            this.button4.Text = "Видалити";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, -16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Наявні зв\'язки";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Житомир - 130км"});
            this.listBox2.Location = new System.Drawing.Point(17, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(184, 134);
            this.listBox2.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 27);
            this.button3.TabIndex = 16;
            this.button3.Text = "З\'єднати";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Відстань (км)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "З\'єднати з";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(220, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Розрахувати";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Міста";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Зв\'язки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Алгоритм Флойда-Уоршелла";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Алгоритм Дейкстри";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(212, 517);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(223, 13);
            this.lblResult.TabIndex = 23;
            this.lblResult.Text = "Київ -> Житомир -> Хмельницький (353км)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Найкоротший шлях: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 358);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 26;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(72, 392);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Розрахувати найкоротший шлях";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "з ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "до";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "100мс";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(310, 576);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "150мс";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Результат";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 874);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pnlConnections);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmMain";
            this.Text = "Відстань між містами";
            this.pnlConnections.ResumeLayout(false);
            this.pnlConnections.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private System.Windows.Forms.Panel pnlConnections;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

