using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace myProgram
{
    abstract class FileParser
    {
        public FileParser(string fileName)
        {
            FileName = fileName;
        }
            
        public abstract void Read();
        public abstract void Open();
        public abstract void Analize();
        public abstract void Close();


        public virtual void Parse()
        {
            Open();
            Read();
            Analize();
            Close();
        }

        //виртуальное свойство
        public abstract string ParserFormat { get; }

        public string FileName { get; }
        public static FileParser GetParser(string fileName)
        {
            FileParser myParser;
            
            if (fileName.EndsWith(".xml"))
            {
                myParser = new XmlParser(fileName);
            }else if (fileName.EndsWith(".rtf"))
            {
                myParser= new RtfParser(fileName);
            }else if (fileName.EndsWith(".html"))
            {
                myParser = new HtmlParser(fileName);

            }else
            {
                myParser = null;
            }

             return myParser;
        }

    }
}
