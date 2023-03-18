using CsharpPerseritje.Implementime;
using CsharpPerseritje.Meny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPerseritje
{
    public class Inicializimi
    {
        
        public void Fillo()
        {
            
            Console.WriteLine("Mire se vini ne programin tone.");
            Console.WriteLine("Tregoni numrin e detyrave qe doni ti krijoni?");
            var detyrat = int.Parse(Console.ReadLine());

            for (int i = 1; i <= detyrat; i++)
            {
                Globalja.listaDetyrave.Add(new Detyra(i));
            }

            Console.WriteLine("Specifikoni punetoret ne formatin emri#mosha,emri#mosha:");

            var punetoretString = Console.ReadLine(); //Arjan#34,Arben#25
            var numri_i_punetoreve = punetoretString.Split(','); //string[] np = {"Arjan#34", "Arben#25" }


            foreach (var item in numri_i_punetoreve)
            {
                var punetori = item.Split('#');
                Globalja.listaePunetoreve.Add(new Punetor() { Emri = punetori[0], Mosha = int.Parse(punetori[1]) }); 
            }

            Console.WriteLine("Specifikoni udheheqesin ne formatin emri#mosha?");

            var udheheqesiString = Console.ReadLine(); //Arjan#34,Arben#25,Burim#20,Afrim#40
            var infoUdheheqesi = udheheqesiString.Split('#');

            Globalja.udheheqesi = new UdheheqesiGrupit(Globalja.listaePunetoreve) { Emri = infoUdheheqesi[0], Mosha = int.Parse(infoUdheheqesi[1]) };


            Console.WriteLine("Specifikoni Menaxherin ne formatin emri#mosha?");

            var menaxheriString = Console.ReadLine(); //Arjan#34,Arben#25,Burim#20,Afrim#40
            var infoMenaxheri = menaxheriString.Split('#');

            var punetoretEMenaxherit = Globalja.listaePunetoreve.Select(x => x).ToList();
            punetoretEMenaxherit.Add(Globalja.udheheqesi);

            Globalja.menaxheri = new Menaxher(new OperacioneMenaxhimi(), punetoretEMenaxherit) { Emri = infoMenaxheri[0], Mosha = int.Parse(infoMenaxheri[1]) };

            while (true)
            {
                Console.WriteLine("Zgjidh njeren:");
                Console.WriteLine("1. Menyne per punetoret");
                Console.WriteLine("2. Menyne per Udheheqesin");
                Console.WriteLine("3. Menyne per menaxherin");
                Console.WriteLine("4. Info per kompanine");
            
                var hyrje = int.Parse(Console.ReadLine());
                switch (hyrje)
                {
                    case 1:
                        new MenyjaPunetoreve();
                    break;

                    case 2:
                        new MenyjaUdheheqesit();
                    break;

                    case 3:
                        new MenyjaMenaxherit();
                        break;

                    case 4:
                        new InfoKompania();
                        break;

                    default:
                        new Shenimi<Punetor>();
                        break;
                }
            }

        }
    }
}
