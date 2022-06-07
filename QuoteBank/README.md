<p>In QuoteBank we have two method to get a quote out of library called: getQuote();</p>
<p>You can get a random quote by provide region in the getQuote parameter: getQuote("us") or getQuote("vi").</p>
<p>Example: </p>
<br/>
<p>using QuoteBank;</p>
<p>...</p>
<p>Quotes quotes = new Quotes();</p>
<p>lbQuotation.Text = quotes.getQuote("en");</p>