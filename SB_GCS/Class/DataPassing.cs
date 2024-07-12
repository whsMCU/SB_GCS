using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_GCS.Class
{
    public class DataPassing
    {
        public static readonly byte
            ROLL = 0,
            PITCH = 1,
            YAW = 2;
        List<byte>recvData = new List<byte>();
        byte[] buff = new byte[1024];
        byte[] buff_pass = new byte[64];
        int cnt = 0;
        byte checksum = 0xff;

        float[] attitude = new float[3];

        public DataPassing()
        {

        }

        public DataPassing(List<byte> recvData, byte checksum)
        {
            this.recvData = recvData;
            this.checksum = checksum;
        }

        public float[] dataRecive(byte[] data, int size)
        {
            Array.Copy(data, buff, size);
            for (int i = 0; i < size; i++)
            {
                switch(cnt)
                {
                    case 0:
                        if (buff[i] == 0x46)
                        {
                            buff_pass[cnt] = buff[i];
                            cnt++;
                        }
                        break;

                    case 1:
                        if (buff[i] == 0x43)
                        {
                            buff_pass[cnt] = buff[i];
                            cnt++;
                        }
                        else
                        {
                            cnt = 0;
                        }
                        break;

                    case 19:
                        buff_pass[cnt] = buff[i];
                        cnt = 0;
                        break;

                    default:
                        buff_pass[cnt] = buff[i];
                        cnt++;
                        break;
                }
            }
            return Passing();
        }

        public float[] Passing()
        {
            attitude[ROLL] = BitConverter.ToInt16(buff_pass, 3)/100;
            attitude[PITCH] = BitConverter.ToInt16(buff_pass, 5) / 100;
            attitude[YAW] = BitConverter.ToInt16(buff_pass, 7) / 100;
            return attitude;
        }

        ~DataPassing()
        {

        }
    }
}
