using System.Drawing;
using System.IO;

namespace Scal.SpecialImageTools.UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if(true)
            {
                ImageTool.SplitTilesIntoFiles(@"C:\Users\Pascal\Downloads\Mugen\old_tools\Kof02Um-Italy1\Kof02Um-Italy1-xx-SandPersons-05-RedTopRedPareoWoman.png", 64, 127);
            }


            if (false)
            {
                var initialFileName = @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-BattleMode\Rips\Sftm-BattleMode-Barrels&Flames.png";
                var height = 16;

                ImageTool.MergeMultipleLinesIntoSingle(initialFileName, height);

                var singleLineFileName = @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-BattleMode\Rips\Sftm-BattleMode-Barrels&Flames_Modified.png";
                ImageTool.SplitSingleLineTiles(singleLineFileName, 64, 16, 2, 2);

                ImageTool.MergePictureSerieWithTemplate(
                    @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-BattleMode\Rips\Sftm-BattleMode-Barrels&Flames-Bottom.png",
                    @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-BattleMode\Rips\Sftm-BattleMode-Barrels&Flames-Top*.*");
            }

            // Clean shadaloo flag
            if (false)
            {
                var inputDirectory = @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-Bison\Sftm-Bison-Rips\Screen2\";
                var filenames = new[]
                {
                    "Image00304.bmp",
                    "Image00307.bmp",
                    "Image00310.bmp",
                    "Image00313.bmp",
                    "Image00316.bmp",
                    "Image00616.bmp",
                    "Image00619.bmp",
                    "Image00622.bmp",
                    "Image00625.bmp",
                    "Image00628.bmp",
                    "Image00631.bmp",
                    "Image00634.bmp",
                    "Image00637.bmp",
                    "Image00641.bmp",
                    "Image00643.bmp",
                    "Image00646.bmp",
                };
                var bgFileName = @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-Bison\Sftm-Bison-Rips\Screen2\Image00316.bmp";

                foreach (var filename in filenames)
                {
                    var inputFileName = Path.Combine(inputDirectory, filename);
                    ImageTool.CleanNonDeltaFrom2Images(inputFileName, bgFileName, Color.FromArgb(255, 0, 255));
                }
            }

            // Clean Guile pottrait
            if (false)
            {
                var inputDirectory = @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-Bison\Sftm-Bison-Rips\Screen2\";
                var filenames = new[]
                {
                    "Image00667.bmp",
                    "Image00670.bmp",
                    "Image00673.bmp",
                    "Image00676.bmp",
                    "Image00679.bmp",
                    "Image00682.bmp",
                    "Image00685.bmp",
                    "Image00688.bmp",
                    "Image00691.bmp",
                    "Image00694.bmp",
                    "Image00697.bmp",
                    "Image00700.bmp",
                    "Image00703.bmp",
                    "Image00707.bmp",
                    "Image00709.bmp",
                    "Image00712.bmp",
                    "Image01012.bmp",
                    "Image01015.bmp",
                    "Image01018.bmp",
                    "Image01021.bmp",
                    "Image01024.bmp",
                    "Image01027.bmp",
                    "Image01030.bmp",
                };
                var bgFileName = @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-Bison\Sftm-Bison-Rips\Screen2\Image00712.bmp";

                foreach (var filename in filenames)
                {
                    var inputFileName = Path.Combine(inputDirectory, filename);
                    ImageTool.CleanNonDeltaFrom2Images(inputFileName, bgFileName, Color.FromArgb(255, 0, 255));
                }
            }

            // Clean dictator pottrait
            if (false)
            {
                var inputDirectory = @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-Bison\Sftm-Bison-Rips\Screen2\";
                var filenames = new[]
                {
                    "Image01333.bmp",
                    "Image01336.bmp",
                    "Image01339.bmp",
                    "Image01342.bmp",
                    "Image01348.bmp",
                    "Image01351.bmp",
                    "Image01354.bmp",
                    "Image01357.bmp",
                    "Image01657.bmp",
                    "Image01660.bmp",
                    "Image01663.bmp",
                    "Image01666.bmp",
                    "Image01669.bmp",
                    "Image01672.bmp",
                    "Image01675.bmp",
                    "Image01678.bmp",
                    "Image01681.bmp",
                    "Image01684.bmp",
                    "Image01687.bmp",
                    "Image01690.bmp",
                    "Image01693.bmp",
                    "Image01696.bmp",
                    "Image01699.bmp",
                    "Image01702.bmp",
                    "Image01705.bmp",
                    "Image01708.bmp",
                    "Image01711.bmp",
                    "Image01714.bmp",
                    "Image01717.bmp",
                    "Image01720.bmp",
                    "Image01723.bmp",
                    "Image01726.bmp",
                    "Image01729.bmp",
                    "Image01732.bmp",
                    "Image01735.bmp",
                    "Image01738.bmp",
                    "Image01741.bmp",
                    "Image01744.bmp",
                    "Image01747.bmp",
                    "Image01750.bmp",
                    "Image01753.bmp",
                    "Image01756.bmp",
                    "Image01759.bmp",
                    "Image01762.bmp",
                    "Image01765.bmp",
                    "Image01768.bmp",
                    "Image01771.bmp",
                };
                var bgFileName = @"C:\Users\Pascal\Downloads\Mugen\old_tools\Sftm-Bison\Sftm-Bison-Rips\Screen2\Image01357.bmp";

                foreach (var filename in filenames)
                {
                    var inputFileName = Path.Combine(inputDirectory, filename);
                    ImageTool.CleanNonDeltaFrom2Images(inputFileName, bgFileName, Color.FromArgb(255, 0, 255));
                }
            }
        }
    }
}
