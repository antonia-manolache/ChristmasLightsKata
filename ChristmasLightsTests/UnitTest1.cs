using ChristmasLightsKata.Models;

namespace ChristmasLightsTests
{
    public class Tests
    {
        private ChristmasLights _christmasLights;

        [SetUp]
        public void Setup()
        {
            _christmasLights = new ChristmasLights();

        }

        [Test]
        public void Grid_SizeIs1000()
        {
           
            //Assert
            Assert.AreEqual(1000, _christmasLights.Grid.GetLength(0));
            Assert.AreEqual(1000, _christmasLights.Grid.Length/_christmasLights.Grid.GetLength(0));

        }

        [Test]
        public void WhenNewInstance_AllLights_AreOff()
        {
            foreach(int light in _christmasLights.Grid)
            {
                Assert.AreEqual(0, light);
            }
        }

        [Test]
        public void TurnOn_SingleLight_WorksAsExpected()
        {

            //Act
            _christmasLights.TurnOn(0, 0, 0, 0);

            //Assert
            Assert.AreEqual(1, _christmasLights.Grid[0, 0]);

        }

        [Test]
        public void TurnOn_SingleLightAlreadyTurnedOn_WorksAsExpected()
        {

            //Act
            _christmasLights.Grid[0, 0] = 1;
            _christmasLights.TurnOn(0, 0, 0, 0);


            //Assert
            Assert.AreEqual(1, _christmasLights.Grid[0, 0]);

        }

        [Test]
        public void TurnOn_MoreLights_WorksAsExpected()
        {

            //Act
            _christmasLights.TurnOn(0, 0, 499, 499);

            //Assert
            for(int i=0;i<=499;i++)
            {
                for(int j=0;j<=499;j++)
                {
                    Assert.AreEqual(1, _christmasLights.Grid[i, j]);
                }
            }
            

        }

        [Test]
        public void TurnOn_AllLights_WorksAsExpected()
        {

            //Act
            _christmasLights.TurnOn(0, 0, 999, 999);

            //Assert
            foreach(int light in _christmasLights.Grid)
            {
                Assert.AreEqual(1, light);
            }
            


        }

        [Test]
        public void TurnOff_SingleLight_WorksAsExpected()
        {

            //Act
            _christmasLights.TurnOn(0, 0, 0, 0);
            _christmasLights.TurnOff(0, 0, 0, 0);

            //Assert
            Assert.AreEqual(0, _christmasLights.Grid[0, 0]);

        }

        [Test]
        public void TurnOff_MoreLights_WorksAsExpected()
        {

            //Act
            _christmasLights.TurnOn(0, 0, 499, 499);
            _christmasLights.TurnOff(0, 0, 499, 499);

            //Assert
            for (int i = 0; i <= 499; i++)
            {
                for (int j = 0; j <= 499; j++)
                {
                    Assert.AreEqual(0, _christmasLights.Grid[i, j]);
                }
            }


        }

        [Test]
        public void TurnOff_AllLights_WorksAsExpected()
        {

            //Act
            _christmasLights.TurnOn(0, 0, 999, 999);
            _christmasLights.TurnOff(0, 0, 999, 999);

            //Assert
            foreach (int light in _christmasLights.Grid)
            {
                Assert.AreEqual(0, light);
            }



        }

        [Test]
        public void ToggleOn_SingleLight_WorksAsExpected()
        {

            //Act
            _christmasLights.Toggle(0, 0, 0, 0);

            //Assert
            Assert.AreEqual(1, _christmasLights.Grid[0, 0]);

        }

        [Test]
        public void ToggleOn_MoreLights_WorksAsExpected()
        {

            //Act
            _christmasLights.Toggle(0, 0, 499, 499);

            //Assert
            //Assert
            for (int i = 0; i <= 499; i++)
            {
                for (int j = 0; j <= 499; j++)
                {
                    Assert.AreEqual(1, _christmasLights.Grid[i, j]);
                }
            }

        }

        [Test]
        public void ToggleOn_AllLights_WorksAsExpected()
        {

            //Act
            _christmasLights.Toggle(0, 0, 999, 999);

            //Assert
            //Assert
            for (int i = 0; i <= 999; i++)
            {
                for (int j = 0; j <= 999; j++)
                {
                    Assert.AreEqual(1, _christmasLights.Grid[i, j]);
                }
            }

        }


        [Test]
        public void ToggleOff_SingleLight_WorksAsExpected()
        {

            //Act
            _christmasLights.Grid[0, 0] = 1;
            _christmasLights.Toggle(0, 0, 0, 0);

            //Assert
            Assert.AreEqual(0, _christmasLights.Grid[0, 0]);

        }

        
        [Test]
        public void ToggleOff_MoreLights_WorksAsExpected()
        {

            //Act
            _christmasLights.TurnOn(0, 0, 499, 499);
            _christmasLights.Toggle(0, 0, 499, 499);

            //Assert
            //Assert
            for (int i = 0; i <= 499; i++)
            {
                for (int j = 0; j <= 499; j++)
                {
                    Assert.AreEqual(0, _christmasLights.Grid[i, j]);
                }
            }

        }

        [Test]
        public void ToggleOff_AllLights_WorksAsExpected()
        {

            //Act
            _christmasLights.TurnOn(0, 0, 999, 999);
            _christmasLights.Toggle(0, 0, 999, 999);

            //Assert
            //Assert
            for (int i = 0; i <= 999; i++)
            {
                for (int j = 0; j <= 999; j++)
                {
                    Assert.AreEqual(0, _christmasLights.Grid[i, j]);
                }
            }

        }

        [Test]
        public void Toggle_Lights_WorksAsExpected()
        {

            //Act
            _christmasLights.TurnOn(0, 0, 499, 499);
            _christmasLights.Toggle(0, 0, 999, 999);

            //Assert
            //Assert
            for (int i = 0; i <= 499; i++)
            {
                for (int j = 0; j <= 499; j++)
                {
                    Assert.AreEqual(0, _christmasLights.Grid[i, j]);
                }
            }
            for (int i = 500; i <= 999; i++)
            {
                for (int j = 500; j <= 999; j++)
                {
                    Assert.AreEqual(1, _christmasLights.Grid[i, j]);
                }
            }

        }

        [Test]
        public void Toggle_MixedLights_WorksAsExpected()
        {

            //Act
            _christmasLights.Grid[0, 0] = 1;
            _christmasLights.Grid[0, 4] = 1;
            _christmasLights.Grid[0, 9] = 1;

            _christmasLights.Toggle(0, 0, 0, 10);

            Assert.AreEqual(0, _christmasLights.Grid[0, 0]);

            //Assert
            for(int i = 1; i <4;i++)
            {
                Assert.AreEqual(1, _christmasLights.Grid[0, i]);
            }

            Assert.AreEqual(0, _christmasLights.Grid[0, 4]);

            for (int i = 5; i < 9; i++)
            {
                Assert.AreEqual(1, _christmasLights.Grid[0, i]);
            }

            Assert.AreEqual(0, _christmasLights.Grid[0, 9]);

        }

    }
}