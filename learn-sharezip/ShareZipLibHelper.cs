using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.GZip;

namespace learn_sharezip
{
    class ShareZipLibHelper
    {
        public void ExtractGZipSample(string gzipFileName, string targetDir)
        {
            byte[] dataBuffer = new byte[4096];
            using (System.IO.Stream fs = new FileStream(gzipFileName, FileMode.Open))
            {
                using (GZipInputStream gzipStream = new GZipInputStream(fs))
                {
                    string fnOut = Path.Combine(targetDir, Path.GetFileNameWithoutExtension(gzipFileName));

                    using (FileStream fsOut = File.Create(fnOut))
                    {
                        StreamUtils.Copy(gzipStream, fsOut, dataBuffer);
                    }
                }
            }
        }
    }
}
