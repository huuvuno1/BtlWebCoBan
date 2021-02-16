using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace BtlWebForm.Repository
{
    public class FileIO : System.Web.UI.Page
    {
        public string ReadFileJson(string file)
        {
            try 
            {
                FileStream f = new FileStream(Server.MapPath(file), FileMode.Open);
                StreamReader rd = new StreamReader(f, Encoding.UTF8);
                string value = rd.ReadToEnd();
                rd.Close();
                f.Close();
                return value;
            }
            catch
            {
                // not found file or file empty
                return null;
            }
        }

        public static void WriteFileJson(string file)
        {

        }
    }
}