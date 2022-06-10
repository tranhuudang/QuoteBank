


using QuoteBank.Languages;

namespace QuoteBank


{

   
    public class Quotes
    {

    class GetQuoteFunction
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
                                outQuote = vi_VI.ForMotivation[random.Next(vi_VI.ForMotivation.Length)];
                                break;
                            case QuoteType.Love:
                                outQuote = vi_VI.ForLove[random.Next(vi_VI.ForLove.Length)];
                                break;
                            case QuoteType.God:
                                outQuote = vi_VI.ForGod[random.Next(vi_VI.ForGod.Length)];
                                break;
                            case QuoteType.Teen:
                                outQuote = vi_VI.ForTeen[random.Next(vi_VI.ForTeen.Length)];
                                break;
                            case QuoteType.Wisdom:
                                outQuote = vi_VI.ForWisdom[random.Next(vi_VI.ForWisdom.Length)];
                                break;
                            default:
                                break;
                        }
                        break;
                    case "en-US":
                        switch (quoteType)
                        {
                            case QuoteType.Motivation:
                                outQuote = en_US.ForMotivation[random.Next(en_US.ForMotivation.Length)];
                                break;
                            case QuoteType.Love:
                                outQuote = en_US.ForLove[random.Next(en_US.ForLove.Length)];
                                break;
                            case QuoteType.God:
                                outQuote = en_US.ForGod[random.Next(en_US.ForGod.Length)];
                                break;
                            case QuoteType.Teen:
                                outQuote = en_US.ForTeen[random.Next(en_US.ForTeen.Length)];
                                break;
                            case QuoteType.Wisdom:
                                outQuote = en_US.ForWisdom[random.Next(en_US.ForWisdom.Length)];
                                break;
                            default:
                                break;
                        }
                        break;
                    case "zh-CN":
                        switch (quoteType)
                        {
                            case QuoteType.Motivation:
                                outQuote = zh_CN.ForMotivation[random.Next(zh_CN.ForMotivation.Length)];
                                break;
                            case QuoteType.Love:
                                outQuote = zh_CN.ForLove[random.Next(zh_CN.ForLove.Length)];
                                break;
                            case QuoteType.God:
                                outQuote = zh_CN.ForGod[random.Next(zh_CN.ForGod.Length)];
                                break;
                            case QuoteType.Teen:
                                outQuote = zh_CN.ForTeen[random.Next(zh_CN.ForTeen.Length)];
                                break;
                            case QuoteType.Wisdom:
                                outQuote = zh_CN.ForWisdom[random.Next(zh_CN.ForWisdom.Length)];
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
        // quote.Chinese.General()
        class English : en_US
        {
            public new string ForMotivation = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Motivation);
            public new string ForLove = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Love);
            public new string ForTeen = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Teen);
            public new string ForWisdom = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Wisdom);
            public new string ForGod = new GetQuoteFunction("zh-CN").getQuote(QuoteType.God);
        }
        class Chinese : zh_CN
        {
            public new string ForMotivation = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Motivation);
            public new string ForLove = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Love);
            public new string ForTeen = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Teen);
            public new string ForWisdom = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Wisdom);
            public new string ForGod = new GetQuoteFunction("zh-CN").getQuote(QuoteType.God);
        }
        class Vietnamese : vi_VI
        {
            public new string ForMotivation = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Motivation);
            public new string ForLove = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Love);
            public new string ForTeen = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Teen);
            public new string ForWisdom = new GetQuoteFunction("zh-CN").getQuote(QuoteType.Wisdom);
            public new string ForGod = new GetQuoteFunction("zh-CN").getQuote(QuoteType.God);
        }
      
    }
}