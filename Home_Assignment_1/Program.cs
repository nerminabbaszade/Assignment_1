using System.ComponentModel.Design;

namespace Home_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname, father_name, address;
            char gender;
            
            Console.WriteLine("Adinizi daxil edin:");
            name=Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin:");
            surname = Console.ReadLine();
            Console.WriteLine("Ata adini daxil edin:");
            father_name = Console.ReadLine();
            Console.WriteLine("Cinsiyyeti daxil edin(K/Q):");
            gender =char.Parse( Console.ReadLine());
            Console.WriteLine("Dogum tarixini daxil edin (ay/gun/il):");
            DateTime birth_date = DateTime.Parse(Console.ReadLine());
            string formatted_bd = birth_date.ToString("dd/MM/yyyy");
            Console.WriteLine("Unvani daxil edin:");
            address = Console.ReadLine();

            TimeSpan age = DateTime.Now - birth_date;
            int years = (int) (age.TotalDays / 365.25);

            string cins;
            if (gender == 'K' || gender=='k') { cins = "oglu"; }
            else { cins = "qizi"; }

            string period;
            if (11 > years){period = "usaqliq"; } 
            else if  (16 > years) { period = "yeniyetmelik"; }
            else if (18 > years) { period = "erken genclik"; }
            else if (35 > years) { period = "genclik"; }
            else if (65 > years) { period = "orta yas dovru"; }
            else{ period = "qocaliq"; }

            string note;
            if (period == "genclik") { note = "qeyde alinmisdir."; }
            else { note = "qeyde alinmamisdir."; }

            Console.WriteLine("Siz " + surname + ' ' + name + ' ' + father_name + ' ' + cins + ", " +formatted_bd+" doguldugunuz ucun hal-hazirda "+ years+" yasiniz vardir. Azerbaycan qanunvericiliyine uygun olaraq "+period+" dovrunuzu yasayirsiniz. Bu is yerine sadece genclik doneminde olan sexsler muraciet ede bilerler. Bu telebi nezere alaraq sizin muracietiniz "+note);
        }
    }
}
