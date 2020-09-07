using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoverCalculation
{
    public class Calculataion
    {

        public async Task<string> RoverCoordineAsync(string terrainsize, List<RoverExplore> rovers)
        {
            var roverAOutput = await outputRover1CoodineCalculation(rovers[0]);

            var roverBOutput = await outputRover1CoodineCalculation(rovers[1]);

            return roverAOutput + " " + roverBOutput;
        }

        public async Task<string> outputRover1CoodineCalculation(RoverExplore rover)
        {
            string outputRoversPositions = "";

            //int MaxX = terrainSize.ToCharArray()[0];
            //int MaxY = terrainSize.ToCharArray()[1];


            int coordinex = int.Parse(rover.Position.Split(' ')[0]);
            int coordiney = int.Parse(rover.Position.Split(' ')[1]);
            string point = rover.Position.Split(' ')[2];

            int i = 0;
            char[] charArr = rover.Instruction.ToCharArray();
            foreach (char ch in charArr)
            {
                if (ch == 'M')
                {
                    char direction = i > 0 ? charArr[i - 1] : 'M';
                    string pointchar = point + direction;
                    if (pointchar == "NR" || pointchar == "SL" || pointchar == "EM")
                    {
                        coordinex += 1;
                        point = "E";
                    }
                    if (pointchar == "NL" || pointchar == "SR" || pointchar == "WM")
                    {
                        coordinex -= 1;
                        point = "W";
                    }
                    if (pointchar == "WR" || pointchar == "EL" || pointchar == "NM")
                    {
                        coordiney += 1;
                        point = "N";
                    }
                    if (pointchar == "WL" || pointchar == "ER" || pointchar == "SM")
                    {
                        coordiney -= 1;
                        point = "S";
                    }
                }
                else if (i + 1 == charArr.Length || charArr[i + 1] != 'M')
                {
                    string dg = point + ch.ToString();

                    if ((dg == "NR") || (dg == "SL"))
                        point = "E";
                    if ((dg == "NL") || (dg == "SR"))
                        point = "W";
                    if ((dg == "WR") || (dg == "EL"))
                        point = "N";
                    if ((dg == "WL") || (dg == "ER"))
                        point = "S";
                }
                i++;
            }
            outputRoversPositions = coordinex + " " + coordiney + " " + point;

            return outputRoversPositions;


        }
    }


}
