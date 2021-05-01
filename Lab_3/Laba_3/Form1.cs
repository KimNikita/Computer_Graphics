using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    int RayTracingProgramID;
    int RayTracingVertexShader;
    int RayTracingFragmentShader;

    //private static void Resize(int width, int height)
    //{
    //  if (height == 0)
    //  {
    //    height = 1;
    //  }
    //  GL.Viewport(0, 0, width, height);
    //}

    private static bool Init()
    {
      GL.Enable(EnableCap.ColorMaterial);
      GL.ShadeModel(ShadingModel.Smooth);

      GL.Enable(EnableCap.DepthTest);
      GL.Enable(EnableCap.CullFace);

      GL.Enable(EnableCap.Lighting);
      GL.Enable(EnableCap.Light0);

      GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);

      return true;
    }

    private bool InitShaders()
    {
      RayTracingProgramID = GL.CreateProgram();
      loadShader("..\\..\\Shaders\\raytracing.vert", ShaderType.VertexShader, RayTracingProgramID, out RayTracingVertexShader);
      loadShader("..\\..\\Shaders\\raytracing.frag", ShaderType.FragmentShader, RayTracingProgramID, out RayTracingFragmentShader);

      GL.LinkProgram(RayTracingProgramID);
      Console.WriteLine(GL.GetProgramInfoLog(RayTracingProgramID));
      GL.Enable(EnableCap.Texture2D);
      return true;
    }

    void loadShader(String filename, ShaderType type, int program, out int address)
    {
      address = GL.CreateShader(type);
      using (System.IO.StreamReader sr = new StreamReader(filename))
      {
        GL.ShaderSource(address, sr.ReadToEnd());
      }
      GL.CompileShader(address);
      GL.AttachShader(program, address);
      Console.WriteLine(GL.GetShaderInfoLog(address));
    }

    private void Draw()
    {
      GL.ClearColor(Color.AliceBlue);
      GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
      GL.UseProgram(RayTracingProgramID);

      openGlControl.SwapBuffers();
      GL.UseProgram(0);
    }

    private void openGlControl_Load(object sender, EventArgs e)
    {
      Draw();
    }

    private void openGlControl_Paint(object sender, PaintEventArgs e)
    {
      Init();
      //Resize(openGlControl.Width, openGlControl.Height);
      InitShaders();
    }

    //private void openGlControl_Resize(object sender, EventArgs e)
    //{
    //  Resize(openGlControl.Width, openGlControl.Height);
    //}

    //private void Form1_ClientSizeChanged(object sender, EventArgs e)
    //{
    //  openGlControl.Width = this.ClientRectangle.Width - 24;
    //  openGlControl.Height = this.ClientRectangle.Height - 24;
    //}
  }
}
