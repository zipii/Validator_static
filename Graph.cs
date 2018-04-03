using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator_static
{
    public class Graph  
    {
        private NodeList nodeSet;

        public Graph() : this(null) { }
        public Graph(NodeList nodeSet)
        {
            if (nodeSet == null)
                this.nodeSet = new NodeList();
            else
                this.nodeSet = nodeSet;
        }

  

        public void AddNode(long ID, Type type, Branch branch)
        {
            nodeSet.Add(new SakumsBeigasApvienosanaNode(ID, type, branch));
        }

        public void AddNode(long ID, Type type, string name, Branch branch)
        {
            nodeSet.Add(new DarbibaNode(ID, type, branch ,name));
        }

        public void AddNode (long ID, Type type, Branch branch, string informal, string formal)
        {
            nodeSet.Add(new ZarosanasNode(ID, type,branch, formal, informal));
        }


        public void AddDirectedEdge (Node from , Node to)
        {
            from.Neighbors.Add(to);
        }

   

      

        public NodeList Nodes
        {
            get
            {
                return nodeSet;
            }
        }

        public int Count
        {
            get { return nodeSet.Count; }
        }

        // Iegūst atbilstošo virsotni
        public Node getNodeByID(long ID)
        {
            return Nodes.Find(x => x.ID == ID );
        }
    }


    public class Node
    {
     
        public long ID;
        public Type type;
        public Branch branch;
        private  NodeList neighbors = null;

        public Node() { }
        //public Node(long ID, Type type, Branch branch) : this(ID,type,branch, null) { }
        public Node(long ID,Type type,Branch branch, NodeList neighbors)
        {
            this.ID = ID;
            this.type = type;
            this.branch = branch;
            this.neighbors = neighbors;
        }

      

        public NodeList Neighbors
        {
            get
            {
                if (neighbors == null)
                    neighbors = new NodeList();
                    return neighbors;
            }
            set
            {
                neighbors = value;
            }
        }
    }


    public class NodeList : List<Node>
    {
        public NodeList() : base() { }

       
       
    }


    public class SakumsBeigasApvienosanaNode : Node
    {
        public SakumsBeigasApvienosanaNode() : base() { }
        public SakumsBeigasApvienosanaNode(long ID, Type type, Branch branch) : base(ID, type, branch, null) { }
        public SakumsBeigasApvienosanaNode(long ID, Type type, Branch branch ,NodeList neighbors) : base(ID,type,branch,neighbors) { }

      
    }

    public class DarbibaNode : Node
    {
        public string name;
        public DarbibaNode() : base() { }
        public DarbibaNode(long ID, Type type,Branch branch, string name) : base(ID, type, branch, null) { this.name = name; }
        public DarbibaNode(long ID, Type type,string name,Branch branch, NodeList neighbors) : base(ID, type,branch, neighbors) { this.name = name; }

        
    }

    public class ZarosanasNode : Node
    {
        public string formal;
        public string informal;
        public ZarosanasNode() : base() { }
        public ZarosanasNode(long ID, Type type, Branch branch ,string formal, string informal) : base(ID, type, branch, null) { this.formal = formal; this.informal = informal; }
        public ZarosanasNode(long ID, Type type,Branch branch, string formal, string informal, NodeList neighbors) : base(ID, type,branch,neighbors) { this.formal = formal; this.informal = informal; }

        
    }

    public enum Type
    {
        Sakums,
        Beigas,
        Pareja,
        Zarosanas,
        Darbiba,
        Apvienosana

    };

    public enum Branch
    {
        Ok,
        No,
        Nothing
    };
        




}

