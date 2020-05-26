using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCNTT_NguyenVanDan_16151405
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }

         Map map = new Map();
        int[] ovitri = new int[20];
        
        public struct canh
        {
            public canh(Pointsss pointsssNode1, Pointsss pointsssNode2) : this()
            {
                this.diem1 = pointsssNode1;
                this.diem2 = pointsssNode2;
            }

            public Pointsss diem1 { get; set; }
            public Pointsss diem2 { get; set; }
        }
        List<canh> lstcanh = new List<canh>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool checkcatnhau(Pointsss p1 , Pointsss p2 , Pointsss p3 , Pointsss p4)
        {
            float a = (float)(p1.Y - p2.Y) /(float) (p1.X - p2.X);
            float b = (float)p1.Y - a * (float)p1.X;
            var hs34 = (p3.Y - a * p3.X + b) * (p4.Y - a * p4.X + b);

            float a34 = (float)(p3.Y - p4.Y) / (float)(p3.X - p4.X);
            float b34 = (float)p3.Y - a * (float)p3.X;
            var hs12 = (p1.Y - a34 * p1.X + b34) * (p2.Y - a34 * p2.X + b34);
            if (hs34 < -0.0001 && hs12 < -0.0001) return false;
            return true;

        }
        private bool checkcatlistcanh(Pointsss P1 , Pointsss P2)
        {
            if (lstcanh.Count == 0) return true;
            foreach( var i in lstcanh)
            {
                if (checkcatnhau(P1, P2, i.diem1, i.diem2) == false) return false;
            }
            return true;
        }
        private void random_Click(object sender, EventArgs e)
        {
            lstcanh = new List<canh>();
            var sodiem = (int)Numnode.Value;
            var socanh = (int)NumEdge.Value;
            var camdem = (int)Math.Sqrt(sodiem);
            Dictionary<int, List<Node>> dictnode = new Dictionary<int, List<Node>>();
            if (socanh > sodiem * (sodiem - 1))
                socanh = sodiem * (sodiem - 1);
            var rand = new Random();
            map = new Map();
            for(int i = 0; i < sodiem; i++)
            {
                var node = new Node();
               // var arrdicnode = rand.Next(0, camdem);
                node.PointsssNode.Id = i;
                //if(arrdicnode == 0)
                //    node.PointsssNode.X = pictureBox1.Width * 1 / camdem;
                //else
                // 
                int ww = rand.Next(0, 5);
                int hh = rand.Next(0, 4);
                while(ovitri[ww*4 + hh] > 2)
                {
                    ww = rand.Next(0, 5);
                    hh = rand.Next(0, 4);
                }

                node.PointsssNode.X = rand.Next(ww*pictureBox1.Width/5, (ww+1)*pictureBox1.Width/5);
                node.PointsssNode.Y = rand.Next(hh* pictureBox1.Height/4, (hh+1)*pictureBox1.Height/4);
                //dictnode[arrdicnode].Add(node);
                map.lstNode.Add(node);
            }
            while(socanh > 0)
            {
                var i = rand.Next(0, sodiem);
                var j = rand.Next(0, sodiem);
                if(i != j)
                {
                    
                    if (!map.lstNode[i].Connecttions.Contains(map.lstNode[j]) && checkcatlistcanh(map.lstNode[i].PointsssNode , map.lstNode[j].PointsssNode) && map.lstNode[i].Connecttions.Count +map.lstNode[i].LastConnecttions.Count < 5) {
                        map.lstNode[i].Connecttions.Add(map.lstNode[j]);
                        map.lstNode[j].LastConnecttions.Add(map.lstNode[i]);
                        lstcanh.Add(new canh(map.lstNode[i].PointsssNode , map.lstNode[i].PointsssNode));
                        socanh--;
                    }
                   
                }
            }
            draw();
            
        }
        int tt;
        
        void draw()
        {
            Bitmap bmp = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
          
           

            foreach (var i in map.lstNode)
            {
                 g.DrawEllipse(Pens.Red, new Rectangle((int)i.PointsssNode.X - 5, (int)i.PointsssNode.Y - 5, 2*5, 2*5));
                using (Font font1 = new Font("Times New Roman", 24, FontStyle.Bold, GraphicsUnit.Pixel))
                {
                    PointF pointF1 = new PointF((int)i.PointsssNode.X - 10, (int)i.PointsssNode.Y + 10);
                    g.DrawString((i.PointsssNode.Id+1).ToString(), font1, Brushes.Red, pointF1);
                }
                var pen = new Pen(Brushes.Gray, 3);
                if (i.Connecttions.Count != 0) {
                    var p1 = new PointF((float)i.PointsssNode.X, (float)i.PointsssNode.Y);
                    foreach (var j in i.Connecttions)
                    {
                        

                        var p2 = new PointF((float)j.PointsssNode.X, (float)j.PointsssNode.Y);
                        var pdd = new PointF(19 * (p2.X - p1.X) / 20 + p1.X, 19 * (p2.Y - p1.Y) / 20 + p1.Y);
                        g.DrawLine(pen, p1, p2);
                        g.DrawLine(new Pen(Brushes.Red , 3), pdd, p2);
                        using (Font font1 = new Font("Arial", 8, FontStyle.Italic, GraphicsUnit.Pixel))
                        {
                            
                            PointF pointF1 = new PointF((int)(i.PointsssNode.X+j.PointsssNode.X)/2 + 10, (int)(i.PointsssNode.Y + j.PointsssNode.Y) / 2 - 10);
                            g.DrawString(Pointsss.Distance(i.PointsssNode,j.PointsssNode).ToString("#0.00") +  "px", font1, Brushes.Black, pointF1);
                        }


                    }
                }
                if (i == map.StartNode)
                    g.FillEllipse(Brushes.Yellow, new Rectangle((int)i.PointsssNode.X - 10, (int)i.PointsssNode.Y - 10, 2 * 10, 2 * 10));
                if (i == map.EndNode)
                    g.FillEllipse(Brushes.BlueViolet, new Rectangle((int)i.PointsssNode.X - 10, (int)i.PointsssNode.Y - 10, 2 * 10, 2 * 10));
                if(i.PointsssNode.isclick == true)
                    g.FillEllipse(Brushes.Black, new Rectangle((int)i.PointsssNode.X - 10, (int)i.PointsssNode.Y - 10, 2 * 10, 2 * 10));
            }

            if (map.ShortesPath.Count > 0)
            {   
                foreach (var i in map.ShortesPath)
                {
                    if(i != map.EndNode && i !=map.StartNode)
                    g.FillEllipse(Brushes.Black, new Rectangle((int)i.PointsssNode.X - 5, (int)i.PointsssNode.Y - 5, 2*5, 2*5));
                }
                var pen = new Pen(Brushes.YellowGreen, 2);
                for (int i = 0; i < map.ShortesPath.Count - 1; i++)
                {
                    var p1 = new PointF((float)map.ShortesPath[i].PointsssNode.X, (float)map.ShortesPath[i].PointsssNode.Y);
                    var p2 = new PointF((float)map.ShortesPath[i + 1].PointsssNode.X, (float)map.ShortesPath[i + 1].PointsssNode.Y);
                    g.DrawLine(pen, p1, p2);
                }
            }
            foreach (var i in map.lstNode)
            {
                if (i.Connecttions.Count != 0)
                {
                    var p1 = new PointF((float)i.PointsssNode.X, (float)i.PointsssNode.Y);
                    foreach (var j in i.Connecttions)
                    {


                        var p2 = new PointF((float)j.PointsssNode.X, (float)j.PointsssNode.Y);
                        var edge = (float)Pointsss.Distance(i.PointsssNode, j.PointsssNode);
                        var pdd = new PointF((edge-15) * (p2.X - p1.X) / edge + p1.X, (edge-15) * (p2.Y - p1.Y) / edge + p1.Y);
                        g.DrawLine(new Pen(Brushes.Red, 4), pdd, p2);

                    }
                }
            }

            pictureBox1.Image = bmp;
            g.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < map.lstNode.Count; i++)
            {
                map.lstNode[i].Visited = false;
                map.lstNode[i].MinStartToNode = null;
                map.lstNode[i].NearestToStart = null;
            }

            map.StartNode = map.lstNode[(int)StartNode.Value -1];
            map.EndNode = map.lstNode[(int)EndNode.Value -1];
           
            SearchEngine.GetShortestPathDijikstra(map);
            draw();
            

        }





        private void NumEdge_ValueChanged(object sender, EventArgs e)
        {
            NumEdge.Maximum = Numnode.Value * (Numnode.Value - 1);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tt != 1) return;
            int x = (e as MouseEventArgs).X;
            int y = (e as MouseEventArgs).Y;
            var P = new Pointsss();
            P.X = x;
            P.Y = y;
            if (P.Y > pictureBox1.Height || P.Y < 0 || P.X > pictureBox1.Width || P.X < 0) return;
            if (e.Button == MouseButtons.Left)
            {
                
             
            map.lstNode.ForEach(it =>
            {
                if (Pointsss.Distance(it.PointsssNode, P) < 20)
                {
                    it.PointsssNode.X = P.X;
                    it.PointsssNode.Y = P.Y;
                    it.PointsssNode.isclick = true;
                    map.lstNode.ForEach(itt =>
                    {
                        if (itt.PointsssNode != it.PointsssNode) itt.PointsssNode.isclick = false;
                    });
                    draw();
                    return;
                }
                if (it.PointsssNode.isclick == true)
                {
                    it.PointsssNode.X = P.X;
                    it.PointsssNode.Y = P.Y;
                    draw();
                    return;
                }
               
                
                
               
            });
           
            }
            map.lstNode.ForEach(it =>
            {
                if (Pointsss.Distance(it.PointsssNode, P) < 20)
                {
                    it.PointsssNode.isclick = true;
                    map.lstNode.ForEach(itt =>
                    {
                        if (itt.PointsssNode != it.PointsssNode) itt.PointsssNode.isclick = false;
                    });
                    draw();
                    return;
                }
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tt = 1;
        }
    }
}
