using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Pipelining_methods
{
    public partial class FrmMain : Form
    {
        
        #region Variables
        int winwidth, winheight;
        int WindowSize = 0;
        double[] color_Violet = { 0, 1, 1 };//Packet
        double[] color_Red = { 1, 0, 0 };//ack
        double durtimeout, drlen = 10;
        float pacspeed = 18;
        bool send_file = true;
        bool continue_receive = true;
        DateTime dtstart;        
        Queue QueueAcks = new Queue();
        Queue QueuePacs = new Queue();
        clssSqaure objPacket, objAck;
        List<clssSqaure> lst_clssSqaure = new List<clssSqaure>();
       
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            #region Initialization
            lst_clssSqaure.Clear();
            objPacket = new clssSqaure(10 - winwidth, 20, 1, color_Violet);
            lst_clssSqaure.Add(objPacket);
            send_file = true;
            dtstart = DateTime.Now;
            if (txt_Timeout.Text != string.Empty)
                durtimeout = int.Parse(txt_Timeout.Text);
            else
                durtimeout = 3;//default value
            #endregion
            if (rbn_goback_N.Checked)
            
            {
                if (!continue_receive)
                {
                    continue_receive = true;
                }

                //modify window size to the count of remaining items
                WindowSize = Convert.ToInt32(num_win_size.Value);
                if (WindowSize > Lstbx_Sender.Items.Count)
                    WindowSize = Lstbx_Sender.Items.Count;
                for (int i = 0; i < WindowSize; i++)
                {
                    QueuePacs.Enqueue(Lstbx_Sender.Items[i]);
                }
                timer1.Enabled = simpleOpenGlControl1.Visible = true;
            }
            

            else
            {
            
                if (!continue_receive)
                {
                    continue_receive = true;
                }

                //modify window size to the count of remaining items
                WindowSize = Convert.ToInt32(num_win_size.Value);
                if (WindowSize > Lstbx_Sender.Items.Count)
                    WindowSize = Lstbx_Sender.Items.Count;
                for (int i = 0; i < WindowSize; i++)
                {
                    QueuePacs.Enqueue(Lstbx_Sender.Items[i]);
                }
            
            timer1.Enabled = simpleOpenGlControl1.Visible = true;
            }

        }

        

        private void txt_R_Min_KeyPress(object sender, KeyPressEventArgs e)
        {
            //numbers only
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            simpleOpenGlControl1.AutoSwapBuffers = true;
            winwidth = simpleOpenGlControl1.Width / 2;
            winheight = simpleOpenGlControl1.Height / 2;
            initializeGraphix();
            Reset();
        }

        private void initializeGraphix()
        {
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(-winwidth, winwidth, -winheight, winheight);
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            simpleOpenGlControl1.Invalidate();
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();
            foreach (clssSqaure objclssSqaure in lst_clssSqaure)
            {
                objclssSqaure.Move();
            }
            transform();
            Gl.glFlush();
        }

        private void transform()
        {
            TimeSpan tsSend_Time = DateTime.Now - dtstart;
            lbl_TimeElapsed.Text = tsSend_Time.ToString();
           
           if (rbn_goback_N.Checked)
            {
                #region Go Back N
                #region Explanation
                /*
                 * IN go back n if a packet is lost then the following packets will be resent .
                 */
                #endregion
                SlidingWindow(tsSend_Time, true  /*Is it GoBackN*/);
                
                #endregion
            }
            else
            {
                #region Selective Repeat
                #region Explanation
                /* 
                 * In selective repeat only unacknowledged packet will be resent unlike goback n which will send all packets  from unacknowledged packets
                 * */
                #endregion
                SlidingWindow(tsSend_Time, false /*Is it GoBackN*/);
                #endregion
            }
        }

        private void SlidingWindow(TimeSpan tsSend_Time, bool bIsGoBackN)
        {
            object[] arr_Frames = QueuePacs.ToArray();
            if (QueuePacs.Count != 0)//Sending Frames
            {
                objPacket.Packxpos += pacspeed * objPacket.Packv_X;
                lbl_sender.Text = "Sending " + arr_Frames[0].ToString();
                lbl_receiver.Text = "Receiving " + arr_Frames[0].ToString();

                if (objPacket.Packxpos + drlen > winwidth)//frame reached Recceiver
                {
                    
                    object Objreceivedframe = QueuePacs.Dequeue();
                    if (tsSend_Time.Seconds < durtimeout) //within time
                    {

                        
                       
                        if (continue_receive)//sending was not interrupted,receive frames normally
                        {
                            
                            
                            Lstbx_Receiver.Items.Add(Objreceivedframe);
                            Lstbx_Log.Items.Add(Objreceivedframe.ToString() + " Received");
                            Lstbx_Log.Items.Add("Time elapsed " + tsSend_Time.Milliseconds +" MilliSeconds");                                                   
                            QueueAcks.Enqueue(Objreceivedframe);

                            objAck = new clssSqaure(winwidth, -20, -1, color_Red);//Send Ack
                            lst_clssSqaure.Add(objAck);
                        }
                    }
                    else//frame exceeded time
                    {
                        Lstbx_Log.Items.Add(Objreceivedframe.ToString() + " Timed out");
                        if (bIsGoBackN && continue_receive)
                        {
                            Lstbx_Log.Items.Add("Receiver stopped receiving");
                            Lstbx_Log.Items.Add("Time elapsed " + tsSend_Time.Milliseconds +"MilliSeconds");
                            continue_receive = false;//stop receiving
                        }
                    }
                    dtstart = DateTime.Now; //reset time
                    objPacket.Packxpos = 10 - winwidth; //reset Frame position
                }

            }
            if (QueueAcks.Count != 0)//Sending Ack
            {
                objAck.Packxpos += pacspeed * 2 * objAck.Packv_X;
                if (((objAck.Packxpos - drlen + 10) < (winwidth * -1)))//Ack arrived to Tx
                {
                    int counter;
                    Lstbx_Log.Items.Add("Hurray Acknowledge received");//h
                    counter = Lstbx_Log.Items.Count / 3;
                    Lstbx_Log.Items.Add("Total no: of packets received  " + counter); 
                    Lstbx_Sender.Items.Remove(QueueAcks.Dequeue());
                    lst_clssSqaure.Remove(objAck);
                }
            }
            if (QueuePacs.Count == 0 && QueueAcks.Count == 0)
            {
                lbl_receiver.Text = lbl_sender.Text = "Ready";
                lbl_TimeElapsed.Text = string.Empty;
            }
        }

        private void btn_Dec_Click(object sender, EventArgs e)
        {
            if (pacspeed - 2 > 0)
                pacspeed -= 2;
        }

        private void btn_Inc_Click(object sender, EventArgs e)
        {
            pacspeed += 2;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            Lstbx_Sender.Items.Clear();
            Lstbx_Receiver.Items.Clear();
            Lstbx_Log.Items.Clear();
            lst_clssSqaure.Clear();
            QueueAcks.Clear();
            QueuePacs.Clear();
            lbl_TimeElapsed.Text = string.Empty;
            timer1.Enabled = false;
            pacspeed = 18;
            for (int i = 1 ; i < 15; i++)
            {
                Lstbx_Sender.Items.Add("Packet" + i);
            }
            lbl_receiver.Text = lbl_sender.Text = "Ready";
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {

        }

        private void LBx_Log_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBx_Sender_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
