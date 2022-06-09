* In QuoteBank we have two method to get a quote out of library called: 'getQuote();'.
* You can get a random quote by provide region in the getQuote parameter: 'getQuote("en-US")' for English. 
* In the future, we'll' try to cover more language support.
* Supported language: English(en-US), Vietnamese(vi-VI).
* Example:
```
using QuoteBank;
...
Quotes quotes = new Quotes();
lbQuotation.Text = quotes.getQuote("en-US");
```