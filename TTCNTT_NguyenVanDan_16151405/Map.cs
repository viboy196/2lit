using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TTCNTT_NguyenVanDan_16151405
{
    
    public class Pointsss 
    {  // có ID và tọa độ của điểm
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public static double Distance( Pointsss A , Pointsss B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        public bool isclick { get; set; }
        public Pointsss()
        {
            isclick = false;
        }
    }

    public class Node // chứa tọa độ của điểm của node và các node kết nối với node này 
    {
        // điểm của node
        public Pointsss PointsssNode { get; set; }

        // điểm liên kết với điểm node
        public List<Node> Connecttions { get; set; } = new List<Node>();
        public List<Node> LastConnecttions { get; set; } = new List<Node>();

        // độ dài ngắn nhất từ Start to node
        public double? MinStartToNode { get; set; }

        // check coi điểm đã đươc duyệt chưa ?
        public bool Visited { get; set; }
        // điểm kết nối trước với node này và thuộc nhánh ngắn nhất
        public Node NearestToStart { get; set; }
        public Node()
        {
            PointsssNode = new Pointsss();
            Connecttions = new List<Node>();
            Visited = false;
        }
    }

    public class Map
    {
        // node đầu
        public Node StartNode { get; set; }
        // node cuối
        public Node EndNode { get; set; }
        // list các node trong map
        public List<Node> lstNode { get; set; }
        // list shortes node path
        public List<Node> ShortesPath { get; set; }

        public Map()
        {
            StartNode = new Node();
            EndNode = new Node();
            lstNode = new List<Node>();
            ShortesPath = new List<Node>();
        }
    }



}
