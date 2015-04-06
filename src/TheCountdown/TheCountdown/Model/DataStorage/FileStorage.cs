using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TheCountdown.Model
{
    class FileStorage : IDataStorage
    {
        public FileStorage()
        {
            dataWriter = new BinaryWriter(new FileStream(TIMERS_FILE_PATH, FileMode.Append, FileAccess.Write));
        }

        public bool SaveTimer(STimerDetails timerToSave)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream mStream =  new MemoryStream();
            formatter.Serialize(mStream, timerToSave);
            byte[] buffer = mStream.ToArray();
            mStream.Close();
            dataWriter.Write(buffer);

            return true;
        }

        private BinaryWriter dataWriter;
        public const string TIMERS_FILE_PATH = "timers.tmr";
    }
}
