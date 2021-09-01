using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class PrintJob
    {
        private string fileName;
        private string fileType;
        private int fileSize;

        public PrintJob()
        {
            // Empty constructor
        }
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                this.fileName = value;
            }
        }
        public string FileType
        {
            get
            {
                return fileType;
            }
            set
            {
                this.fileType = value;
            }
        }
        public int FileSize
        {
            get
            {
                return fileSize;
            }
            set
            {
                this.fileSize = value;
            }
        }
    }
}
