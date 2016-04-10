using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBot
{
    public partial class Form1 : Form
    {
        const int CANVAS_WIDTH = 300;

        List<Ship> shipList;
        List<PetrolBot> botList;
        Graphics canvas;
        Random rGen;

        public Form1()
        {
            InitializeComponent();

            canvas = CreateGraphics();
            rGen = new Random();
            shipList = new List<Ship>();
            botList = new List<PetrolBot>();
            
            for (int i = 0; i < 5; i++)
            {
                Ship ship = new Ship(rGen.Next(CANVAS_WIDTH), rGen.Next(CANVAS_WIDTH), canvas, rGen);
                shipList.Add(ship);
            }

            for (int i = 0; i < shipList.Count; i++)
            {
                PetrolBot bot = new PetrolBot(shipList[i], canvas, 80 * (i + 1), CANVAS_WIDTH);
                botList.Add(bot);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas.Clear(Color.White);
            foreach (Ship ship in shipList)
            {
                ship.ShipCycle();
            }
            foreach (PetrolBot bot in botList)
            {
                bot.drawBot();
            }
        }
    }
}
