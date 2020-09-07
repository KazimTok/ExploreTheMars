using RoverCalculation;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarsTest
{
    public class MarsExploreTest
    {
        private readonly RoverPositionInputControl _inputControl;
        private readonly Calculataion _calculation;
        private readonly new List<RoverExplore> _rovers;
        private readonly string Terrain = "55";
        public MarsExploreTest()
        {
            _calculation = new Calculataion();
            _inputControl = new RoverPositionInputControl();
            _rovers = new List<RoverExplore>();

            _rovers.Add(new RoverExplore
            {
                RoverName = "1. Rover",
                Position = "1 2 N",
                Instruction = "LMLMLMLMM",
            });
            _rovers.Add(new RoverExplore
            {
                RoverName = "2. Rover",
                Position = "3 3 E",
                Instruction = "MMRMMRMRRM",
            });
        }


        [Fact]
        public async void Test1()
        {
            foreach (var rover in _rovers)
            {
                  Assert.True(_inputControl.roverIsInputControl(Terrain, rover.Position, rover.Instruction));
            }

            string result =  await _calculation.RoverCoordineAsync("", _rovers);
            Assert.Equal("1 3 N 5 1 E", result);

        }
    }
}
