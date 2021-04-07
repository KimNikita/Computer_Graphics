using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Drawing.Imaging;

namespace Task_2
{
  class View
  {
    Bin bin;
    Bitmap textureImage;
    int VBOtexture;
    int min = 0;
    int max = 2000;

    View(Bin bin)
    {
      this.bin = bin;
    }

    public void SetupView(int width, int height)
    {
      GL.ShadeModel(ShadingModel.Smooth);
      GL.MatrixMode(MatrixMode.Projection);
      GL.LoadIdentity();
      GL.Ortho(0, bin.X, bin.Y, -1, 1);
      GL.Viewport(0, 0, width, height);
    }

    private int Clamp(int value, int min, int max)
    {
      if (value < min)
        return min;
      if (value > max)
        return max;
      return value;
    }

    Color TransferFunction(short value)
    {
      int newVal = Clamp((value - min) * 255 / (max - min), 0, 255);
      return Color.FromArgb(255, newVal, newVal, newVal);
    }

    public void DrawQuads(int layerNumber)
    {
      GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
      GL.Begin(BeginMode.Quads);
      for (int x_coord = 0; x_coord < bin.X - 1; x_coord++)
        for (int y_coord = 0; y_coord < bin.Y - 1; y_coord++)
        {
          short value;
          //1
          value = bin.array[x_coord + y_coord * bin.X + layerNumber * bin.X * bin.Y];
          GL.Color3(TransferFunction(value));
          GL.Vertex2(x_coord, y_coord);
          //2
          value = bin.array[x_coord + (y_coord + 1) * bin.X + layerNumber * bin.X * bin.Y];
          GL.Color3(TransferFunction(value));
          GL.Vertex2(x_coord, y_coord + 1);
          //3
          value = bin.array[(x_coord + 1) + (y_coord + 1) * bin.X + layerNumber * bin.X * bin.Y];
          GL.Color3(TransferFunction(value));
          GL.Vertex2(x_coord + 1, y_coord + 1);
          //4
          value = bin.array[(x_coord + 1) + y_coord * bin.X + layerNumber * bin.X * bin.Y];
          GL.Color3(TransferFunction(value));
          GL.Vertex2(x_coord + 1, y_coord);
        }
      GL.End();
    }

    public void Load2Dexture()
    {
      GL.BindTexture(TextureTarget.Texture2D, VBOtexture);
      BitmapData data = textureImage.LockBits(new System.Drawing.Rectangle(0, 0, textureImage.Width, textureImage.Height),
        ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

      GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
        OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);

      textureImage.UnlockBits(data);

      GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter,
        (int)TextureMinFilter.Linear);
      GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter,
        (int)TextureMagFilter.Linear);

      ErrorCode Er = GL.GetError();
      string str = Er.ToString();
    }

    public void generateTextureImage(int layerNumber)
    {
      textureImage = new Bitmap(bin.X, bin.Y);
      for (int i = 0; i < bin.X; i++)
        for (int j = 0; j < bin.Y; j++)
        {
          int pixelNumber = i + j * bin.X + layerNumber * bin.X * bin.Y;
          textureImage.SetPixel(i, j, TransferFunction(bin.array[pixelNumber]));
        }
    }

    internal void SetTFMax(int max)
    {
      this.max = max;
    }

    internal void SetTFMin(int min)
    {
      this.min = min;
    }

    public void DrawTexture()
    {
      GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
      GL.Enable(EnableCap.Texture2D);
      GL.BindTexture(TextureTarget.Texture2D, VBOtexture);
      GL.Begin(BeginMode.Quads);
      GL.Color3(Color.White);
      GL.TexCoord2(0f, 0f);
      GL.Vertex2(0, 0);
      GL.TexCoord2(0f, 1f);
      GL.Vertex2(0, bin.Y);
      GL.TexCoord2(1f, 1f);
      GL.Vertex2(bin.X, bin.Y);
      GL.TexCoord2(1f, 0f);
      GL.Vertex2(bin.X, 0);
      GL.End();
      GL.Disable(EnableCap.Texture2D);
    }
  }
}
