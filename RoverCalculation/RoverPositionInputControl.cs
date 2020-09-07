using System;
using System.Collections.Generic;
using System.Text;

namespace RoverCalculation
{
    public class RoverPositionInputControl
    {
        public bool roverIsInputControl(string TerrainArea, string Positions, string Instruction)
        {
            try
            {
                char[] trr = TerrainArea.ToCharArray();
                if (trr.Length == 2 && trr[0].Equals(trr[1]))
                {
                    if (Helpers.IsPositiveNumber(trr[0].ToString()) && Helpers.IsPositiveNumber(trr[1].ToString()))
                    {
                       
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                
                
                    string[] _position = Positions.Split(" ");
                    if (_position.Length == 3)
                    {
                        if (Helpers.IsPositiveNumber(_position[0]) && Helpers.IsPositiveNumber(_position[1]) &&

                            Convert.ToInt32(_position[0]) <=Convert.ToInt32(trr[0].ToString()) &&
                            Convert.ToInt32(_position[1]) <= Convert.ToInt32(trr[1].ToString()) &&
                           (_position[2].ToCharArray()[0] == 078 || _position[2].ToCharArray()[0] == 082 || (int)_position[2].ToCharArray()[0] == 083
                           || (int)_position[2].ToCharArray()[0] == 087 || (int)_position[2].ToCharArray()[0] == 069))
                        {
                           
                        }
                        else
                            return false;
                    }
                    else
                        return false;


                char[] _instructions = Instruction.ToCharArray();
                foreach (char _instruction in _instructions)
                {
                    if ((int)_instruction == 076 || (int)_instruction == 077 || (int)_instruction == 082)
                    {

                    }
                    else
                        return false;
                }


              
            }
            catch (Exception)
            {

                return false;
            }
            return true;
           
        }
        


    }

}
