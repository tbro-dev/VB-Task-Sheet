Option Strict On

Module MainModule

    Dim Testing As Boolean = ModuleConstants.DEFAULT_ACTIVE

    Dim ProductID As Integer = 1
    Dim isActive As Boolean = True
    Dim Name As String = "10 Speed"
    Dim ListPrice As Decimal = 999.99D
    Dim SellStartDate As DateTime = #1/1/2019#

    Sub Main()


        ' ProductID = 1
        ' isActive = True
        ' Name = "10 Speed Bike"
        ' ListPrice = 999.99D
        ' SellStartDate = #1/1/2019#

        Console.WriteLine(Name)
        Console.WriteLine(DEFAULT_LIST_PRICE) ' public constant still accessible to sub main
        Console.ReadKey()
    End Sub

End Module
