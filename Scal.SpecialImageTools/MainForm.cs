using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scal.SpecialImageTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text = string.Format("{0} {1}", 
                Application.ProductName, Application.ProductVersion);

            ColorDialogBackgroundColor.Color = Color.FromArgb(255, 0, 255);
            ApplyBackgroundColorSelection();

            ColorDialogColorToRemove.Color = Color.FromArgb(0, 0, 0);
            ApplyColorToRemoveSelection();

            ColorDialogCleanDeltaBackgroundColor.Color = Color.FromArgb(255, 0, 255);
            ApplyCleanDeltaBackgroundColorSelection();

            ColorDialogInitialBgColor.Color = Color.FromArgb(0, 0, 0);
            ApplyCreateBgCanvasInitialBgColorSelection();

            ColorDialogNewBgColor.Color = Color.FromArgb(255, 0, 255);
            ApplyCreateBgCanvasNewBgColorSelection();

            ColorDialogNewNonBgColor.Color = Color.FromArgb(0, 255, 0);
            ApplyCreateBgCanvasNewNonBgColorSelection();
        }

        #region Unrasterize image
        #region Unrasterize input file
        private void ButtonPngInputFile_Click(object sender, EventArgs e)
        {
            if(OpenFileDialogPngInputFile.ShowDialog() == DialogResult.OK)
            {
                ApplyUnrasterizePngInputFileSelection();
            }
        }

        private void ApplyUnrasterizePngInputFileSelection()
        {
            TextBoxPngInputFile.Text = OpenFileDialogPngInputFile.FileName;
        }
        #endregion

        #region Color to remove
        private void ButtonColortoRemove_Click(object sender, EventArgs e)
        {
            if(ColorDialogColorToRemove.ShowDialog() == DialogResult.OK)
            {
                ApplyColorToRemoveSelection();
            }
        }

        private void ApplyColorToRemoveSelection()
        {
            ButtonColorToRemove.BackColor = ColorDialogColorToRemove.Color;
        }
        #endregion

        #region Apply background color selection
        private void ButtonBackgroundColor_Click(object sender, EventArgs e)
        {
            if(ColorDialogBackgroundColor.ShowDialog() == DialogResult.OK)
            {
                ApplyBackgroundColorSelection();
            }
        }
        private void ApplyBackgroundColorSelection()
        {
            ButtonBackgroundColor.BackColor = ColorDialogBackgroundColor.Color;
        }
        #endregion

        private void ButtonUnrasterizeGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxPngInputFile.Text)) return;

            try
            {
                ImageTool.UnrasterizeImage(TextBoxPngInputFile.Text, 
                    ColorDialogColorToRemove.Color, ColorDialogBackgroundColor.Color);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Clean delta from images
        #region Clean delta input file 1
        private void ButtonPngInputFile1_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogPngInput1.ShowDialog() == DialogResult.OK)
            {
                ApplyPngInputFile1Selection();
            }
        }

        private void ApplyPngInputFile1Selection()
        {
            TextBoxPngInputFile1.Text = OpenFileDialogPngInput1.FileName;
        }
        #endregion


        #region Clean delta input file 2
        private void ButtonPngInputFile2_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogPngInput2.ShowDialog() == DialogResult.OK)
            {
                ApplyPngInputFile2Selection();
            }
        }

        private void ApplyPngInputFile2Selection()
        {
            TextBoxPngInputFile2.Text = OpenFileDialogPngInput2.FileName;
        }
        #endregion

        #region Background color
        private void ButtonCleanDeltaBackgroundColor_Click(object sender, EventArgs e)
        {
            if(ColorDialogCleanDeltaBackgroundColor.ShowDialog() == DialogResult.OK)
            {
                ApplyCleanDeltaBackgroundColorSelection();
            }
        }

        private void ApplyCleanDeltaBackgroundColorSelection()
        {
            ButtonCleanDeltaBackgroundColor.BackColor = ColorDialogCleanDeltaBackgroundColor.Color;
        }
        #endregion

        private void ButtonCleanDeltaGo_Click(object sender, EventArgs e)
        {
            try
            {
                ImageTool.CleanDeltaFrom2Images(
                    TextBoxPngInputFile1.Text, TextBoxPngInputFile2.Text,
                    ColorDialogCleanDeltaBackgroundColor.Color);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Create background canvas

        #region Input file
        private void ButtonPngInputFileBgCanvas_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogPngInputCreateBgCanvas.ShowDialog() == DialogResult.OK)
            {
                ApplyCreateBgCanvasPngInputFileSelection();
            }
        }

        private void ApplyCreateBgCanvasPngInputFileSelection()
        {
            TextBoxPngInputFileBgCanvas.Text = OpenFileDialogPngInputCreateBgCanvas.FileName;
        }
        #endregion

        #region Initial bg color
        private void ButtonInitialBgColor_Click(object sender, EventArgs e)
        {
            if (ColorDialogInitialBgColor.ShowDialog() == DialogResult.OK)
            {
                ApplyCreateBgCanvasInitialBgColorSelection();
            }
        }

        private void ApplyCreateBgCanvasInitialBgColorSelection()
        {
            ButtonInitialBgColor.BackColor = ColorDialogInitialBgColor.Color;
        }
        #endregion

        #region Replacement bg color
        private void ButtonNewBgColor_Click(object sender, EventArgs e)
        {
            if (ColorDialogNewBgColor.ShowDialog() == DialogResult.OK)
            {
                ApplyCreateBgCanvasNewBgColorSelection();
            }
        }

        private void ApplyCreateBgCanvasNewBgColorSelection()
        {
            ButtonNewBgColor.BackColor = ColorDialogNewBgColor.Color;
        }
        #endregion

        #region Replacement non bg color
        private void ButtonNewNonBgColor_Click(object sender, EventArgs e)
        {
            if(ColorDialogNewBgColor.ShowDialog() == DialogResult.OK)
            {
                ApplyCreateBgCanvasNewNonBgColorSelection();
            }
        }

        private void ApplyCreateBgCanvasNewNonBgColorSelection()
        {
            ButtonNewNonBgColor.BackColor = ColorDialogNewNonBgColor.Color;
        }
        #endregion

        private void ButtonCreateBgCanvasGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxPngInputFileBgCanvas.Text)) return;

            try
            {
                ImageTool.CreateTransparentColorCanvas(TextBoxPngInputFileBgCanvas.Text,
                    ColorDialogInitialBgColor.Color, ColorDialogNewBgColor.Color,
                    ColorDialogNewNonBgColor.Color);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
