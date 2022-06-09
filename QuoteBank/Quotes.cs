


using QuoteBank.Languages;

namespace QuoteBank
{
    public class Quotes
    {

       
        /// <summary>
        /// Get a specific quote with given language
        /// </summary>
        /// <param name="number">An integer number</param>
        /// <param name="language">Use vi as Vietnamese and en English</param>
        /// <returns></returns>
        public string getQuote(int number, string language)
        {
            string outQuote = "";
            switch (language)
            {
                case "vi-VI":
                    outQuote = vi_VI.quote_vietnamese[number];
                    break;
                case "en-US":
                    outQuote = en_US.quote_english[number];
                    break;
                case "zh-CN":
                    outQuote = zh_CN.quote_chinese[number];
                    break;
                default:
                    break;
            }
            return "\"" + outQuote + "\"";
        }
        /// <summary>
        /// Get a random quote by a given language
        /// </summary>
        /// <param name="language">Use vi as Vietnamese and en English</param>
        /// <returns></returns>
        public string getQuote(string language)
        {
            Random random = new Random();
            string outQuote = "";
            switch (language)
            {
                case "vi-VI":
                    outQuote = vi_VI.quote_vietnamese[random.Next(vi_VI.quote_vietnamese.Length)];
                    break;
                case "en-US":
                    outQuote = en_US.quote_english[random.Next(en_US.quote_english.Length)];
                    break;
                case "zh-CN":
                    outQuote = zh_CN.quote_chinese[random.Next(en_US.quote_english.Length)];
                    break;
                default:
                    break;
            }
            return "\"" + outQuote + "\"";
        }
    }
}