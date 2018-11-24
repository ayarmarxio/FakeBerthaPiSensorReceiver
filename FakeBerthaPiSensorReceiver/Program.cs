using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FakeBerthaPiSensorReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            double _long;
            double _lat;
            double _bpSystolic;
            double _bpDiastolic;
            double _bodyTemperature;
            int _heartBeatPerSecond;
            double _dust;
            double _sulphur;
            double _nitrogen;
            double _fluor;
            double _carbonMonoxide;
            double _ozone;
            int _userId;

            int number = 0;

            //Creates a UdpClient for reading incoming data.
            UdpClient udpReceiver = new UdpClient(9000);

            // This IPEndPoint will allow you to read datagrams sent from any ip-source on port 9000


            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 9000);

            udpReceiver.Connect(RemoteIpEndPoint);

            // Blocks until a message returns on this socket from a remote host.
            Console.WriteLine("Receiver is blocked");

            try
            {
                while (true)
                {
                    Byte[] receiveBytes = udpReceiver.Receive(ref RemoteIpEndPoint);

                    string receivedData = Encoding.ASCII.GetString(receiveBytes);

                    if (receivedData.Equals("STOP.Secret")) throw new Exception("Receiver stopped");

                    Console.WriteLine("Sender: " + receivedData.ToString());
                    //Console.WriteLine("This message was sent from " +
                    //                            RemoteIpEndPoint.Address.ToString() +
                    //                            " on their port number " +
                    //                            RemoteIpEndPoint.Port.ToString());
                    //if (receivedData.Equals("STOP")) throw new Exception("Receiver stopped");

                    // string[] textLines = receivedData.Split(' '); is possible but a little more difficult 
                    //best to split by '\n' or \r\ and then split by ' ' or  ':'
                    string[] textLines = receivedData.Split('\n');

                    for (int index = 0; index < textLines.Length; index++)
                        Console.Write(textLines[index]);

                    string[] list1 = textLines[0].Split(':');
                    string text1 = list1[1];
                    string[] list2 = textLines[1].Split(':');
                    string text2 = list2[1];
                    string[] list3 = textLines[2].Split(':');
                    string text3 = list3[1];
                    string[] list4 = textLines[2].Split(':');
                    string text4 = list4[1];
                    string[] list5 = textLines[1].Split(':');
                    string text5 = list5[1];
                    string[] list6 = textLines[2].Split(':');
                    string text6 = list6[1];
                    string[] list7 = textLines[2].Split(':');
                    string text7 = list7[1];
                    string[] list8 = textLines[1].Split(':');
                    string text8 = list8[1];
                    string[] list9 = textLines[2].Split(':');
                    string text9 = list9[1];
                    string[] list10 = textLines[2].Split(':');
                    string text10 = list10[1];
                    string[] list11 = textLines[1].Split(':');
                    string text11 = list11[1];
                    string[] list12 = textLines[2].Split(':');
                    string text12 = list12[1];
                    string[] list13 = textLines[0].Split(':');
                    string text13 = list13[1];


                    _long = Double.Parse(text1);
                    _lat = Double.Parse(text2);
                    _bpSystolic = Double.Parse(text3);
                    _bpDiastolic = Double.Parse(text4);
                    _bodyTemperature = Double.Parse(text5);
                    _heartBeatPerSecond = Int32.Parse(text6);
                    _dust = Double.Parse(text7);
                    _sulphur = Double.Parse(text8);
                    _nitrogen = Double.Parse(text9);
                    _fluor = Double.Parse(text10);
                    _carbonMonoxide = Double.Parse(text11);
                    _ozone = Double.Parse(text12);
                    _userId = Int32.Parse(text13);

                    //Console.WriteLine("Numerical values");

                    Console.WriteLine("Long: " + _long);
                    Console.WriteLine("Lat: " + _lat);
                    Console.WriteLine("BpSystolic: " + _bpSystolic);
                    Console.WriteLine("BpDiastolic: " + _bpDiastolic);
                    Console.WriteLine("BodyTemperature: " + _bodyTemperature);
                    Console.WriteLine("HeartBeatPerSecond: " + _heartBeatPerSecond);
                    Console.WriteLine("Dust: " + _dust);
                    Console.WriteLine("Sulphur: " + _sulphur);
                    Console.WriteLine("Nitrogen: " + _nitrogen);
                    Console.WriteLine("Fluor: " + _fluor);
                    Console.WriteLine("CarbonMonoxide: " + _carbonMonoxide);
                    Console.WriteLine("Ozone: " + _ozone);
                    Console.WriteLine("UserId: " + _userId);
                    
                    //Console.ReadLine(); //for reading the data slowly
                    Thread.Sleep(1000);

                    number++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
