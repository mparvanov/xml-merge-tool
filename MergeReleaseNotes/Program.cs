using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace MergeReleaseNotes
{
        internal class Program
        {
            private static void MergeElements(XElement parentA, XElement parentB, string pathToFilec)
            {


                //Console.WriteLine(parentA);
                //foreach (XNode childB in parentB.DescendantNodes())
                //{
                //    //if(childB.NodeType)
                //    //parentA.Add(childB); 
                //    Console.WriteLine("****");
                //    Console.WriteLine(childB.ElementsAfterSelf());
                //    Console.WriteLine("****");
                //}
                //Console.WriteLine(parentB.DescendantNodes().First());

                //parentA.Add(parentB.Elements());
                parentA.Add(parentB);
                parentA.Save(pathToFilec);

            }
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");

                string pathToFilea;
                string pathToFileb;
                string pathToFilec;

                if (args.Length == 0)
                {
                //pathToFilea = @"C:\Users\parvanov\source\repos\MergeReleaseNotes\MergeReleaseNotes\source.xml";
                //pathToFileb = @"C:\Users\parvanov\source\repos\MergeReleaseNotes\MergeReleaseNotes\dpl.xml";
                //pathToFilec = @"C:\Users\parvanov\source\repos\MergeReleaseNotes\MergeReleaseNotes\merged.xml";

                pathToFilea = @"source.xml";
                pathToFileb = @"dpl.xml";
                pathToFilec = @"merged.xml";
                Console.WriteLine("Merged file: " + pathToFilec);
                }
                else
                {
                    pathToFilea = args[0];
                    pathToFileb = args[1];
                    pathToFilec = args[2];
                }



                //string pathToFilea = @"C:\Users\parvanov\source\repos\ConsoleApp1\ConsoleApp4\core.xml";
                //string pathToFileb = @"C:\Users\parvanov\source\repos\ConsoleApp1\ConsoleApp4\dpl.xml";


                var a1 = new XmlDocument();

                a1.Load(pathToFilea);

                var b1 = new XmlDocument();
                b1.Load(pathToFileb);

                XDocument a = XDocument.Parse(a1.OuterXml);
                XDocument b = XDocument.Parse(b1.OuterXml);

                XElement xmla = a.Root.Elements().First();
                XElement xmlb = b.Root.Elements().First();

            //foreach (XElement metNode in xmlb.Elements("releaseNoteItem"))
            //{
            //    //metNode.AddAfterSelf(xml2.Descendants("Path").Where(ele => ele.Value.Equals(metNode.Parent.Element("Path").Value)).FirstOrDefault().Parent.Element("Description"));
            //    MergeElements(xmla, metNode, pathToFilec);
            //    Console.WriteLine(metNode.ToString()); 
            //}


            foreach (XElement metNode in xmlb.Elements())
            {
                //Console.WriteLine("#############################Element####################################");
                //Console.WriteLine(metNode.ToString());
                MergeElements(xmla, metNode, pathToFilec);
                //metNode.AddAfterSelf(xml2.Descendants("Path").Where(ele => ele.Value.Equals(metNode.Parent.Element("Path").Value)).FirstOrDefault().Parent.Element("Description"));
            }


            //MergeElements(xmla, xmlb, pathToFilec);



            //MergeElements(a.Root, b.Root);
            //MergeElements(a.Root.Elements().First(), b.Root.Elements().First().Elements().First(), pathToFilec);
            //Console.WriteLine("Merged document:\n{0}", a.Root);
        }


    }
}
