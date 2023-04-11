using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class Bank
{
    public string lang { get; set; }
    public tf transfer { get; set; }
    //penggunaan tipe data generik pada konstruktor methods
    public List<string> methods { get; set; }
    public confirm confirmation { get; set; }
    public Bank(string lang, tf transfer, List<string> methods, confirm confirmation)
	{
		this.lang = lang;
        this.transfer = transfer;
        this.methods = methods;
        this.confirmation = confirmation;
    }
	public Bank() { }
}

public class tf
{
    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }
    
    public tf(int threshold, int low_fee, int high_fee)
    {
        this.threshold = threshold;
        this.low_fee = low_fee;
        this.high_fee = high_fee;

    }
    public tf() { }
}


public class confirm
{
    
    public string en { get; set; }
    public string id { get; set; }

    public confirm(string en, string id)
    {
        this.en = en;   
        this.id = id;
    }

}

public class config
{
    public const string fileLocation = "E:\\DATA KULIAH\\SEMESTER 4\\Konstruksi Perangkat Lunak (KPL)\\Jurn Mod 8\\JurnalMod8\\JurnalMod8\\bin\\Debug\\net6.0";
    public const string filepath = fileLocation + @"Bank_Transfer_Config.json";

    public Bank bank;
    public tf trans;
   
    public confirm conf;
    public config()
    {
        try
        {

        }
        catch
        {

        }
    }

    public void defaults()
    {
        //setting default json 
        string CONFIG1 = "en";
        int CONFIG2 = 25000000;
        int CONFIG3 = 6500;
        int CONFIG4 = 15000;
        List<string> CONFIG5 = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
        string CONFIG6 = "yes";
        string CONFIG7 = "ya";
        conf = new confirm(CONFIG6,CONFIG7);
        trans = new tf(CONFIG2, CONFIG3, CONFIG4);
        bank = new Bank(CONFIG1, trans, CONFIG5, conf);
    }
    
    public void writeBankTrans()
    {
        JsonSerializerOptions opt = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };
        string js = JsonSerializer.Serialize(bank, opt);
        File.WriteAllText(filepath, js );
    }

    public Bank readConf() 
    {
        string hasilbaca = File.ReadAllText(filepath);
        bank = JsonSerializer.Deserialize<Bank>(hasilbaca);
        return bank;
    }
}

