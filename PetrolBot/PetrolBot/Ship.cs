using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class Ship
    {
        private const int CANVAS_WIDTH = 300;
        private int petrol;
        private int Petrol { get { return petrol; } set { petrol = value;} }
        private Random rGen;
        private Graphics shipCanvas;
        private Color shipColour;
        private Brush shipBrush;
        // ship location
        private int xPos;
        public int XPos { get { return xVel; } set { xVel = value; } }
        private int yPos;
        public int YPos { get { return yVel; } set { yVel = value; } }
        private int shipSize;
        private EShipState shipState;
        // ship velocity
        private int xVel;
        public int XVel { get { return xVel; } set { xVel = value; } }
        private int yVel;
        public int YVel { get { return yVel; } set { yVel = value; } }

        public delegate void ShipEventHandler(object o, ShipEventArgs Sea);
        public event ShipEventHandler FullOfFuelEvent;
        public event ShipEventHandler OutOfFuelEvent;

        public Ship(int xPos, int yPos, Graphics shipCanvas, Random rGen)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.shipCanvas = shipCanvas;
            this.rGen = rGen;
            xVel = rGen.Next(10);
            yVel = rGen.Next(10);
            shipSize = 30;
            petrol = 99;
            shipState = EShipState.WANDERING;
            shipColour = Color.Red;
            shipBrush = new SolidBrush(shipColour);

        }

        public void DrawShip()
        {
            shipBrush = new SolidBrush(shipColour);
            shipCanvas.FillRectangle(shipBrush, xPos, yPos, shipSize, shipSize);
        }

        public void MoveShip()
        {
            xPos += xVel;
            yPos += yVel;
            // boundary control
            if (xPos <= 0)
            {
                xPos = 0;
                xVel *= -1;
            }
            if (yPos <= 0)
            {
                yPos = 0;
                yVel *= -1;
            }
            if (xPos >= CANVAS_WIDTH - shipSize)
            {
                xPos = CANVAS_WIDTH - shipSize;
                xVel *= -1;
            }
            if (yPos >= CANVAS_WIDTH - shipSize)
            {
                yPos = CANVAS_WIDTH - shipSize;
                yVel *= -1;
            }            
        }

        public void OnFullOfFuelEvent()
        {
            ShipEventArgs shipEventArgs = new ShipEventArgs(xPos, yPos);
            if (FullOfFuelEvent != null)
            {
                FullOfFuelEvent(this, shipEventArgs);
            }
        }

        public void OnOutOfFuelEvent()
        {
            ShipEventArgs shipEventArgs = new ShipEventArgs(xPos, yPos);
            if (OutOfFuelEvent != null)
            {
                OutOfFuelEvent(this, shipEventArgs);
            }
        }

        public void Refuel()
        {
            petrol += 10;
        }

        public void ShipCycle()
        {

            if (shipState == EShipState.REFUELING)
            {                
                if (petrol >= 90)
                {
                    OnFullOfFuelEvent();
                    shipState = EShipState.WANDERING;
                }
                else
                {
                    OnOutOfFuelEvent();
                    DrawShip();
                    Refuel();
                }
            }
            else
            {
                if (petrol <= 0)
                {
                    shipState = EShipState.REFUELING;
                }
                else
                {
                    UsePetrol();
                    MoveShip();
                    DrawShip();
                }
            }
        }

        public void UsePetrol()
        {        
            shipColour = Color.FromArgb((255*petrol)/100, 0, 0);
            petrol -= 5;
        }



    }


}
