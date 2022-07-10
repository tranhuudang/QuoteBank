* Get a random quotation in a topic by just a few line of code. 
* Supported language: Chinese, English, Vietnamese.
* In the future, we'll' try to cover more language.

* Example:
```
using QuoteBank;
...
Quotes.English quotes = new Quotes.English();
lbText.text = quotes.Motivation;

Quotes.Vietnamese quotes = new Quotes.Vietnamese();
lbText.text = quotes.Wisdom;
```