using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace TurtleGraphics
{
  public partial class TurtleGraph : Form
  {
    public TurtleGraph()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void buttonDraw_Click(object sender, EventArgs e)
    {
     // Turtle.Delay = 200;

      Turtle.Rotate(30);
      Turtle.Forward(200);
      Turtle.Rotate(120);
      Turtle.Forward(200);
      Turtle.Rotate(120);
      Turtle.Forward(200);

      Turtle.Rotate(-30);
      Turtle.PenUp();
      Turtle.Backward(50);
      Turtle.PenDown();
      Turtle.Backward(100);
      Turtle.PenUp();
      Turtle.Forward(150);
      Turtle.PenDown();
      Turtle.Rotate(30);

    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
      Turtle.Reset();
    }

    private void buttonHide_Click(object sender, EventArgs e)
    {
      if (Turtle.ShowTurtle)
      {
        Turtle.ShowTurtle = false;
        this.buttonHide.Text = "Show Turtle";
      }
      else
      {
        Turtle.ShowTurtle = true;
        this.buttonHide.Text = "Hide turtle";
      }
    }

    private void buttonHex_Click(object sender, EventArgs e)
    {
      for (int i = 1; i <= 6; i++)
      {
        Turtle.Forward(100);
        Turtle.Rotate(60);
      }
      
    }

    private void buttonStar_Click(object sender, EventArgs e)
    {
      for (int i = 1; i <= 5; i++)
      {
        Turtle.PenColor = Color.DarkGreen;
        Turtle.Forward(200);
        Turtle.Rotate(144);
      }
    }

    private void buttonSpiral_Click(object sender, EventArgs e)
    {
    
      int n = 10;
      for (int i = 1; i <= 20; i++)
      {
        Turtle.Forward(n);
        Turtle.Rotate(60);
        n = n + 10;
               
      }
    }

    private void buttonSun_Click(object sender, EventArgs e)
    {
      for (int i = 1; i <= 36; i++)
      {
        Turtle.Forward(250);
        Turtle.Rotate(170);
        Turtle.Forward(250);
        Turtle.Rotate(170);
      }
    }

    private void buttonTriangle_Click(object sender, EventArgs e)
    {
      int n = 10;
      for (int i = 1; i <= 20; i++)
      {
        Turtle.PenColor = Color.Red;
        Turtle.Forward(n);
        Turtle.Rotate(120);
        n = n + 10;

      }
    }
  }
}
