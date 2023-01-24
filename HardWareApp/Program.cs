// See https://aka.ms/new-console-template for more information
using HardWareApp;
using HardWareApp.LibreHardwareMonitorLib;

var dispatcher = new Dispatcher();
var localIp = new LocalIp();
var pcManager = new PcManager();
var visitor = new Visitor();

Console.WriteLine(dispatcher.GetApp());
Console.WriteLine("************************************************");
Console.WriteLine(localIp.GetLocalIp());
Console.WriteLine("************************************************");
Console.WriteLine(pcManager.GetEnviroment());
Console.WriteLine("************************************************");
Console.WriteLine(visitor.Monitor());

Console.ReadKey();
