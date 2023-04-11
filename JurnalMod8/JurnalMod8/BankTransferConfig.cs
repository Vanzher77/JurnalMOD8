using System;
using System.Security.Cryptography.X509Certificates;

public class Bank
{
    public string lang { get; set; }
    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }
   
    public Bank(string lang, object )
	{
		this.lang = lang;
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
}
public class metod
{
    public string methods { get; set; }
    public metod(string methods)
    {
        this.methods = methods;
    }
}

public class confirm
{
    public string confirmation { get; set; }
    public string en { get; set; }
    public string id { get; set; }

    public confirm(string confirmation, string en, string id)
    {
        this.confirmation = confirmation;
        this.en = en;   
        this.id = id;
    }

}

public class config
{
    public const string fileLocation = "E:\\DATA KULIAH\\SEMESTER 4\\Konstruksi Perangkat Lunak (KPL)\\Jurn Mod 8\\JurnalMod8\\JurnalMod8\\bin\\Debug\\net6.0";
    public const string filepath = fileLocation + @"Bank_Transfer_Config.json";

    public Bank bank;

    public config()
    {
       
    }

    public void defaults()
    {
        bank = new Bank("en");
    }

}

