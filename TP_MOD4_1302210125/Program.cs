// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
namespace TP_MOD4_KPL
{
    class Mainprogram
    {
        public static void Main(string[] args)
        {
            KodePos table_kode_pos = new KodePos();
            Console.WriteLine("Kode pos Samoja");
            table_kode_pos.getkodepos("Samoja");
            Console.WriteLine("\n");
            Console.WriteLine("Kode pos semua Daerah");
            table_kode_pos.getallkodepos();
            Console.WriteLine("\n");
        }
    }
    class KodePos
    {
        Dictionary<string, int> dic_Kode_daerah = new Dictionary<string, int>(){
            {"Batununggal", 40266},
            {"Kujangsari", 40287},
            {"Mengger", 40267},
            {"Wates", 40256},
            {"Cijaura", 40287},
            {"Jatisari", 40286},
            {"Margasari", 40286},
            {"Sekejati", 40286},
            {"Kebonwaru", 40272},
            {"Maleer", 40274},
            {"Samoja", 40273},
        };

        public void getkodepos(string kode)
        {
            if (dic_Kode_daerah.ContainsKey(kode))
            {
                Console.WriteLine("- " + kode + " : " + dic_Kode_daerah[kode]);
            }
            else
            {
                Console.WriteLine(kode + "Kode tidak terdaftar");
            }
        }

        public void getallkodepos()
        {
            foreach (KeyValuePair<string, int> i in dic_Kode_daerah)
            {
                Console.WriteLine("- " + i.Key + " : " + i.Value);
            }
        }
    }
}
