Console.WriteLine(Converter.DecToBin(192));    // 11000000
Console.WriteLine(Converter.DecToBin(168));    // 10101000
Console.WriteLine(Converter.DecToBin(1));      // 00000001
Console.WriteLine(Converter.DecToBin(255));    // 11111111

Console.WriteLine();

Console.WriteLine(Converter.BinToDec("11000000"));   // 192
Console.WriteLine(Converter.BinToDec("00000001"));   // 1
Console.WriteLine(Converter.BinToDec("11111111"));   // 255

Console.WriteLine();

IpAddress cim = IpAddress.Parse("192.168.1.55");

Console.WriteLine(cim);                    // 192.168.1.55
Console.WriteLine(cim.GetOktett(0));       // 192
Console.WriteLine(cim.GetOktett(3));       // 55
Console.WriteLine(cim.ToBinaryString());
// 11000000 10101000 00000001 00110111
Console.WriteLine(cim.ToDecimalString());
// 192.168.1.55

Console.WriteLine();

var szerver = new DhcpServer("192.168.1.0");

Console.WriteLine($"Router:     {szerver.Router.ToDecimalString()}");      // 192.168.1.1
Console.WriteLine($"Broadcast:  {szerver.Broadcast.ToDecimalString()}");   // 192.168.1.255

IpAddress eszkoz1 = szerver.GetNextAddress();
IpAddress eszkoz2 = szerver.GetNextAddress();
IpAddress eszkoz3 = szerver.GetNextAddress();

Console.WriteLine($"1. eszköz:  {eszkoz1.ToDecimalString()}");   // 192.168.1.2
Console.WriteLine($"2. eszköz:  {eszkoz2.ToDecimalString()}");   // 192.168.1.3
Console.WriteLine($"3. eszköz:  {eszkoz3.ToDecimalString()}");   // 192.168.1.4

Console.WriteLine($"Kiosztott:  {DhcpServer.OsszesCimKiosztva}");  // 3

public static class Converter
{
    public static string DecToBin(int dec) => 
        Convert.ToString(dec,2)
        .PadLeft(8, '0');

    public static int BinToDec(string bin) => Convert.ToInt32(bin, 2);


}

public class IpAddress
{
    private byte[] _oktettek;

    private IpAddress(byte[] oktettek)
    {
        _oktettek = oktettek;
    }

    public int GetOktett(int index) => _oktettek[index]; 

    public static IpAddress Parse(string ip)
    {
        var result = ip.Split('.');

        byte[] tomb = new byte[result.Length];


        for (int i = 0; i < result.Length; i++)
        {
            tomb[i] = byte.Parse(result[i]);
        }

        return new IpAddress(tomb);

    }

    public string ToBinaryString()
    {
        var result = _oktettek.Select(x => Converter.DecToBin(x));

        var unifiedresult = string.Join(" ", result);

        return unifiedresult;
    }

    public string ToDecimalString()
    {
        var result = _oktettek.Select(x => x.ToString());

        var unifiedresult = string.Join(".", result);

        return unifiedresult;
    }
}

public class DhcpServer
{
    private IpAddress _halozat;
    private static int _osszesCimKiosztva = 0;

    public DhcpServer(string halozatiCim)
    {
        _halozat = IpAddress.Parse(halozatiCim);
    }

    public IpAddress Router
    {
        get
        {
            // Az utolsó oktett értéke: _halozat.GetOktett(3) + 1
            // A többi oktett marad ugyanaz
            // Tipp: építs fel egy új "x.x.x.Y" stringet és Parse-old!
            // ...

            var routerip = $"{_halozat.GetOktett(0)}.{_halozat.GetOktett(1)}.{_halozat.GetOktett(2)}.{_halozat.GetOktett(3) + 1}";

            return IpAddress.Parse(routerip);
        }
    }

    public IpAddress Broadcast
    {
        get
        {
            // Az utolsó oktett értéke mindig 255
            // ...

            var broadcastip = $"{_halozat.GetOktett(0)}.{_halozat.GetOktett(1)}.{_halozat.GetOktett(2)}.255";


            return IpAddress.Parse(broadcastip);
        }
    }

    public static int OsszesCimKiosztva => _osszesCimKiosztva;

    public IpAddress GetNextAddress()
    {
        // A Router utáni első szabad cím: Router oktetje + _osszesCimKiosztva + 1
        // Növeld _osszesCimKiosztva-t!
        // Tipp: ugyanúgy, mint a Router – építs stringet és Parse-old
        // ...
        _osszesCimKiosztva++;

        var nextip = $"{_halozat.GetOktett(0)}.{_halozat.GetOktett(1)}.{_halozat.GetOktett(2)}.{_halozat.GetOktett(3) + _osszesCimKiosztva + 1}";

        return IpAddress.Parse(nextip);
    }
}