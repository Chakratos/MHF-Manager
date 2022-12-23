using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHF_Manager.Data
{
    public class Mhfdat
    {
        BinaryReader mhfdatReader;
        BinaryWriter mhfdatWriter;

        public Mhfdat(string location)
        {
            mhfdatReader = new BinaryReader(File.Open(location, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            mhfdatWriter = new BinaryWriter(File.Open(location, FileMode.Open, FileAccess.Write, FileShare.ReadWrite));
        }

        public BinaryReader GetMhfdatReader(bool reset = true)
        {
            if (reset)
            {
                mhfdatReader.BaseStream.Seek(0, SeekOrigin.Begin);
            }
            
            return mhfdatReader;
        }

        public BinaryWriter GetMhfdatWriter(bool reset = true)
        {
            if (reset)
            {
                mhfdatWriter.Seek(0, SeekOrigin.Begin);
            }

            return mhfdatWriter;
        }
    }
}
