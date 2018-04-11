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

  

        public void AddNode(long ID, Type type)
        {
            nodeSet.Add(new SakumsBeigasApvienosanaNode(ID, type));
        }

        public void AddNode(long ID, Type type, string name)
        {
            nodeSet.Add(new DarbibaNode(ID, type ,name));
        }

        public void AddNode (long ID, Type type, string informal, string formal)
        {
            nodeSet.Add(new ZarosanasNode(ID, type, formal, informal));
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

        // Iegūst atbilstošo virsotni pēc ID
        public Node getNodeByID(long ID)
        {
            return Nodes.Find(x => x.ID == ID );
        }

        // Iegūst virsotnes pēc Tipa
        public Node getNodeByType (Type type )
        {
            return Nodes.First<Node>(x => x.type == type);
        }
    }


    public class Node
    {
     
        public long ID;
        public Type type;
       // public Branch branch;
        private  NodeList neighbors = null;

        public Node() { }
        //public Node(long ID, Type type, Branch branch) : this(ID,type,branch, null) { }
        public Node(long ID,Type type, NodeList neighbors)
        {
            this.ID = ID;
            this.type = type;
            //this.branch = branch;
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
        public SakumsBeigasApvienosanaNode(long ID, Type type) : base(ID, type, null) { }
        public SakumsBeigasApvienosanaNode(long ID, Type type ,NodeList neighbors) : base(ID,type,neighbors) { }

      
    }

    public class DarbibaNode : Node
    {
        public string name;
        public DarbibaNode() : base() { }
        public DarbibaNode(long ID, Type type, string name) : base(ID, type, null) { this.name = name; }
        public DarbibaNode(long ID, Type type,string name, NodeList neighbors) : base(ID, type, neighbors) { this.name = name; }

        
    }

    public class ZarosanasNode : Node
    {
        public string formal;
        public string informal;
        private List<String> _branch;
        public ZarosanasNode() : base() { }
        public ZarosanasNode(long ID, Type type ,string formal, string informal) : base(ID, type, null) { this.formal = formal; this.informal = informal; }
        public ZarosanasNode(long ID, Type type, string formal, string informal, NodeList neighbors) : base(ID, type,neighbors) { this.formal = formal; this.informal = informal; }

        // Lai zinātu, kas ir rakstīts uz zarošanās līnijas
        public List<String> Branch
        {
            get
            {
                if (_branch == null)
                    _branch = new List<string>();
                return _branch;
            }
        }
      

        
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





}

