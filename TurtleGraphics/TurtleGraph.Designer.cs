
namespace TurtleGraphics
{
  partial class TurtleGraph
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonDraw = new System.Windows.Forms.Button();
      this.buttonReset = new System.Windows.Forms.Button();
      this.buttonHide = new System.Windows.Forms.Button();
      this.buttonHex = new System.Windows.Forms.Button();
      this.buttonStar = new System.Windows.Forms.Button();
      this.buttonSpiral = new System.Windows.Forms.Button();
      this.buttonSun = new System.Windows.Forms.Button();
      this.buttonTriangle = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonDraw
      // 
      this.buttonDraw.Location = new System.Drawing.Point(12, 12);
      this.buttonDraw.Name = "buttonDraw";
      this.buttonDraw.Size = new System.Drawing.Size(107, 47);
      this.buttonDraw.TabIndex = 0;
      this.buttonDraw.Text = "Draw";
      this.buttonDraw.UseVisualStyleBackColor = true;
      this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
      // 
      // buttonReset
      // 
      this.buttonReset.Location = new System.Drawing.Point(12, 65);
      this.buttonReset.Name = "buttonReset";
      this.buttonReset.Size = new System.Drawing.Size(107, 44);
      this.buttonReset.TabIndex = 1;
      this.buttonReset.Text = "Reset";
      this.buttonReset.UseVisualStyleBackColor = true;
      this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
      // 
      // buttonHide
      // 
      this.buttonHide.Location = new System.Drawing.Point(12, 115);
      this.buttonHide.Name = "buttonHide";
      this.buttonHide.Size = new System.Drawing.Size(107, 45);
      this.buttonHide.TabIndex = 2;
      this.buttonHide.Text = "Hide Turtle";
      this.buttonHide.UseVisualStyleBackColor = true;
      this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
      // 
      // buttonHex
      // 
      this.buttonHex.Location = new System.Drawing.Point(12, 166);
      this.buttonHex.Name = "buttonHex";
      this.buttonHex.Size = new System.Drawing.Size(107, 41);
      this.buttonHex.TabIndex = 3;
      this.buttonHex.Text = "Hexagon";
      this.buttonHex.UseVisualStyleBackColor = true;
      this.buttonHex.Click += new System.EventHandler(this.buttonHex_Click);
      // 
      // buttonStar
      // 
      this.buttonStar.Location = new System.Drawing.Point(12, 213);
      this.buttonStar.Name = "buttonStar";
      this.buttonStar.Size = new System.Drawing.Size(107, 41);
      this.buttonStar.TabIndex = 4;
      this.buttonStar.Text = "Star";
      this.buttonStar.UseVisualStyleBackColor = true;
      this.buttonStar.Click += new System.EventHandler(this.buttonStar_Click);
      // 
      // buttonSpiral
      // 
      this.buttonSpiral.Location = new System.Drawing.Point(12, 260);
      this.buttonSpiral.Name = "buttonSpiral";
      this.buttonSpiral.Size = new System.Drawing.Size(107, 44);
      this.buttonSpiral.TabIndex = 5;
      this.buttonSpiral.Text = "Spiral";
      this.buttonSpiral.UseVisualStyleBackColor = true;
      this.buttonSpiral.Click += new System.EventHandler(this.buttonSpiral_Click);
      // 
      // buttonSun
      // 
      this.buttonSun.Location = new System.Drawing.Point(12, 310);
      this.buttonSun.Name = "buttonSun";
      this.buttonSun.Size = new System.Drawing.Size(107, 39);
      this.buttonSun.TabIndex = 6;
      this.buttonSun.Text = "Sun";
      this.buttonSun.UseVisualStyleBackColor = true;
      this.buttonSun.Click += new System.EventHandler(this.buttonSun_Click);
      // 
      // buttonTriangle
      // 
      this.buttonTriangle.Location = new System.Drawing.Point(12, 355);
      this.buttonTriangle.Name = "buttonTriangle";
      this.buttonTriangle.Size = new System.Drawing.Size(107, 39);
      this.buttonTriangle.TabIndex = 7;
      this.buttonTriangle.Text = "Triangle";
      this.buttonTriangle.UseVisualStyleBackColor = true;
      this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
      // 
      // TurtleGraph
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(726, 401);
      this.Controls.Add(this.buttonTriangle);
      this.Controls.Add(this.buttonSun);
      this.Controls.Add(this.buttonSpiral);
      this.Controls.Add(this.buttonStar);
      this.Controls.Add(this.buttonHex);
      this.Controls.Add(this.buttonHide);
      this.Controls.Add(this.buttonReset);
      this.Controls.Add(this.buttonDraw);
      this.Name = "TurtleGraph";
      this.Text = "Turtle Graphics";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonDraw;
    private System.Windows.Forms.Button buttonReset;
    private System.Windows.Forms.Button buttonHide;
    private System.Windows.Forms.Button buttonHex;
    private System.Windows.Forms.Button buttonStar;
    private System.Windows.Forms.Button buttonSpiral;
    private System.Windows.Forms.Button buttonSun;
    private System.Windows.Forms.Button buttonTriangle;
  }
}

