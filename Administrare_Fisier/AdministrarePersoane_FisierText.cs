using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase;
using System.Configuration;

namespace Administrare_Fisier
{
    public class AdministrarePersoane_FisierText
    {
        private const int NR_PERSOANE = 50;
        private string numeFisier;
        public AdministrarePersoane_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate); 
            streamFisierText.Close(); 
        }

        public void AddPersoane(Persoana persoana)
        {

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(persoana.ConversieLaSir_PentruFisier());
            }

        }

        public Persoana[] GetPersoane (out int nrPers)
        {
            Persoana[] persoane = new Persoana[NR_PERSOANE];

            using(StreamReader streamReader = new StreamReader (numeFisier))
            {
                string linieFisier;
                nrPers = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    persoane[nrPers++] = new Persoana(linieFisier);
                }
                
            }
            return persoane;
        }

        public Persoana CautarePersoana (string nume_pers, string cod_pers)
        {
            Persoana persoana = new Persoana();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    persoana = new Persoana(linieFisier);
                    if (persoana.GetNume() == nume_pers)
                    { return persoana;
                    }
                    continue;
                }
                return null;
                }

            }

        }
    }


