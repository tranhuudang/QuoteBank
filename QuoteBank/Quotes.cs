


using QuoteBank.Languages;

namespace QuoteBank
{
    public class Quotes
    {
        
        internal class GetQuoteFunction
        {
            string? Language { get; set; }
            public GetQuoteFunction(string language)
            {
                Language = language;
            }
            /// <summary>
            /// Get a random quote by a given language
            /// </summary>
            /// <param name="language">Use vi as Vietnamese and en English</param>
            /// <returns></returns>

            public string getQuote(string quoteType)
            {
                Random random = new Random();
                string outQuote = "";
                switch (Language)
                {
                    case "vi-VI":
                        switch (quoteType)
                        {
                            case QuoteType.Motivation:
                                outQuote = vi_VI.ForMotivation[random.Next(vi_VI.ForMotivation.Length)].Trim();
                                break;
                            case QuoteType.Love:
                                outQuote = vi_VI.ForLove[random.Next(vi_VI.ForLove.Length)].Trim();
                                break;
                            case QuoteType.Wisdom:
                                outQuote = vi_VI.ForWisdom[random.Next(vi_VI.ForWisdom.Length)].Trim();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "en-US":
                        switch (quoteType)
                        {
                            case QuoteType.Motivation:
                                outQuote = en_US.ForMotivation[random.Next(en_US.ForMotivation.Length)].Trim();
                                break;
                            case QuoteType.Love:
                                outQuote = en_US.ForLove[random.Next(en_US.ForLove.Length)].Trim();
                                break;
                            case QuoteType.Wisdom:
                                outQuote = en_US.ForWisdom[random.Next(en_US.ForWisdom.Length)].Trim();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "zh-CN":
                        switch (quoteType)
                        {
                            case QuoteType.Motivation:
                                outQuote = zh_CN.ForMotivation[random.Next(zh_CN.ForMotivation.Length)].Trim();
                                break;
                            case QuoteType.Love:
                                outQuote = zh_CN.ForLove[random.Next(zh_CN.ForLove.Length)].Trim();
                                break;
                            case QuoteType.Wisdom:
                                outQuote = zh_CN.ForWisdom[random.Next(zh_CN.ForWisdom.Length)].Trim();
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                return "\"" + outQuote + "\"";
            }
        }
        // Quotes.English quotes = new Quotes.English();
        // lbText.text = quotes.Motivation;

        public class English : en_US
        {
            public string Motivation = new GetQuoteFunction("en-US").getQuote(QuoteType.Motivation);
            public string Love = new GetQuoteFunction("en-US").getQuote(QuoteType.Love);
            public string Wisdom = new GetQuoteFunction("en-US").getQuote(QuoteType.Wisdom);
        }
        public class Chinese : zh_CN
        {
            public string Motivation = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Motivation);
            public string Love = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Love);
            public string Wisdom = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Wisdom);
        }
        public class Vietnamese : vi_VI
        {
            public string Motivation = new GetQuoteFunction("vi-VI").getQuote(QuoteType.Motivation);
            public string Love = new GetQuoteFunction("vi-VI").getQuote(QuoteType.Love);
            public string Wisdom = new GetQuoteFunction("vi-VI").getQuote(QuoteType.Wisdom);
        }
        
    }
}