using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCNTT_NguyenVanDan_16151405
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var rand = new Random();
            //var map = new Map();

            //for( int i = 1; i <= 20; i++)
            //{
            //    var node = new Node();
            //    node.PointNode = new Point();
            //    node.PointNode.X = rand.Next(0, 200);
            //    node.PointNode.X = rand.Next(0, 200);
            //    node.PointNode.Id = i;
            //    map.lstNode.Add(node);
            //}

            //foreach( var node in map.lstNode)
            //{
            //    for(int i = 0; i < 5; i++)
            //    {
            //        var intrand = rand.Next(0, 19);
            //        if (node != map.lstNode[intrand] && !node.Connecttions.Contains(map.lstNode[intrand]))
            //            node.Connecttions.Add(map.lstNode[intrand]);

            //    }
            //}
            //map.StartNode = map.lstNode[rand.Next(0, 19)];
            //map.EndNode = map.lstNode[rand.Next(0, 19)];
            //SearchEngine.GetShortestPathDijikstra(map);
            //foreach(var i in map.ShortesPath)
            //{
            //    Console.Write("%d  -->", i.PointNode.Id);
            //}
            //Console.ReadLine();
            //Console.Read();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
