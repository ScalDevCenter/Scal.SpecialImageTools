namespace Scal.SpecialImageTools
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFileDialogPngInputFile = new System.Windows.Forms.OpenFileDialog();
            this.GroupBoxUnrasterize = new System.Windows.Forms.GroupBox();
            this.ButtonUnrasterizeGo = new System.Windows.Forms.Button();
            this.ButtonBackgroundColor = new System.Windows.Forms.Button();
            this.LabelBackgroundColor = new System.Windows.Forms.Label();
            this.ButtonColorToRemove = new System.Windows.Forms.Button();
            this.LabelColorToRemove = new System.Windows.Forms.Label();
            this.ButtonPngInputFile = new System.Windows.Forms.Button();
            this.LabelPngInputFile = new System.Windows.Forms.Label();
            this.TextBoxPngInputFile = new System.Windows.Forms.TextBox();
            this.ColorDialogColorToRemove = new System.Windows.Forms.ColorDialog();
            this.ColorDialogBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.GroupBoxRemoveDelta = new System.Windows.Forms.GroupBox();
            this.ButtonCleanDeltaGo = new System.Windows.Forms.Button();
            this.ButtonCleanDeltaBackgroundColor = new System.Windows.Forms.Button();
            this.LabelCleanDeltaBackgroundColor = new System.Windows.Forms.Label();
            this.ButtonPngInputFile2 = new System.Windows.Forms.Button();
            this.TextBoxPngInputFile2 = new System.Windows.Forms.TextBox();
            this.LabelPngInputFile2 = new System.Windows.Forms.Label();
            this.ButtonPngInputFile1 = new System.Windows.Forms.Button();
            this.TextBoxPngInputFile1 = new System.Windows.Forms.TextBox();
            this.LabelPngInputFile1 = new System.Windows.Forms.Label();
            this.OpenFileDialogPngInput1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileDialogPngInput2 = new System.Windows.Forms.OpenFileDialog();
            this.ColorDialogCleanDeltaBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.GroupBoxCreateBackgroundCanvas = new System.Windows.Forms.GroupBox();
            this.ButtonCreateBgCanvasGo = new System.Windows.Forms.Button();
            this.ButtonNewNonBgColor = new System.Windows.Forms.Button();
            this.LabelNewNonBgColor = new System.Windows.Forms.Label();
            this.ButtonNewBgColor = new System.Windows.Forms.Button();
            this.LabelNewBgColor = new System.Windows.Forms.Label();
            this.ButtonInitialBgColor = new System.Windows.Forms.Button();
            this.LabelInitialBgColor = new System.Windows.Forms.Label();
            this.ButtonPngInputFileBgCanvas = new System.Windows.Forms.Button();
            this.LabelPngInputFileBgCanvas = new System.Windows.Forms.Label();
            this.TextBoxPngInputFileBgCanvas = new System.Windows.Forms.TextBox();
            this.OpenFileDialogPngInputCreateBgCanvas = new System.Windows.Forms.OpenFileDialog();
            this.ColorDialogInitialBgColor = new System.Windows.Forms.ColorDialog();
            this.ColorDialogNewBgColor = new System.Windows.Forms.ColorDialog();
            this.ColorDialogNewNonBgColor = new System.Windows.Forms.ColorDialog();
            this.GroupBoxUnrasterize.SuspendLayout();
            this.GroupBoxRemoveDelta.SuspendLayout();
            this.GroupBoxCreateBackgroundCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialogPngInputFile
            // 
            this.OpenFileDialogPngInputFile.Filter = "PNG files (*.png)|*.png";
            this.OpenFileDialogPngInputFile.Title = "Select input file";
            // 
            // GroupBoxUnrasterize
            // 
            this.GroupBoxUnrasterize.Controls.Add(this.ButtonUnrasterizeGo);
            this.GroupBoxUnrasterize.Controls.Add(this.ButtonBackgroundColor);
            this.GroupBoxUnrasterize.Controls.Add(this.LabelBackgroundColor);
            this.GroupBoxUnrasterize.Controls.Add(this.ButtonColorToRemove);
            this.GroupBoxUnrasterize.Controls.Add(this.LabelColorToRemove);
            this.GroupBoxUnrasterize.Controls.Add(this.ButtonPngInputFile);
            this.GroupBoxUnrasterize.Controls.Add(this.LabelPngInputFile);
            this.GroupBoxUnrasterize.Controls.Add(this.TextBoxPngInputFile);
            this.GroupBoxUnrasterize.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxUnrasterize.Name = "GroupBoxUnrasterize";
            this.GroupBoxUnrasterize.Size = new System.Drawing.Size(547, 89);
            this.GroupBoxUnrasterize.TabIndex = 3;
            this.GroupBoxUnrasterize.TabStop = false;
            this.GroupBoxUnrasterize.Text = "Remove floor raster effect";
            // 
            // ButtonUnrasterizeGo
            // 
            this.ButtonUnrasterizeGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUnrasterizeGo.Location = new System.Drawing.Point(455, 56);
            this.ButtonUnrasterizeGo.Name = "ButtonUnrasterizeGo";
            this.ButtonUnrasterizeGo.Size = new System.Drawing.Size(75, 23);
            this.ButtonUnrasterizeGo.TabIndex = 10;
            this.ButtonUnrasterizeGo.Text = "Go";
            this.ButtonUnrasterizeGo.UseVisualStyleBackColor = true;
            this.ButtonUnrasterizeGo.Click += new System.EventHandler(this.ButtonUnrasterizeGo_Click);
            // 
            // ButtonBackgroundColor
            // 
            this.ButtonBackgroundColor.Location = new System.Drawing.Point(276, 56);
            this.ButtonBackgroundColor.Name = "ButtonBackgroundColor";
            this.ButtonBackgroundColor.Size = new System.Drawing.Size(75, 23);
            this.ButtonBackgroundColor.TabIndex = 9;
            this.ButtonBackgroundColor.UseVisualStyleBackColor = true;
            this.ButtonBackgroundColor.Click += new System.EventHandler(this.ButtonBackgroundColor_Click);
            // 
            // LabelBackgroundColor
            // 
            this.LabelBackgroundColor.AutoSize = true;
            this.LabelBackgroundColor.Location = new System.Drawing.Point(179, 61);
            this.LabelBackgroundColor.Name = "LabelBackgroundColor";
            this.LabelBackgroundColor.Size = new System.Drawing.Size(91, 13);
            this.LabelBackgroundColor.TabIndex = 8;
            this.LabelBackgroundColor.Text = "Background color";
            // 
            // ButtonColorToRemove
            // 
            this.ButtonColorToRemove.Location = new System.Drawing.Point(98, 56);
            this.ButtonColorToRemove.Name = "ButtonColorToRemove";
            this.ButtonColorToRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonColorToRemove.TabIndex = 7;
            this.ButtonColorToRemove.UseVisualStyleBackColor = true;
            this.ButtonColorToRemove.Click += new System.EventHandler(this.ButtonColortoRemove_Click);
            // 
            // LabelColorToRemove
            // 
            this.LabelColorToRemove.AutoSize = true;
            this.LabelColorToRemove.Location = new System.Drawing.Point(6, 61);
            this.LabelColorToRemove.Name = "LabelColorToRemove";
            this.LabelColorToRemove.Size = new System.Drawing.Size(81, 13);
            this.LabelColorToRemove.TabIndex = 6;
            this.LabelColorToRemove.Text = "Color to remove";
            // 
            // ButtonPngInputFile
            // 
            this.ButtonPngInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPngInputFile.Location = new System.Drawing.Point(499, 24);
            this.ButtonPngInputFile.Name = "ButtonPngInputFile";
            this.ButtonPngInputFile.Size = new System.Drawing.Size(31, 23);
            this.ButtonPngInputFile.TabIndex = 5;
            this.ButtonPngInputFile.Text = "..";
            this.ButtonPngInputFile.UseVisualStyleBackColor = true;
            this.ButtonPngInputFile.Click += new System.EventHandler(this.ButtonPngInputFile_Click);
            // 
            // LabelPngInputFile
            // 
            this.LabelPngInputFile.AutoSize = true;
            this.LabelPngInputFile.Location = new System.Drawing.Point(6, 29);
            this.LabelPngInputFile.Name = "LabelPngInputFile";
            this.LabelPngInputFile.Size = new System.Drawing.Size(56, 13);
            this.LabelPngInputFile.TabIndex = 4;
            this.LabelPngInputFile.Text = "PNG input";
            // 
            // TextBoxPngInputFile
            // 
            this.TextBoxPngInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPngInputFile.Location = new System.Drawing.Point(98, 26);
            this.TextBoxPngInputFile.Name = "TextBoxPngInputFile";
            this.TextBoxPngInputFile.Size = new System.Drawing.Size(395, 20);
            this.TextBoxPngInputFile.TabIndex = 3;
            // 
            // GroupBoxRemoveDelta
            // 
            this.GroupBoxRemoveDelta.Controls.Add(this.ButtonCleanDeltaGo);
            this.GroupBoxRemoveDelta.Controls.Add(this.ButtonCleanDeltaBackgroundColor);
            this.GroupBoxRemoveDelta.Controls.Add(this.LabelCleanDeltaBackgroundColor);
            this.GroupBoxRemoveDelta.Controls.Add(this.ButtonPngInputFile2);
            this.GroupBoxRemoveDelta.Controls.Add(this.TextBoxPngInputFile2);
            this.GroupBoxRemoveDelta.Controls.Add(this.LabelPngInputFile2);
            this.GroupBoxRemoveDelta.Controls.Add(this.ButtonPngInputFile1);
            this.GroupBoxRemoveDelta.Controls.Add(this.TextBoxPngInputFile1);
            this.GroupBoxRemoveDelta.Controls.Add(this.LabelPngInputFile1);
            this.GroupBoxRemoveDelta.Location = new System.Drawing.Point(12, 107);
            this.GroupBoxRemoveDelta.Name = "GroupBoxRemoveDelta";
            this.GroupBoxRemoveDelta.Size = new System.Drawing.Size(547, 110);
            this.GroupBoxRemoveDelta.TabIndex = 4;
            this.GroupBoxRemoveDelta.TabStop = false;
            this.GroupBoxRemoveDelta.Text = "Clean delta from 2 images";
            // 
            // ButtonCleanDeltaGo
            // 
            this.ButtonCleanDeltaGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCleanDeltaGo.Location = new System.Drawing.Point(455, 76);
            this.ButtonCleanDeltaGo.Name = "ButtonCleanDeltaGo";
            this.ButtonCleanDeltaGo.Size = new System.Drawing.Size(75, 23);
            this.ButtonCleanDeltaGo.TabIndex = 12;
            this.ButtonCleanDeltaGo.Text = "Go";
            this.ButtonCleanDeltaGo.UseVisualStyleBackColor = true;
            this.ButtonCleanDeltaGo.Click += new System.EventHandler(this.ButtonCleanDeltaGo_Click);
            // 
            // ButtonCleanDeltaBackgroundColor
            // 
            this.ButtonCleanDeltaBackgroundColor.Location = new System.Drawing.Point(98, 75);
            this.ButtonCleanDeltaBackgroundColor.Name = "ButtonCleanDeltaBackgroundColor";
            this.ButtonCleanDeltaBackgroundColor.Size = new System.Drawing.Size(75, 23);
            this.ButtonCleanDeltaBackgroundColor.TabIndex = 11;
            this.ButtonCleanDeltaBackgroundColor.UseVisualStyleBackColor = true;
            this.ButtonCleanDeltaBackgroundColor.Click += new System.EventHandler(this.ButtonCleanDeltaBackgroundColor_Click);
            // 
            // LabelCleanDeltaBackgroundColor
            // 
            this.LabelCleanDeltaBackgroundColor.AutoSize = true;
            this.LabelCleanDeltaBackgroundColor.Location = new System.Drawing.Point(6, 80);
            this.LabelCleanDeltaBackgroundColor.Name = "LabelCleanDeltaBackgroundColor";
            this.LabelCleanDeltaBackgroundColor.Size = new System.Drawing.Size(91, 13);
            this.LabelCleanDeltaBackgroundColor.TabIndex = 10;
            this.LabelCleanDeltaBackgroundColor.Text = "Background color";
            // 
            // ButtonPngInputFile2
            // 
            this.ButtonPngInputFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPngInputFile2.Location = new System.Drawing.Point(499, 47);
            this.ButtonPngInputFile2.Name = "ButtonPngInputFile2";
            this.ButtonPngInputFile2.Size = new System.Drawing.Size(31, 23);
            this.ButtonPngInputFile2.TabIndex = 9;
            this.ButtonPngInputFile2.Text = "..";
            this.ButtonPngInputFile2.UseVisualStyleBackColor = true;
            this.ButtonPngInputFile2.Click += new System.EventHandler(this.ButtonPngInputFile2_Click);
            // 
            // TextBoxPngInputFile2
            // 
            this.TextBoxPngInputFile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPngInputFile2.Location = new System.Drawing.Point(98, 49);
            this.TextBoxPngInputFile2.Name = "TextBoxPngInputFile2";
            this.TextBoxPngInputFile2.Size = new System.Drawing.Size(395, 20);
            this.TextBoxPngInputFile2.TabIndex = 8;
            // 
            // LabelPngInputFile2
            // 
            this.LabelPngInputFile2.AutoSize = true;
            this.LabelPngInputFile2.Location = new System.Drawing.Point(8, 52);
            this.LabelPngInputFile2.Name = "LabelPngInputFile2";
            this.LabelPngInputFile2.Size = new System.Drawing.Size(79, 13);
            this.LabelPngInputFile2.TabIndex = 7;
            this.LabelPngInputFile2.Text = "PNg input file 2";
            // 
            // ButtonPngInputFile1
            // 
            this.ButtonPngInputFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPngInputFile1.Location = new System.Drawing.Point(499, 21);
            this.ButtonPngInputFile1.Name = "ButtonPngInputFile1";
            this.ButtonPngInputFile1.Size = new System.Drawing.Size(31, 23);
            this.ButtonPngInputFile1.TabIndex = 6;
            this.ButtonPngInputFile1.Text = "..";
            this.ButtonPngInputFile1.UseVisualStyleBackColor = true;
            this.ButtonPngInputFile1.Click += new System.EventHandler(this.ButtonPngInputFile1_Click);
            // 
            // TextBoxPngInputFile1
            // 
            this.TextBoxPngInputFile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPngInputFile1.Location = new System.Drawing.Point(98, 23);
            this.TextBoxPngInputFile1.Name = "TextBoxPngInputFile1";
            this.TextBoxPngInputFile1.Size = new System.Drawing.Size(395, 20);
            this.TextBoxPngInputFile1.TabIndex = 4;
            // 
            // LabelPngInputFile1
            // 
            this.LabelPngInputFile1.AutoSize = true;
            this.LabelPngInputFile1.Location = new System.Drawing.Point(8, 26);
            this.LabelPngInputFile1.Name = "LabelPngInputFile1";
            this.LabelPngInputFile1.Size = new System.Drawing.Size(79, 13);
            this.LabelPngInputFile1.TabIndex = 0;
            this.LabelPngInputFile1.Text = "PNg input file 1";
            // 
            // OpenFileDialogPngInput1
            // 
            this.OpenFileDialogPngInput1.Filter = "PNG files (*.png)|*.png";
            this.OpenFileDialogPngInput1.Title = "Select input file 1";
            // 
            // OpenFileDialogPngInput2
            // 
            this.OpenFileDialogPngInput2.Filter = "PNG files (*.png)|*.png";
            this.OpenFileDialogPngInput2.Title = "Select input file 2";
            // 
            // GroupBoxCreateBackgroundCanvas
            // 
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.ButtonCreateBgCanvasGo);
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.ButtonNewNonBgColor);
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.LabelNewNonBgColor);
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.ButtonNewBgColor);
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.LabelNewBgColor);
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.ButtonInitialBgColor);
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.LabelInitialBgColor);
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.ButtonPngInputFileBgCanvas);
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.LabelPngInputFileBgCanvas);
            this.GroupBoxCreateBackgroundCanvas.Controls.Add(this.TextBoxPngInputFileBgCanvas);
            this.GroupBoxCreateBackgroundCanvas.Location = new System.Drawing.Point(12, 223);
            this.GroupBoxCreateBackgroundCanvas.Name = "GroupBoxCreateBackgroundCanvas";
            this.GroupBoxCreateBackgroundCanvas.Size = new System.Drawing.Size(547, 122);
            this.GroupBoxCreateBackgroundCanvas.TabIndex = 5;
            this.GroupBoxCreateBackgroundCanvas.TabStop = false;
            this.GroupBoxCreateBackgroundCanvas.Text = "Create background canvas";
            // 
            // ButtonCreateBgCanvasGo
            // 
            this.ButtonCreateBgCanvasGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCreateBgCanvasGo.Location = new System.Drawing.Point(455, 79);
            this.ButtonCreateBgCanvasGo.Name = "ButtonCreateBgCanvasGo";
            this.ButtonCreateBgCanvasGo.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateBgCanvasGo.TabIndex = 18;
            this.ButtonCreateBgCanvasGo.Text = "Go";
            this.ButtonCreateBgCanvasGo.UseVisualStyleBackColor = true;
            this.ButtonCreateBgCanvasGo.Click += new System.EventHandler(this.ButtonCreateBgCanvasGo_Click);
            // 
            // ButtonNewNonBgColor
            // 
            this.ButtonNewNonBgColor.Location = new System.Drawing.Point(98, 79);
            this.ButtonNewNonBgColor.Name = "ButtonNewNonBgColor";
            this.ButtonNewNonBgColor.Size = new System.Drawing.Size(75, 23);
            this.ButtonNewNonBgColor.TabIndex = 17;
            this.ButtonNewNonBgColor.UseVisualStyleBackColor = true;
            this.ButtonNewNonBgColor.Click += new System.EventHandler(this.ButtonNewNonBgColor_Click);
            // 
            // LabelNewNonBgColor
            // 
            this.LabelNewNonBgColor.AutoSize = true;
            this.LabelNewNonBgColor.Location = new System.Drawing.Point(6, 84);
            this.LabelNewNonBgColor.Name = "LabelNewNonBgColor";
            this.LabelNewNonBgColor.Size = new System.Drawing.Size(91, 13);
            this.LabelNewNonBgColor.TabIndex = 16;
            this.LabelNewNonBgColor.Text = "New non bg color";
            // 
            // ButtonNewBgColor
            // 
            this.ButtonNewBgColor.Location = new System.Drawing.Point(276, 50);
            this.ButtonNewBgColor.Name = "ButtonNewBgColor";
            this.ButtonNewBgColor.Size = new System.Drawing.Size(75, 23);
            this.ButtonNewBgColor.TabIndex = 15;
            this.ButtonNewBgColor.UseVisualStyleBackColor = true;
            this.ButtonNewBgColor.Click += new System.EventHandler(this.ButtonNewBgColor_Click);
            // 
            // LabelNewBgColor
            // 
            this.LabelNewBgColor.AutoSize = true;
            this.LabelNewBgColor.Location = new System.Drawing.Point(184, 55);
            this.LabelNewBgColor.Name = "LabelNewBgColor";
            this.LabelNewBgColor.Size = new System.Drawing.Size(70, 13);
            this.LabelNewBgColor.TabIndex = 14;
            this.LabelNewBgColor.Text = "New bg color";
            // 
            // ButtonInitialBgColor
            // 
            this.ButtonInitialBgColor.Location = new System.Drawing.Point(98, 50);
            this.ButtonInitialBgColor.Name = "ButtonInitialBgColor";
            this.ButtonInitialBgColor.Size = new System.Drawing.Size(75, 23);
            this.ButtonInitialBgColor.TabIndex = 13;
            this.ButtonInitialBgColor.UseVisualStyleBackColor = true;
            this.ButtonInitialBgColor.Click += new System.EventHandler(this.ButtonInitialBgColor_Click);
            // 
            // LabelInitialBgColor
            // 
            this.LabelInitialBgColor.AutoSize = true;
            this.LabelInitialBgColor.Location = new System.Drawing.Point(6, 55);
            this.LabelInitialBgColor.Name = "LabelInitialBgColor";
            this.LabelInitialBgColor.Size = new System.Drawing.Size(72, 13);
            this.LabelInitialBgColor.TabIndex = 12;
            this.LabelInitialBgColor.Text = "Initial bg color";
            // 
            // ButtonPngInputFileBgCanvas
            // 
            this.ButtonPngInputFileBgCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPngInputFileBgCanvas.Location = new System.Drawing.Point(499, 22);
            this.ButtonPngInputFileBgCanvas.Name = "ButtonPngInputFileBgCanvas";
            this.ButtonPngInputFileBgCanvas.Size = new System.Drawing.Size(31, 23);
            this.ButtonPngInputFileBgCanvas.TabIndex = 8;
            this.ButtonPngInputFileBgCanvas.Text = "..";
            this.ButtonPngInputFileBgCanvas.UseVisualStyleBackColor = true;
            this.ButtonPngInputFileBgCanvas.Click += new System.EventHandler(this.ButtonPngInputFileBgCanvas_Click);
            // 
            // LabelPngInputFileBgCanvas
            // 
            this.LabelPngInputFileBgCanvas.AutoSize = true;
            this.LabelPngInputFileBgCanvas.Location = new System.Drawing.Point(6, 27);
            this.LabelPngInputFileBgCanvas.Name = "LabelPngInputFileBgCanvas";
            this.LabelPngInputFileBgCanvas.Size = new System.Drawing.Size(56, 13);
            this.LabelPngInputFileBgCanvas.TabIndex = 7;
            this.LabelPngInputFileBgCanvas.Text = "PNG input";
            // 
            // TextBoxPngInputFileBgCanvas
            // 
            this.TextBoxPngInputFileBgCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPngInputFileBgCanvas.Location = new System.Drawing.Point(98, 24);
            this.TextBoxPngInputFileBgCanvas.Name = "TextBoxPngInputFileBgCanvas";
            this.TextBoxPngInputFileBgCanvas.Size = new System.Drawing.Size(395, 20);
            this.TextBoxPngInputFileBgCanvas.TabIndex = 6;
            // 
            // OpenFileDialogPngInputCreateBgCanvas
            // 
            this.OpenFileDialogPngInputCreateBgCanvas.Filter = "PNG files (*.png)|*.png";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 353);
            this.Controls.Add(this.GroupBoxCreateBackgroundCanvas);
            this.Controls.Add(this.GroupBoxRemoveDelta);
            this.Controls.Add(this.GroupBoxUnrasterize);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.GroupBoxUnrasterize.ResumeLayout(false);
            this.GroupBoxUnrasterize.PerformLayout();
            this.GroupBoxRemoveDelta.ResumeLayout(false);
            this.GroupBoxRemoveDelta.PerformLayout();
            this.GroupBoxCreateBackgroundCanvas.ResumeLayout(false);
            this.GroupBoxCreateBackgroundCanvas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialogPngInputFile;
        private System.Windows.Forms.GroupBox GroupBoxUnrasterize;
        private System.Windows.Forms.Button ButtonColorToRemove;
        private System.Windows.Forms.Label LabelColorToRemove;
        private System.Windows.Forms.Button ButtonPngInputFile;
        private System.Windows.Forms.Label LabelPngInputFile;
        private System.Windows.Forms.TextBox TextBoxPngInputFile;
        private System.Windows.Forms.ColorDialog ColorDialogColorToRemove;
        private System.Windows.Forms.Button ButtonBackgroundColor;
        private System.Windows.Forms.Label LabelBackgroundColor;
        private System.Windows.Forms.ColorDialog ColorDialogBackgroundColor;
        private System.Windows.Forms.Button ButtonUnrasterizeGo;
        private System.Windows.Forms.GroupBox GroupBoxRemoveDelta;
        private System.Windows.Forms.Button ButtonPngInputFile1;
        private System.Windows.Forms.TextBox TextBoxPngInputFile1;
        private System.Windows.Forms.Label LabelPngInputFile1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogPngInput1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogPngInput2;
        private System.Windows.Forms.Button ButtonPngInputFile2;
        private System.Windows.Forms.TextBox TextBoxPngInputFile2;
        private System.Windows.Forms.Label LabelPngInputFile2;
        private System.Windows.Forms.ColorDialog ColorDialogCleanDeltaBackgroundColor;
        private System.Windows.Forms.Button ButtonCleanDeltaBackgroundColor;
        private System.Windows.Forms.Label LabelCleanDeltaBackgroundColor;
        private System.Windows.Forms.Button ButtonCleanDeltaGo;
        private System.Windows.Forms.GroupBox GroupBoxCreateBackgroundCanvas;
        private System.Windows.Forms.Button ButtonNewBgColor;
        private System.Windows.Forms.Label LabelNewBgColor;
        private System.Windows.Forms.Button ButtonInitialBgColor;
        private System.Windows.Forms.Label LabelInitialBgColor;
        private System.Windows.Forms.Button ButtonPngInputFileBgCanvas;
        private System.Windows.Forms.Label LabelPngInputFileBgCanvas;
        private System.Windows.Forms.TextBox TextBoxPngInputFileBgCanvas;
        private System.Windows.Forms.Button ButtonCreateBgCanvasGo;
        private System.Windows.Forms.Button ButtonNewNonBgColor;
        private System.Windows.Forms.Label LabelNewNonBgColor;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogPngInputCreateBgCanvas;
        private System.Windows.Forms.ColorDialog ColorDialogInitialBgColor;
        private System.Windows.Forms.ColorDialog ColorDialogNewBgColor;
        private System.Windows.Forms.ColorDialog ColorDialogNewNonBgColor;
    }
}

