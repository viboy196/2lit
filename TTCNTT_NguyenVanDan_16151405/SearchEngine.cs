using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCNTT_NguyenVanDan_16151405
{
    public class SearchEngine
    {
        static private void DijkstraSearch(Map Map)
        {
            // gán Minstart to node của node start = 0
            Map.StartNode.MinStartToNode = 0;

            // tạo hàng đợi 
            var prioQueue = new List<Node>();
            // thêm điểm startNode vào hàng đợi
            prioQueue.Add(Map.StartNode);

            while (prioQueue.Any())
            {
                // sắp xếp prioQueue theo chiều tăng dần MinStartToNode 
                prioQueue = prioQueue.OrderBy(x => x.MinStartToNode.Value).ToList();
                // lấy điểm đầu danh sách ra
                var node = prioQueue.First();
                // xóa khỏi node duyệt
                prioQueue.Remove(node);
                // duyệt các node liền kề với node sắp xếp theo chiều tăng dần của độ dài khoảng cách từ node tới node liền kề
                foreach (var i in node.Connecttions.OrderBy(x => Pointsss.Distance(x.PointsssNode, node.PointsssNode)))
                {
                    // nếu i được xét rồi thì next
                    if (i.Visited)
                        continue;
                    // nếu i.MinStartToNode chưa đc gán or i.MinStartToNode >  node.MinStartToNode + Pointsss.Distance(node.PointsssNode, i.PointsssNode);
                    if (i.MinStartToNode == null ||
                        node.MinStartToNode + Pointsss.Distance(node.PointsssNode, i.PointsssNode) < i.MinStartToNode)
                    {
                        // gán i.MinStartToNode =  node.MinStartToNode + Pointsss.Distance(node.PointsssNode, i.PointsssNode)
                        i.MinStartToNode = node.MinStartToNode + Pointsss.Distance(node.PointsssNode, i.PointsssNode);
                        // gán điểm liền trước i = node;
                        i.NearestToStart = node;
                        // nếu i chưa thêm vào queue thì thêm i vào
                        if (!prioQueue.Contains(i))
                        {
                            prioQueue.Add(i);

                        }
                    }
                }
                // gán  node.Visited = true điểm node đã đc xét;
                node.Visited = true;
                //nếu node là điểm cuối thì return
                if (node.PointsssNode == Map.EndNode.PointsssNode)
                    return;
            }
        }

        public static void GetShortestPathDijikstra(Map Map)
        {
            // chạy DijkstraSearch
            DijkstraSearch(Map);
            // i gán = điểm cuối
            var i = Map.EndNode;
            //khởi tạo lại  Map.ShortesPath
            Map.ShortesPath = new List<Node>();
            // thềm điểm cuối vào danh sách shortpath của map
            Map.ShortesPath.Add(Map.EndNode);
            while (i.NearestToStart != null)
            {
                // thêm điểm trước cuối vào danh sách shortpath của map
                Map.ShortesPath.Add(i.NearestToStart);
                // dịch i lên trước
                i = i.NearestToStart;
            }
            //đảo ngược lại để path chạy từ đầu về cuối
            Map.ShortesPath.Reverse();
        }


        //////////// A*

        private static void AstarSearch(Map Map)
        {
            // gán Minstart to node của node start = 0
            Map.StartNode.MinStartToNode = 0;

            // tạo hàng đợi 
            var prioQueue = new List<Node>();
            // thêm điểm startNode vào hàng đợi
            prioQueue.Add(Map.StartNode);

            while (prioQueue.Any())
            {
                // sắp xếp prioQueue theo chiều tăng dần MinStartToNode 
                prioQueue = prioQueue.OrderBy(x => x.MinStartToNode.Value + Pointsss.Distance(x.PointsssNode, Map.EndNode.PointsssNode)).ToList();
                // lấy điểm đầu danh sách ra
                var node = prioQueue.First();
                // xóa khỏi node duyệt
                prioQueue.Remove(node);
                // duyệt các node liền kề với node sắp xếp theo chiều tăng dần của độ dài khoảng cách từ node tới node liền kề
                foreach (var i in node.Connecttions.OrderBy(x => Pointsss.Distance(x.PointsssNode, node.PointsssNode)))
                {
                    // nếu i được xét rồi thì next
                    if (i.Visited)
                        continue;
                    // nếu i.MinStartToNode chưa đc gán or i.MinStartToNode >  node.MinStartToNode + Pointsss.Distance(node.PointsssNode, i.PointsssNode);
                    if (i.MinStartToNode == null ||
                        node.MinStartToNode + Pointsss.Distance(node.PointsssNode, i.PointsssNode) < i.MinStartToNode)
                    {
                        // gán i.MinStartToNode =  node.MinStartToNode + Pointsss.Distance(node.PointsssNode, i.PointsssNode)
                        i.MinStartToNode = node.MinStartToNode + Pointsss.Distance(node.PointsssNode, i.PointsssNode);
                        // gán điểm liền trước i = node;
                        i.NearestToStart = node;
                        // nếu i chưa thêm vào queue thì thêm i vào
                        if (!prioQueue.Contains(i))
                        {
                            prioQueue.Add(i);

                        }
                    }
                }
                // gán  node.Visited = true điểm node đã đc xét;
                node.Visited = true;
                //nếu node là điểm cuối thì return
                if (node.PointsssNode == Map.EndNode.PointsssNode)
                    return;
            }
        }
        public static void GetShortPathAstar(Map Map)
        {
            // chạy DijkstraSearch
            AstarSearch(Map);
            // i gán = điểm cuối
            var i = Map.EndNode;
            //khởi tạo lại  Map.ShortesPath
            Map.ShortesPath = new List<Node>();
            // thềm điểm cuối vào danh sách shortpath của map
            Map.ShortesPath.Add(Map.EndNode);
            while (i.NearestToStart != null)
            {
                // thêm điểm trước cuối vào danh sách shortpath của map
                Map.ShortesPath.Add(i.NearestToStart);
                // dịch i lên trước
                i = i.NearestToStart;
            }
            //đảo ngược lại để path chạy từ đầu về cuối
            Map.ShortesPath.Reverse();
        }
    }
}