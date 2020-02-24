using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Roman_To_Urdu.Entities
{
    public class Word
    {
        public string Urdu { get; set; }
        public string Roman { get; set; }
    }

    public class WordMap : ClassMap<Word>
    {
        public WordMap()
        {
            Map(m => m.Urdu).NameIndex(0);
            Map(m => m.Roman).NameIndex(1);
        }
    }
}
