using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Scal.SpecialImageTools
{
    public static class ImageTool
    {
        public static void UnrasterizeImage(string inputFile, Color colorToRemove, Color backgroundColor, int startHeight = 0)
        {
            var copyColorToRemove = Color.FromArgb(
                colorToRemove.R, colorToRemove.G, colorToRemove.B);

            using (Bitmap bmp = Image.FromFile(inputFile) as Bitmap)
            {
                using (var output = new Bitmap(bmp.Width, bmp.Height))
                {
                    using (var g = Graphics.FromImage(output))
                    {
                        g.Clear(backgroundColor);

                        for (var y = startHeight; y < bmp.Height; y++)
                        {
                            var outputX = 0;
                            var lineDrawStarted = false;

                            for (var x = 0; x < bmp.Width; x++)
                            {
                                var inputColor = bmp.GetPixel(x, y);
                                if (inputColor != copyColorToRemove || lineDrawStarted)
                                {
                                    output.SetPixel(outputX, y, inputColor);
                                    outputX++;
                                    lineDrawStarted = true;
                                }
                            }
                        }
                    }

                    var outputFilename = Path.Combine(
                        Path.GetDirectoryName(inputFile),
                        string.Format("{0}_Modified.png",
                            Path.GetFileNameWithoutExtension(inputFile))
                        );
                    output.Save(outputFilename);
                }
            }
        }

        public static void CleanDeltaFrom2Images(string inputFile1, string inputFile2, Color backgroundColor)
        {
            using (Bitmap bmp1 = Image.FromFile(inputFile1) as Bitmap)
            {
                using (Bitmap bmp2 = Image.FromFile(inputFile2) as Bitmap)
                {
                    if(bmp1.Width != bmp2.Width || bmp1.Height != bmp2.Height)
                    {
                        throw new Exception("Dimensions of the input images do not match");
                    }

                    using (var output = new Bitmap(bmp1.Width, bmp1.Height))
                    {
                        using (var g = Graphics.FromImage(output))
                        {
                            g.Clear(backgroundColor);

                            for (var y = 0; y < bmp1.Height; y++)
                            {
                                for (var x = 0; x < bmp1.Width; x++)
                                {
                                    var inputColor1 = bmp1.GetPixel(x, y);
                                    var inputColor2 = bmp2.GetPixel(x, y);

                                    if (inputColor1 == inputColor2)
                                    {
                                        output.SetPixel(x, y, inputColor1);
                                    }
                                    else
                                    {
                                        output.SetPixel(x, y, backgroundColor);
                                    }
                                }
                            }
                        }

                        var outputFilename = Path.Combine(
                            Path.GetDirectoryName(inputFile1),
                            string.Format("{0}_Modified.png",
                                Path.GetFileNameWithoutExtension(inputFile1))
                            );
                        output.Save(outputFilename);
                    }
                }
            }
        }

        public static void CreateTransparentColorCanvas(string inputFile, Color initialBackgroundColor, Color replacementBackgroundColor, Color replacementNonBackgroundColor)
        {
            var copyInitialBackgroundColor = Color.FromArgb(
                initialBackgroundColor.R, initialBackgroundColor.G, initialBackgroundColor.B);
            
            using (Bitmap bmp = Image.FromFile(inputFile) as Bitmap)
            {
                using (var output = new Bitmap(bmp.Width, bmp.Height))
                {
                    using (var g = Graphics.FromImage(output))
                    {
                        g.Clear(replacementNonBackgroundColor);

                        for (var y = 0; y < bmp.Height; y++)
                        {
                            for (var x = 0; x < bmp.Width; x++)
                            {
                                var inputColor = bmp.GetPixel(x, y);
                                if (inputColor == copyInitialBackgroundColor)
                                {
                                    output.SetPixel(x, y, replacementBackgroundColor);
                                }
                            }
                        }
                    }

                    var outputFilename = Path.Combine(
                        Path.GetDirectoryName(inputFile),
                        string.Format("{0}_Modified.png",
                            Path.GetFileNameWithoutExtension(inputFile))
                        );
                    output.Save(outputFilename);
                }
            }
        }

        // The functions below are not integrated in the GUI yet

        /// <summary>
        /// Merge a multiline serie of constant sized tiles
        /// </summary>
        /// <param name="inputFile">Input file to merge</param>
        /// <param name="lineHeight">Height of the tiles lines</param>
        /// Example: Barrels of Sftm-MovieBattle
        public static void MergeMultipleLinesIntoSingle(string inputFile, int lineHeight)
        {
            using (Bitmap bmp = Image.FromFile(inputFile) as Bitmap)
            {
                var numberOfLines = (int)Math.Round((double)bmp.Height / lineHeight);
                var newWidth = bmp.Width * numberOfLines;

                using (var output = new Bitmap(newWidth, lineHeight))
                {
                    using (var gOutput = Graphics.FromImage(output))
                    {
                        for(var i = 0; i < numberOfLines; i++)
                        {
                            var cloneRect = new Rectangle(0, i * lineHeight, bmp.Width, lineHeight);
                            var cloneBitmap = bmp.Clone(cloneRect, PixelFormat.Format8bppIndexed);
                            var destRectangle = new Rectangle(i * bmp.Width, 0, bmp.Width, lineHeight);
                            gOutput.DrawImage(cloneBitmap, destRectangle);
                        }

                        var outputFilename = Path.Combine(
                        Path.GetDirectoryName(inputFile),
                        string.Format("{0}_Modified.png",
                            Path.GetFileNameWithoutExtension(inputFile))
                        );
                        output.Save(outputFilename);
                    }
                }
            }
        }

        /// <summary>
        /// Split a one line picture containing constant sized tiles
        /// </summary>
        /// <param name="inputFile">Input file to split</param>
        /// <param name="tileWidth">Width of all the tiles</param>
        /// <param name="tileHeight">Height of all the tiles</param>
        /// <param name="numberOfLines">Number of lines of the ouput</param>
        /// <param name="numberOfColumns">Number of columns of the ouput</param>
        /// Example: Barrels of Sftm-MovieBattle
        public static void SplitSingleLineTiles(string inputFile, int tileWidth, int tileHeight, int numberOfLines, int numberOfColumns)
        {
            using (Bitmap bmp = Image.FromFile(inputFile) as Bitmap)
            {
                var numberOfFiles = (int)Math.Floor((double)bmp.Width / (tileWidth * numberOfColumns * numberOfLines));

                for (var i = 0; i < numberOfFiles; i++)
                {
                    var globalXSource = i * tileWidth * numberOfColumns * numberOfLines;

                    using (var output = new Bitmap(tileWidth * numberOfColumns, tileHeight * numberOfLines))
                    {
                        using (var gOutput = Graphics.FromImage(output))
                        {
                            for (var xDestCount = 0; xDestCount < numberOfColumns; xDestCount++)
                            {
                                for (var yDestCount = 0; yDestCount < numberOfLines; yDestCount++)
                                {
                                    //var xSource = (i * numberOfColumns * numberOfFiles * tileWidth) + 
                                    //    (tileWidth * (xDestCount + (yDestCount * numberOfColumns))) ;
                                    var xSource = globalXSource +
                                        (tileWidth * (xDestCount + (yDestCount * numberOfColumns)));

                                    var cloneRect = new Rectangle(xSource, 0, tileWidth, tileHeight);
                                    var cloneBitmap = bmp.Clone(cloneRect, PixelFormat.DontCare);
                                    var destRectangle = new Rectangle(
                                        xDestCount * tileWidth, yDestCount * tileHeight, tileWidth, tileHeight);
                                    gOutput.DrawImage(cloneBitmap, destRectangle);
                                }
                            }
                        }

                        var outputFilename = Path.Combine(
                        Path.GetDirectoryName(inputFile),
                        string.Format("{0}_Modified_{1}.png",
                            Path.GetFileNameWithoutExtension(inputFile),
                            i.ToString().PadLeft(2, '0')
                        ));
                        output.Save(outputFilename);
                    }
                }
            }
        }

        /// <summary>
        /// Split tiles stored in one line to one file each
        /// </summary>
        /// <param name="inputFile">Input file to split</param>
        /// <param name="tileWidth">Width of all the tiles</param>
        /// <param name="tileHeight">Height of all the tiles</param>
        public static void SplitTilesIntoFiles(string inputFile, int tileWidth, int tileHeight)
        {
            int numberOfLines = 0;
            int numberOfColumns = 0;

            using (Bitmap bmp = Image.FromFile(inputFile) as Bitmap)
            {
                numberOfLines = bmp.Height / tileHeight;
                numberOfColumns = bmp.Width / tileWidth;

                var numberOfFiles = numberOfLines * numberOfColumns;
                var i = 0;

                for (var yDestCount = 0; yDestCount < numberOfLines; yDestCount++)
                {
                    for (var xDestCount = 0; xDestCount < numberOfColumns; xDestCount++)
                    {
                        using (var output = new Bitmap(tileWidth, tileHeight))
                        {
                            using (var gOutput = Graphics.FromImage(output))
                            {
                                var xSource = tileWidth * xDestCount;
                                var ySource = tileHeight * yDestCount;

                                var cloneRect = new Rectangle(xSource, ySource, tileWidth, tileHeight);
                                var cloneBitmap = bmp.Clone(cloneRect, PixelFormat.DontCare);
                                var destRectangle = new Rectangle(0, 0, tileWidth, tileHeight);
                                gOutput.DrawImage(cloneBitmap, destRectangle);
                            }
                            var outputFilename = Path.Combine(
                                Path.GetDirectoryName(inputFile),
                                string.Format("{0}-{1}.png",
                                    Path.GetFileNameWithoutExtension(inputFile),
                                    i.ToString().PadLeft(2, '0')
                                ));
                            output.Save(outputFilename);
                            i++;
                        }
                    }

                }
            }
        }


        /// <summary>
        /// Merge a serie of pictures with another picture (called template) into new files
        /// </summary>
        /// <param name="templateInputFile"></param>
        /// <param name="pictureSerieBaseFileName"></param>
        public static void MergePictureSerieWithTemplate(string templateInputFile, string pictureSerieBaseFileName)
        {
            var searchPattern = pictureSerieBaseFileName.EndsWith("*") ?
                pictureSerieBaseFileName : string.Format("{0}*", pictureSerieBaseFileName);
            var pictureSerie = Directory.GetFiles(
                Path.GetDirectoryName(searchPattern), Path.GetFileName(searchPattern));
            var i = 0;

            using (Bitmap bmpTemplate = Image.FromFile(templateInputFile) as Bitmap)
            {
                foreach (var pictureFileName in pictureSerie)
                {
                    using (Bitmap bmpSerie = Image.FromFile(pictureFileName) as Bitmap)
                    {
                        var width = bmpTemplate.Width;
                        var height = bmpTemplate.Height + bmpSerie.Height;
                        using (var output = new Bitmap(width, bmpTemplate.Height + height))
                        {
                            using (var gOutput = Graphics.FromImage(output))
                            {
                                var destRectangle1 = new Rectangle(
                                        0, 0,
                                        bmpSerie.Width, bmpSerie.Height);
                                gOutput.DrawImage(bmpSerie, destRectangle1);

                                var destRectangle2 = new Rectangle(
                                        0, bmpSerie.Height,
                                        bmpTemplate.Width, bmpTemplate.Height);
                                gOutput.DrawImage(bmpTemplate, destRectangle2);
                            }

                            var outputFilename = Path.Combine(
                                Path.GetDirectoryName(pictureSerieBaseFileName),
                                string.Format("{0}_Modified_{1}.png",
                                    Path.GetFileNameWithoutExtension(pictureFileName),
                                    i.ToString().PadLeft(2, '0')
                                ));
                            output.Save(outputFilename);
                            i++;
                        }
                    }
                }
            }
        }

        public static void CleanNonDeltaFrom2Images(string inputFile1, string inputFile2, Color backgroundColor)
        {
            using (Bitmap bmp1 = Image.FromFile(inputFile1) as Bitmap)
            {
                using (Bitmap bmp2 = Image.FromFile(inputFile2) as Bitmap)
                {
                    if (bmp1.Width != bmp2.Width || bmp1.Height != bmp2.Height)
                    {
                        throw new Exception("Dimensions of the input images do not match");
                    }

                    using (var output = new Bitmap(bmp1.Width, bmp1.Height))
                    {
                        using (var g = Graphics.FromImage(output))
                        {
                            g.Clear(backgroundColor);

                            for (var y = 0; y < bmp1.Height; y++)
                            {
                                for (var x = 0; x < bmp1.Width; x++)
                                {
                                    var inputColor1 = bmp1.GetPixel(x, y);
                                    var inputColor2 = bmp2.GetPixel(x, y);

                                    // Method is very similar than clean delta: reversing backgroundColor & inputColor1 
                                    if (inputColor1 == inputColor2)
                                    {
                                        output.SetPixel(x, y, backgroundColor);
                                    }
                                    else
                                    {
                                        output.SetPixel(x, y, inputColor1);
                                    }
                                }
                            }
                        }

                        var outputFilename = Path.Combine(
                            Path.GetDirectoryName(inputFile1),
                            string.Format("{0}_Modified.png",
                                Path.GetFileNameWithoutExtension(inputFile1))
                            );
                        output.Save(outputFilename);
                    }
                }
            }

        }
    }
}
