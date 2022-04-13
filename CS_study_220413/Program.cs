public class Computer   //superclass
{
    protected bool powerOn;
    protected void Boot() { Console.WriteLine("booting.."); }
    public void Shutdown() { }
    public void Reset() { }
}

public class Notebook : Computer
{
    bool fingerScan; // speciality
    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if(powerOn == true)
        {
            Shutdown();
        }
    }

    public void Booting()
    {
        Boot(); //Computer function (access protected)
    }
}

public class DeskTop : Computer
{

}

public class Netbook : Computer
{

}

public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();  // childclass instance -> superclass
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            DeskTop desktop = new DeskTop();
            Netbook netbook = new Netbook();

            DeviceManager manager = new DeviceManager();
            manager.TurnOff(notebook);  //typecasting implicit
            manager.TurnOff(desktop);
            manager.TurnOff(netbook);
        }
    }
}