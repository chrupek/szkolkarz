using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace szkolkarz.core.utils
{
    class TranslationManager
    {
        private Dictionary<string, string> tranlationDictionary;

        public TranslationManager()
        {
        }

        public  Dictionary<string, string> getTranslations(string language)
        {
            switch (language){
                case ("polish"):return getPolishTranslations();

                default:        return null;

            }
              
        }

        private Dictionary<string, string> getPolishTranslations()
        {
            tranlationDictionary = new Dictionary<string, string>();

            tranlationDictionary.Add("cmdAddData", "Otwórz mapę");
            tranlationDictionary.Add("cmdPan", "Chwyć");
            tranlationDictionary.Add("cmdSelect", "Zaznacz");
            tranlationDictionary.Add("cmdZoom", "Powiększ");
            tranlationDictionary.Add("cmdZoomOut", "Pomniejsz");
            tranlationDictionary.Add("cmdZoomPrevious", "Poprzednie powiększenie");
            tranlationDictionary.Add("cmdZoomNext", "Następne powiększenie");
            tranlationDictionary.Add("cmdMaxExtents", "Dopasuj do rozmiaru mapy");

            return tranlationDictionary;
        }
    }
}
