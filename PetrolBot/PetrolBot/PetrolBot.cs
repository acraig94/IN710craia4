using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class PetrolBot
    {
        private Graphics botCanvas;
        private Brush botColour;
        private int xPos;
        private int yPos;
        private Ship botShip;
        private int startXPos;
        private int startYPos;
        private int shipXPos;
        private int shipYPos;
        private int botDiameter;
        
        public PetrolBot(Ship botShip, Graphics botCanvas, int startXPos, int startYPos)
        {
            this.botShip = botShip;
            this.botCanvas = botCanvas;
            shipXPos = botShip.XPos;
            shipYPos = botShip.YPos;
            this.startXPos = startXPos;
            this.startYPos = startYPos;
            xPos = startXPos;
            yPos = startYPos;
            botDiameter = 10;
            botColour = new SolidBrush(Color.Blue);

            Ship.ShipEventHandler fullHandler = new Ship.ShipEventHandler(FullOfFuelEvent);
            botShip.FullOfFuelEvent += fullHandler;

            Ship.ShipEventHandler outHandler = new Ship.ShipEventHandler(OutOfFuelEvent);
            botShip.OutOfFuelEvent += outHandler;
        } 

        public void drawBot()
        {
            botCanvas.FillEllipse(botColour, xPos, yPos, botDiameter, botDiameter);
        }

        public void FullOfFuelEvent(object ship, ShipEventArgs e)
        {
            xPos = startXPos;
            yPos = startYPos;
            drawBot();
        }

        public void OutOfFuelEvent(object ship, ShipEventArgs e)
        {
            xPos = e.XPos;
            yPos = e.YPos;
            drawBot();
        }



    }
}
