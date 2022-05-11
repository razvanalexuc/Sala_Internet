using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase;

namespace Administrare_Fisier
{
    class AdministrarePeriferice_FisierText
    {
        private const int NR_PERIFERICE = 50;
        private string numeFisier;
        public AdministrarePeriferice_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddPeriferice(Periferice periferic)
        {

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(periferic.ConversieLaSir_PentruFisier());
            }

        }

        public Periferice[] GetPeriferice(out int nrPeriferice)
        {
            Periferice[] periferic = new Periferice[NR_PERIFERICE];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrPeriferice = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    periferic[nrPeriferice++] = new Periferice(linieFisier);
                }

            }
            return periferic;
        }

        public Periferice CautarePeriferic(string nume_periferic, string cod_periferic)
        {
            Periferice periferic = new Periferice();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    periferic = new Periferice(linieFisier);
                    if (periferic.Getmonitor() == nume_periferic)
                    {
                        return periferic;
                    }
                    continue;
                }
                return null;
            }

        }

    }
}

