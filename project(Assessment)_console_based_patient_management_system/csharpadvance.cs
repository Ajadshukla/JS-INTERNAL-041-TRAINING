using System;

delegate double BillingDelegate(double amount);

abstract class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Patient(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract double CalculateBill();
}

class GeneralPatient : Patient
{
    public GeneralPatient(int id, string name) : base(id, name) { }
    public override double CalculateBill() => 2000;
}

class ICUPatient : Patient
{
    public ICUPatient(int id, string name) : base(id, name) { }
    public override double CalculateBill() => 5000;
}

class EmergencyPatient : Patient
{
    public EmergencyPatient(int id, string name) : base(id, name) { }
    public override double CalculateBill() => 3500;
}

class OPDPatient : Patient
{
    public OPDPatient(int id, string name) : base(id, name) { }
    public override double CalculateBill() => 1000;
}

class Hospital
{
    public event Action<string> Notify;

    public void NotifyDepartment(string msg)
    {
        if (Notify != null)
            Notify(msg);
    }
}

class Billing
{
    public static double Insurance(double amount) => amount * 0.7;
    public static double SeniorCitizen(double amount) => amount * 0.6;
    public static double Staff(double amount) => amount * 0.5;
    public static double Normal(double amount) => amount;
}

class Program
{
    static void Main()
    {
        Hospital h = new Hospital();
        h.Notify += m => Console.WriteLine("Notification: " + m);

        char choice;

        do
        {
            Console.Write("\nEnter patient name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nSelect Patient Type:");
            Console.WriteLine("1. General");
            Console.WriteLine("2. ICU");
            Console.WriteLine("3. Emergency");
            Console.WriteLine("4. OPD");

            int type = int.Parse(Console.ReadLine());
            Patient p;

            switch (type)
            {
                case 1: p = new GeneralPatient(1, name); break;
                case 2: p = new ICUPatient(2, name); break;
                case 3: p = new EmergencyPatient(3, name); break;
                default: p = new OPDPatient(4, name); break;
            }

            double bill = p.CalculateBill();

            Console.WriteLine("\nSelect Billing Option:");
            Console.WriteLine("1. Insurance");
            Console.WriteLine("2. Senior Citizen");
            Console.WriteLine("3. Staff Discount");
            Console.WriteLine("4. Normal");

            int option = int.Parse(Console.ReadLine());
            BillingDelegate bd;

            switch (option)
            {
                case 1: bd = Billing.Insurance; break;
                case 2: bd = Billing.SeniorCitizen; break;
                case 3: bd = Billing.Staff; break;
                default: bd = Billing.Normal; break;
            }

            double finalAmount = bd(bill);

            Console.WriteLine("\nFinal Bill Amount: " + finalAmount);
            h.NotifyDepartment("Bill generated for " + p.Name);

            Console.Write("\nDo you want to add another patient? (y/n): ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (choice == 'y' || choice == 'Y');

        Console.WriteLine("\nThank you for using Hospital Billing System.");
    }
}
