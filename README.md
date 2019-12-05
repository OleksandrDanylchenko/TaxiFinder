# TaxiFinder
# OOP Laboratory Work 3. Dynamic search system in custom XML data bases.

Application for finding appropriate taxi cars through filters in provided XML files.
Search can be executed in 3 different ways: DOM API, SAX API and Linq to XML.
I used the Levenshtein Distance Algorithm, so Brand, Color, Class and Driver fields is evaluated in probability terms. Model and Number is checked with .Contains() method for more exact results.
It allows the user to make mistakes in words, but if the similarity is >= 50% algorithm will generate a search request.
Also, you can convert search results into a fancy HTML file.

#### Demo:
![.gif demo](/TaxiDemo.gif)
![site demo](https://i.ibb.co/Q9MmqB1/Taxi-Demo-Site.png)

#### Step-by-step guide: [TaxiFinderGuide.pdf](https://github.com/OlexanderD/TaxiFinder/blob/master/%D0%A8%D0%BF%D0%B0%D1%80%D0%B3%D0%B0%D0%BB%D0%BA%D0%B0%20%D0%B4%D0%BE%20%D1%82%D1%80%D0%B5%D1%82%D1%8C%D0%BE%D1%97%20%D0%BB%D0%B0%D0%B1%D0%BE%D1%80%D0%B0%D1%82%D0%BE%D1%80%D0%BD%D0%BE%D1%97%20%D1%80%D0%BE%D0%B1%D0%BE%D1%82%D0%B8.pdf)