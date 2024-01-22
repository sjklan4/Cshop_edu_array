using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HOD_Inspect
{
    public class cLCR_pF
    {
        public event Action<string, byte[]> vReceive;
        public event Action vDisConnected;
        public event Action vConnected;
        public Socket Sock;
        public bool isConnected = false;
        string IP = "127.0.0.1";
        int Port = 1000;
        byte[] Buffer = new byte[2048];
        AutoResetEvent waitConnect = new AutoResetEvent(false);

        public cLCR_pF(string ip, int port)
        {
            IP = ip;
            Port = port;
        }

        public bool Connect()
        {
            bool Ret = false;
            Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            waitConnect.Reset();
            Sock.BeginConnect(IP, Port, (x) =>
            {
                Socket sock = x.AsyncState as Socket;
                try
                {
                    sock.EndConnect(x);
                    isConnected = sock.Connected;
                    vConnected?.Invoke();
                    sock.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, new AsyncCallback(Receive)
                    , sock);
                }
                catch
                {

                }
                waitConnect.Set();
            }, Sock);
            if (waitConnect.WaitOne(100))
            {
                Ret = true;
            }
            return Ret;
        }
        public void Disconnect()
        {
            if (Sock != null)
            {
                try
                {
                    isConnected = false;
                    Sock.Close();
                    vDisConnected?.Invoke();
                }
                catch
                {
                    Sock = null;
                    vDisConnected?.Invoke();
                }
                Sock = null;
            }
        }
        public bool SendAble = true;
        public void SendData()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string data = "FETC?\r\n";
            while (!SendAble)
            {
                if (sw.ElapsedMilliseconds > 1000) break;
            }
            SendAble = false;
            if (isConnected && Sock != null)
            {
                var senddata = Encoding.Default.GetBytes(data);
                // Sock.Send(senddata);
                Sock.BeginSend(senddata, 0, senddata.Length, SocketFlags.None, (ar) =>
                {
                    var sock = ar.AsyncState as Socket;
                    sock.EndSend(ar);
                    SendAble = true;
                }, Sock);
            }
            else
            {
                if (Sock != null)
                {
                    Sock.Close();
                    Sock = null;
                }
                if (Connect() && isConnected && Sock != null)
                {
                    Sock.Send(Encoding.Default.GetBytes(data));
                }
            }
        }
        void Receive(IAsyncResult ar)
        {
            Socket sock = ar.AsyncState as Socket;
            int RetCnt = -1;
            try
            {
                if (isConnected && Sock != null)
                    RetCnt = sock.EndReceive(ar);

                if (RetCnt == 0)
                {
                    //DisConnect
                    isConnected = false;
                    try
                    {
                        Disconnect();
                    }
                    catch
                    {
                        Sock = null;
                    }
                }
                else if (RetCnt > 0)
                {
                    vReceive?.Invoke(Encoding.Default.GetString(Buffer, 0, RetCnt), Buffer);
                }
            }
            finally
            {
                if (RetCnt > 0)
                {
                    Array.Clear(Buffer, 0, Buffer.Length);
                    sock.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, new AsyncCallback(Receive)
                            , sock);
                }
            }
        }
    }
}
