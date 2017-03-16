using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace Pipelining_methods
{
    class clssSqaure
    {
        float Pacxposi, Pacyposi, Pacvec_x;
        double[] Packet_Color;
        public clssSqaure(float Pacxposi, float Pacyposi, float Pacvec_x, double[] Packet_Color)
        {
            this.Pacxposi = Pacxposi;
            this.Pacyposi = Pacyposi;
            this.Pacvec_x = Pacvec_x;
            this.Packet_Color = Packet_Color;
        }
        public void Move()
        {
            Gl.glTranslatef(Pacxposi, Pacyposi, 0);
            DrawPacket();
            Gl.glLoadIdentity();
        }
        public float Packxpos
        {
            get { return Pacxposi; }
            set { Pacxposi = value; }
        }
        public float Packv_X
        {
            get { return Pacvec_x; }
        }
        private void DrawPacket()
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3dv(Packet_Color);
            Gl.glVertex2d(10, 10);
            Gl.glVertex2d(-10, 10);
            Gl.glVertex2d(-10, -10);
            Gl.glVertex2d(10, -10);
            Gl.glEnd();
        }

    }
}
