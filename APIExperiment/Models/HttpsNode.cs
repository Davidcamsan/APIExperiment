using System;

namespace APIExperiment.Models
{
    //************START OF HTTPS_NODE CLASS
    public class HttpsNode
    {
        public HttpsNode()
        {
        }

        public string SelfHttps { get; set; }
        public string NextHttps { get; set; }
        public HttpsNode PrevNode { get; set; }

        public HttpsNode(string self, string next)
        {
            this.SelfHttps = self;
            this.NextHttps = next;
            this.PrevNode = null;
        }

    }
    //***********END OF HTTPS_NODE CLASS
    //
    //
    //
    //
    //************START OF HTTPS_STACK CLASS
    public class HttpsStack
    {
        public HttpsStack()
        {
            this.root = null;
        }

        public HttpsNode root { get; set; }


        //METHODS

        public bool IsEmpty()
        {
            return this.root == null;
        }


        public void Push(string self, string next)
        {
            if (this.IsEmpty())
            {
                this.root = new HttpsNode(self, next);
            }
            else{
                HttpsNode temp = new HttpsNode(self, next);
                temp.PrevNode = this.root;
                root = temp;
            }     
        }


        public HttpsNode Pop()
        {
            if (this.IsEmpty())
                return null;
            else
            {
                HttpsNode temp = this.root;
                this.root = temp.PrevNode;
                return temp;
            }
        }


        public HttpsNode Peek()
        {
            if (this.IsEmpty())
                return null;
            else
            {
                return this.root;
            }   
        }


        public bool IsTherePreviousNode()
        {
            return this.root.PrevNode != null;
        }
    }
    //************END OF HTTPS_STACK CLASS



}
