In QuoteBank we have two method to get a quote out of library called: 'getQuote();'.
You can get a random quote by provide region in the getQuote parameter: 'getQuote("en-US")' for English or 'getQuote("vi-VI")' for Vietnamese. 
In the future, we'll' try to cover more language support.
Example:
```
using QuoteBank;
...
Quotes quotes = new Quotes();
lbQuotation.Text = quotes.getQuote("en");
```