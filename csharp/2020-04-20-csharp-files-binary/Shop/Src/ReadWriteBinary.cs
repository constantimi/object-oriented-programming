using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.Src
{
    class ReadWriteBinary
    {
        public ReadWriteBinary()
        {

        }

        public void SaveCurrentDate(string filename, double revenue)
        {
            FileStream fs = new FileStream(filename + "-history.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            
            bw.Write(DateTime.UtcNow.Day);
            bw.Write(DateTime.UtcNow.Month);
            bw.Write(DateTime.UtcNow.Year);
            
           
            bw.Write(DateTime.UtcNow.Hour);
            bw.Write(DateTime.UtcNow.Minute);

            bw.Write(revenue);

            bw.Close();
            fs.Close();
        }

        public string ShowPreviousTime(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename + "-history.bin");
            if (IsFileinUse(fileInfo))
            {
                return "No information";
            }
            
            FileStream fs = new FileStream(filename + "-history.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            string information = br.ReadInt32() + "-" + br.ReadInt32() + "-" + br.ReadInt32() + " " + br.ReadInt32() + ":" + br.ReadInt32() + "   " + "Revenue: " + br.ReadDouble().ToString("0.00");
            fs.Close();

            return information;
        }



        protected virtual bool IsFileinUse(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }



    }
}
