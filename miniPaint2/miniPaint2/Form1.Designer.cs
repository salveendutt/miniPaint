namespace miniPaint2
{
    partial class miniForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miniForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileLabel = new System.Windows.Forms.ToolStripLabel();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.loadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsLabel = new System.Windows.Forms.ToolStripLabel();
            this.brushButton = new System.Windows.Forms.ToolStripButton();
            this.eraserButton = new System.Windows.Forms.ToolStripButton();
            this.rectButton = new System.Windows.Forms.ToolStripButton();
            this.ellipseButton = new System.Windows.Forms.ToolStripButton();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.chosenColorLabel = new System.Windows.Forms.ToolStripLabel();
            this.currentColorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.LanguagesLabel = new System.Windows.Forms.ToolStripLabel();
            this.EnglishButton = new System.Windows.Forms.ToolStripButton();
            this.PolishButton = new System.Windows.Forms.ToolStripButton();
            this.UkranianButton = new System.Windows.Forms.ToolStripButton();
            this.RussianButton = new System.Windows.Forms.ToolStripButton();
            this.drawingArea = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.drawingArea.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLabel,
            this.saveButton,
            this.loadButton,
            this.toolStripSeparator1,
            this.toolsLabel,
            this.brushButton,
            this.eraserButton,
            this.rectButton,
            this.ellipseButton,
            this.clearButton,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.ComboBox1,
            this.toolStripSeparator3,
            this.chosenColorLabel,
            this.currentColorButton,
            this.toolStripSeparator4,
            this.LanguagesLabel,
            this.EnglishButton,
            this.PolishButton,
            this.UkranianButton,
            this.RussianButton});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // fileLabel
            // 
            resources.ApplyResources(this.fileLabel, "fileLabel");
            this.fileLabel.Name = "fileLabel";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Name = "saveButton";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            resources.ApplyResources(this.loadButton, "loadButton");
            this.loadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadButton.Name = "loadButton";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolsLabel
            // 
            resources.ApplyResources(this.toolsLabel, "toolsLabel");
            this.toolsLabel.Name = "toolsLabel";
            // 
            // brushButton
            // 
            resources.ApplyResources(this.brushButton, "brushButton");
            this.brushButton.CheckOnClick = true;
            this.brushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushButton.Name = "brushButton";
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // eraserButton
            // 
            resources.ApplyResources(this.eraserButton, "eraserButton");
            this.eraserButton.CheckOnClick = true;
            this.eraserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // rectButton
            // 
            resources.ApplyResources(this.rectButton, "rectButton");
            this.rectButton.CheckOnClick = true;
            this.rectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectButton.Name = "rectButton";
            this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
            // 
            // ellipseButton
            // 
            resources.ApplyResources(this.ellipseButton, "ellipseButton");
            this.ellipseButton.CheckOnClick = true;
            this.ellipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearButton.Name = "clearButton";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripLabel3
            // 
            resources.ApplyResources(this.toolStripLabel3, "toolStripLabel3");
            this.toolStripLabel3.Name = "toolStripLabel3";
            // 
            // ComboBox1
            // 
            resources.ApplyResources(this.ComboBox1, "ComboBox1");
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.ComboBox1.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // chosenColorLabel
            // 
            resources.ApplyResources(this.chosenColorLabel, "chosenColorLabel");
            this.chosenColorLabel.Name = "chosenColorLabel";
            // 
            // currentColorButton
            // 
            resources.ApplyResources(this.currentColorButton, "currentColorButton");
            this.currentColorButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.currentColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.currentColorButton.Name = "currentColorButton";
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // LanguagesLabel
            // 
            resources.ApplyResources(this.LanguagesLabel, "LanguagesLabel");
            this.LanguagesLabel.Name = "LanguagesLabel";
            // 
            // EnglishButton
            // 
            resources.ApplyResources(this.EnglishButton, "EnglishButton");
            this.EnglishButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click);
            // 
            // PolishButton
            // 
            resources.ApplyResources(this.PolishButton, "PolishButton");
            this.PolishButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolishButton.Name = "PolishButton";
            this.PolishButton.Click += new System.EventHandler(this.PolishButton_Click);
            // 
            // UkranianButton
            // 
            resources.ApplyResources(this.UkranianButton, "UkranianButton");
            this.UkranianButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UkranianButton.Name = "UkranianButton";
            this.UkranianButton.Click += new System.EventHandler(this.UkranianButton_Click);
            // 
            // RussianButton
            // 
            resources.ApplyResources(this.RussianButton, "RussianButton");
            this.RussianButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RussianButton.Name = "RussianButton";
            this.RussianButton.Click += new System.EventHandler(this.RussianButton_Click);
            // 
            // drawingArea
            // 
            resources.ApplyResources(this.drawingArea, "drawingArea");
            this.drawingArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingArea.Controls.Add(this.groupBox1, 1, 0);
            this.drawingArea.Controls.Add(this.Canvas, 0, 0);
            this.drawingArea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingArea.Name = "drawingArea";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.flowLayoutPanel);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            resources.ApplyResources(this.flowLayoutPanel, "flowLayoutPanel");
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            // 
            // Canvas
            // 
            resources.ApplyResources(this.Canvas, "Canvas");
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Name = "Canvas";
            this.Canvas.TabStop = false;
            this.Canvas.SizeChanged += new System.EventHandler(this.Canvas_SizeChanged_1);
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // miniForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.toolStrip1);
            this.Name = "miniForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.drawingArea.ResumeLayout(false);
            this.drawingArea.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private TableLayoutPanel drawingArea;
        private GroupBox groupBox1;
        private PictureBox Canvas;
        private FlowLayoutPanel flowLayoutPanel;
        private ToolStripButton brushButton;
        private ToolStripLabel toolsLabel;
        private ToolStripButton saveButton;
        private ToolStripButton loadButton;
        private ToolStripLabel fileLabel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox ComboBox1;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton clearButton;
        private ToolStripButton rectButton;
        private ToolStripButton ellipseButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton currentColorButton;
        private ToolStripLabel chosenColorLabel;
        private ToolStripButton EnglishButton;
        private ToolStripButton RussianButton;
        private ToolStripButton eraserButton;
        private ToolStripButton PolishButton;
        private ToolStripButton UkranianButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel LanguagesLabel;
    }
}