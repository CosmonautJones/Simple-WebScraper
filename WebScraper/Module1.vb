Imports MyCodeLibrary

Module Module1

    Sub Main()

        Dim myScrape = New Scrape()
        Dim result As String = myScrape.ScrapeWebpage("http://www.microsoft.com",
                                                      "C:\Example\mirosoft.txt")

        Console.WriteLine(result)
        Console.ReadLine()

    End Sub

End Module
